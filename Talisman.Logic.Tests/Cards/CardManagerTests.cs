using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Talisman.Game.Logic.Tests.TestComponents;
using Talisman.Logic.Core.Decks.Implementation;
using Talisman.Logic.Core.Gameplay.Implementation;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Game.Logic.Tests.Cards;

/// <summary>
/// Tests for class <see cref="CardManager"/>.
/// </summary>
[TestClass]
public class CardManagerTests
{
    /// <summary>
    /// Discards a valid discardable Card using method <see cref="CardManager.Discard"/>.
    /// </summary>
    [TestMethod]
    public void Discard_DiscardableCardTest()
    {
        // Arrange
        Player player = new Player();
        Deck deck = new Deck();
        Deck discardDeck = new Deck();
        TestBaseCard card = new TestBaseCard(deck, discardDeck)
        {
            IsOwnable = true,
            Owner = player
        };
        player.OwnedCards.Add(card);

        // Act
        CardManager.Discard(null, card);

        // Assert
        Assert.IsTrue(discardDeck.Cards.Count == 1);
        Assert.IsTrue(discardDeck.Cards.Contains(card));
        Assert.IsTrue(!player.OwnedCards.Any());
        Assert.IsTrue(card.Owner is null);
    }

    /// <summary>
    /// Sets ownable Card's owner using method <see cref="CardManager.SetCardOwner"/>.
    /// </summary>
    [TestMethod]
    public void SetOwner_OwnableTest()
    {
        // Arrange
        Player currentOwner = new Player();
        Player newOwner = new Player();
        Deck deck = new Deck();
        TestBaseCard card = new TestBaseCard(deck, null)
        {
            IsOwnable = true,
            Owner = currentOwner
        };
        currentOwner.OwnedCards.Add(card);

        // Act
        CardManager.SetCardOwner(null, card, newOwner);

        // Assert
        Assert.IsTrue(!currentOwner.OwnedCards.Any());
        Assert.IsTrue(newOwner.OwnedCards.Contains(card));
        Assert.IsTrue(card.Owner == newOwner);
    }

    /// <summary>
    /// Sets non-ownable Card's owner using method <see cref="CardManager.SetCardOwner"/>.
    /// </summary>
    [TestMethod]
    public void SetOwner_NonOwnableTest()
    {
        // Arrange
        Player newOwner = new Player();
        Deck deck = new Deck();
        TestBaseCard card = new TestBaseCard(deck, null)
        {
            IsOwnable = false,
        };

        // Act
        CardManager.SetCardOwner(null, card, newOwner);

        // Assert
        Assert.IsTrue(!newOwner.OwnedCards.Any());
        Assert.IsTrue(card.Owner is null);
    }
}