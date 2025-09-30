using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using UnityEngine;

using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GrammaphoneBomb.Items.Grammaphone;

[CustomItem(ItemType.SCP1576)]
public class GrammaphoneBomb : CustomItem {
    public override ItemType Type { get; set; } = ItemType.SCP1576;

    public override uint Id { get; set; } = 2;
    public override string Name { get; set; } = "Grammaphone Bomb";
    public override string Description { get; set; } = "Its like Jack-In-A-Box but more explosive";
    public override float Weight { get; set; } = 1.5f;

    public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties() {
        Limit = 1
    };
    
    protected override void SubscribeEvents() {
        PlayerEvent.UsedItem += OnItemUsed;
        base.SubscribeEvents();
    }

    protected override void UnsubscribeEvents() {
        PlayerEvent.UsedItem -= OnItemUsed;
        base.UnsubscribeEvents();
    }

    private void OnItemUsed(UsedItemEventArgs ev) {
        if (!Check(ev.Item))
            return;
        
        ev.Item.Destroy();
        ev.Player.Explode();
    }
}