namespace Talisman.Logic.Core.Cards.Abstract;

/// <summary>
/// Defines properties and methods for classes representing enemy game cards.
/// </summary>
public interface IEnemyCard : ICard, IFightable
{
    /// <summary>
    /// Enemy type.
    /// </summary>
    EnemyType EnemyType { get; }

    /// <summary>
    /// Enemy  trophy value.
    /// </summary>
    int TrophyValue { get; set; }
}