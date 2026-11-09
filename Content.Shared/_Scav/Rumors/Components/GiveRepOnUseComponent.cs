using Content.Shared._Persistence14.Rumors.Prototypes;
using Robust.Shared.Prototypes;

namespace Content.Shared._Scav.Rumors.Components;

[RegisterComponent]
public sealed partial class GiveRepOnUseComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public ProtoId<MetaFactionPrototype> Faction = "Green";

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int ReputationReward { get; set; } = 10;
}
