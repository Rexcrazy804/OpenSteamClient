using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenSteamworks.Attributes;
using OpenSteamworks.Callbacks.Structs;
using OpenSteamworks.Enums;
using OpenSteamworks.Generated;
using OpenSteamworks.Structs;

namespace OpenSteamworks.ClientInterfaces;

public class ClientMessaging : ClientInterface
{
    private SteamClient client;

    [CallbackListener<SharedConnectionMessageReady_t>]
    private void OnSharedConnectionMessageReady(SharedConnectionMessageReady_t sharedConnectionMessageReady) {
        
    }

    public ClientMessaging(SteamClient client) : base(client)
    {
        this.client = client;
    }
    
    internal override void RunShutdownTasks()
    {
        base.RunShutdownTasks();
        
    }

}