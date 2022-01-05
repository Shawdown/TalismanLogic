using System.Collections.Generic;
using Talisman.Logic.Core.GameField.Abstract;

namespace Talisman.Logic.Core.GameField.Implementation;

/// <summary>
/// Represents a game field.
/// </summary>
public class Field : IField
{
    /// <inheritdoc/>
    public IEnumerable<IFieldRegion> Regions { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="regions">Game field regions.</param>
    public Field(IEnumerable<IFieldRegion> regions)
    {
        Regions = regions;
    }
}