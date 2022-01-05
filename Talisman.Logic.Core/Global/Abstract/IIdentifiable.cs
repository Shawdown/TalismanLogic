namespace Talisman.Logic.Core.Global.Abstract;

/// <summary>
/// Defines the ID property for identifiable classes.
/// </summary>
public interface IWithId
{
    /// <summary>
    /// Object's ID.
    /// </summary>
    public int Id { get; }
}