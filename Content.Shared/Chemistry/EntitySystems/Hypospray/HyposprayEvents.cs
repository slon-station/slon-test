// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Ted Lukin <66275205+pheenty@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

<<<<<<<< HEAD:Content.Goobstation.Common/Chemistry/HyposprayEvents.cs
namespace Content.Goobstation.Common.Chemistry;
========
namespace Content.Shared.Chemistry.EntitySystems.Hypospray;
>>>>>>>> Goob-Station/master:Content.Shared/Chemistry/EntitySystems/Hypospray/HyposprayEvents.cs

/// <summary>
/// Raised on a hypospray when it successfully injects.
/// </summary>
[ByRefEvent]
public record struct AfterHyposprayInjectsEvent()
{
    public AfterHyposprayInjectsEvent(EntityUid user, EntityUid target) : this()
    {
        User = user;
        Target = target;
    }

    /// <summary>
    /// Entity that used the hypospray.
    /// </summary>
    public EntityUid User;

    /// <summary>
    /// Entity that was injected.
    /// </summary>
    public EntityUid Target;
}
