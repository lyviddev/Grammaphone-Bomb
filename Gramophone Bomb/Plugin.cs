using System;
using Exiled.API.Features;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;

namespace GramophoneBomb;

public class Plugin : Plugin<Config> {
    public override string Name => "Gramophone Bomb";
    public override string Author => "Lyvid_Dev";
    public override Version Version => new Version(1, 0, 0);

    public static Plugin Singleton;

    public override void OnEnabled() {
        Singleton = this;
        CustomItem.RegisterItems();
        new Items.Gramophone.GramophoneBomb().Register();
        base.OnEnabled();
    }
    
    public override void OnDisabled() {
        Singleton = null;
        CustomItem.UnregisterItems();
        base.OnDisabled();
    }
}