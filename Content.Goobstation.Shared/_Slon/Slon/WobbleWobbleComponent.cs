// namespace Content.Goida.Useless;

using Robust.Shared.GameStates;

namespace Content.Goobstation.Shared._Slon.Slon;

[RegisterComponent, NetworkedComponent]
public sealed partial class WobbleWobbleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField]
    public float Intensity { get; set; } = 15f;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField]
    public float CycleTime { get; set; } = 1.5f;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField]
    public Angle BaseRotation { get; set; } = Angle.Zero;
}
