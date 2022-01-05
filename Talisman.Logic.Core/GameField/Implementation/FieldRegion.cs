using System.Collections.Generic;
using Talisman.Logic.Core.GameField.Abstract;

namespace Talisman.Logic.Core.GameField.Implementation;

/// <summary>
/// Represents a game field region.
/// </summary>
public class FieldRegion : IFieldRegion
{
    /// <inheritdoc />
    public int Id { get; }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <inheritdoc />
    public IList<IFieldCell> Cells { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="id">Region's ID.</param>
    public FieldRegion(int id)
    {
        Id = id;
    }
}