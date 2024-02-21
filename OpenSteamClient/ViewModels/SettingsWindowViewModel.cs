using System;
using OpenSteamClient.Translation;
using OpenSteamClient.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using OpenSteamworks;
using OpenSteamworks.Client;
using OpenSteamworks.Client.Managers;
using OpenSteamworks.Enums;
using OpenSteamworks.Generated;
using OpenSteamworks.Structs;

namespace OpenSteamClient.ViewModels;

public partial class SettingsWindowViewModel : AvaloniaCommon.ViewModelBase
{
    private TranslationManager tm;
    private ISteamClient client;
    private LoginManager loginManager;
    public SettingsWindowViewModel(ISteamClient client, TranslationManager tm, LoginManager loginManager)
    {
        this.client = client;
        this.tm = tm;
        this.loginManager = loginManager;
    }
}