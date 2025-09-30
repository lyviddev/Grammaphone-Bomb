using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace GrammaphoneBomb;

public sealed class Config : IConfig {
    public bool Debug { get; set; } = false;
    public bool IsEnabled { get; set; } = true;

    public Items.Grammaphone.GrammaphoneBomb Grammaphone { get; set; } = new();
    public List<Items.Grammaphone.GrammaphoneBomb> Grammaphones { get; set; } = new();
}