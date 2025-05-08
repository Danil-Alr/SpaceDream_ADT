using Content.Shared.SD.RadialSelector;
using Robust.Shared.GameStates;

namespace Content.Shared.SD.ShortConstruction;

[RegisterComponent, NetworkedComponent]
public sealed partial class ShortConstructionComponent : Component
{
    [DataField(required: true)]
    public List<RadialSelectorEntry> Entries = new();
}
