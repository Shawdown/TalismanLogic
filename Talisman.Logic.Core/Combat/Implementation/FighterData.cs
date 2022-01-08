using System;
using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Combat.Implementation;

/// <summary>
/// DTO with a single combat participant data.
/// </summary>
public class FighterData
{
    /// <summary>
    /// Combat participant.
    /// </summary>
    public IFightable Fighter { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="fighter">Combat participant.</param>
    public FighterData(IFightable fighter)
    {
        Fighter = fighter ?? throw new ArgumentNullException(nameof(fighter));
    }
}