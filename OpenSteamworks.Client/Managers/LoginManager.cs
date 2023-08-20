using System.Diagnostics.CodeAnalysis;
using OpenSteamworks.Client.Config;
using OpenSteamworks;
using OpenSteamworks.Attributes;
using OpenSteamworks.Callbacks.Structs;
using OpenSteamworks.Enums;
using OpenSteamworks.Structs;
using OpenSteamworks.Client.Utils.Interfaces;

namespace OpenSteamworks.Client.Managers;

public class LoginManager : Component
{
    private SteamClient steamClient;
    private LoginUsers loginUsers;

    public LoginManager(SteamClient steamClient, LoginUsers loginUsers, IContainer container) : base(container)
    {
        this.steamClient = steamClient;
        this.loginUsers = loginUsers;
    }

    public bool GetMostRecentAutologinUser([NotNullWhen(true)] out LoginUser? autologinUser) {
        autologinUser = null;
        foreach (var user in loginUsers.Users)
        {
            if (!user.AllowAutoLogin) {
                continue;
            }

            if (user.MostRecent) {
                autologinUser = user;
                break;
            }
        }

        return autologinUser != null;
    }

    public bool GetAllowedAutologinUsers(out IEnumerable<LoginUser> autologinUser) {
        var validUsers = new List<LoginUser>();
        foreach (var user in loginUsers.Users)
        {
            if (!user.AllowAutoLogin) {
                continue;
            }

            validUsers.Add(user);
        }

        autologinUser = validUsers;
        return validUsers.Count > 0;
    }

    private void SetUserAsLastLogin(LoginUser user) {
        for (int i = 0; i < loginUsers.Users.Count; i++)
        {
            var userToModify = loginUsers.Users[i];
            userToModify.MostRecent = (userToModify.SteamID == user.SteamID);
            loginUsers.Users[i] = userToModify;
        }
    }

    private bool isLoggingOn = false;
    private EResult? loginFinishResult;
    [CallbackListener<SteamServerConnectFailure_t>]
    public void OnSteamServerConnectFailure(SteamServerConnectFailure_t failure) {
        if (isLoggingOn) {
            loginFinishResult = failure.m_EResult;
        }
    }

    [CallbackListener<SteamServersConnected_t>]
    public void OnSteamServersConnected(SteamServersConnected_t connected) {
        if (isLoggingOn) {
            loginFinishResult = EResult.k_EResultOK;
        }
    }
    
    public void SetMachineName(string machineName) {
        steamClient.NativeClient.IClientUser.SetUserMachineName(machineName);
    }

    public Task<EResult> LoginToUser(LoginUser user) {
        return Task.Run(async () =>
        {
            if (user.LoginMethod == null)
            {
                throw new ArgumentException("LoginMethod must be set");
            }

            switch (user.LoginMethod)
            {
                case LoginMethod.UsernamePassword:
                    OpenSteamworks.Client.Utils.UtilityFunctions.AssertNotNull(user.AccountName);
                    OpenSteamworks.Client.Utils.UtilityFunctions.AssertNotNull(user.Password);
                    steamClient.NativeClient.IClientUser.SetLoginInformation(user.AccountName, user.Password, user.Remembered);
                    if (user.SteamGuardCode != null) {
                        steamClient.NativeClient.IClientUser.SetTwoFactorCode(user.SteamGuardCode);
                    }
                    break;
                case LoginMethod.Cached:
                    OpenSteamworks.Client.Utils.UtilityFunctions.AssertNotNull(user.AccountName);

                    if (!steamClient.NativeClient.IClientUser.BHasCachedCredentials(user.AccountName))
                    {
                        return EResult.k_EResultCachedCredentialIsInvalid;
                    }

                    steamClient.NativeClient.IClientUser.SetAccountNameForCachedCredentialLogin(user.AccountName, false);
                    break;
                case LoginMethod.JWT:
                    OpenSteamworks.Client.Utils.UtilityFunctions.AssertNotNull(user.LoginToken);
                    throw new NotImplementedException();
                    steamClient.NativeClient.IClientUser.SetLoginToken(user.LoginToken, "");
                    break;
            }

            this.loginFinishResult = null;
            this.isLoggingOn = true;

            OpenSteamworks.Client.Utils.UtilityFunctions.Assert(user.SteamID.HasValue);
            
            // This cast is stupid. 
            EResult beginLogonResult = steamClient.NativeClient.IClientUser.LogOn((CSteamID)user.SteamID);

            if (beginLogonResult != EResult.k_EResultOK) {
                this.isLoggingOn = false;
                return beginLogonResult;
            }

            // This cast is stupid as well. 
            EResult result = (EResult)(await Task.Run(() => {
                do
                {
                    System.Threading.Thread.Sleep(30);
                } while (this.loginFinishResult == null);
                this.isLoggingOn = false;
                return this.loginFinishResult;
            }));

            if (result == EResult.k_EResultOK)
            {
                if (loginUsers.Users.Contains(user))
                {
                    SetUserAsLastLogin(user);
                }
                else if (user.AllowAutoLogin == true)
                {
                    loginUsers.Users.Add(user);
                    SetUserAsLastLogin(user);
                }
            } else {
                return result;
            }


            return EResult.k_EResultOK;
        });
    }

    public override async Task RunStartup()
    {
        await EmptyAwaitable();
    }

    public override async Task RunShutdown()
    {
        await EmptyAwaitable();
    }
}