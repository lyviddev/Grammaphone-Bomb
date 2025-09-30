using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace GramophoneBomb;

public sealed class Config : IConfig {
    public bool Debug { get; set; } = false;
    public bool IsEnabled { get; set; } = true;

    public Items.Gramophone.GramophoneBomb Gramophone { get; set; } = new();
    public List<Items.Gramophone.GramophoneBomb> Gramophones { get; set; } = new();
}