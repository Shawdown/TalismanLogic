using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Talisman.Game.Logic.Tests.TestComponents;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Decks.Implementation;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Game.Logic.Tests.Cards;

/// <summary>
/// Tests for class <see cref="CardUtils"/>.
/// </summary>
[TestClass]
public class CardUtilsTests
{
    /// <summary>
    /// Burns a previously owned Card using method <see cref="CardUtils.BurnCard"/>.
    /// </summary>
    [TestMethod]
    public void Burn_OkTest()
    {
        // Arrange
        Player currentOwner = new Player();
        Deck deck = new Deck();
        Deck burntCardsDeck = new Deck();
        TestBaseCard card = new TestBaseCard(deck, null)
        {
            IsOwnable = true,
            Owner = currentOwner,
            CurrentDeck = deck
        };
        currentOwner.OwnedCards.Add(card);

        // Act
        CardUtils.BurnCard(null, card, burntCardsDeck);

        // Assert
        Assert.IsTrue(!currentOwner.OwnedCards.Any());
        Assert.IsTrue(card.Owner == null);
        Assert.IsTrue(card.Burnt);
        Assert.IsTrue(card.CurrentDeck == burntCardsDeck);
    }

    /// <summary>
    /// Sets ownable Card's owner using method <see cref="CardUtils.SetCardOwner"/>.
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
        CardUtils.SetCardOwner(null, card, newOwner);

        // Assert
        Assert.IsTrue(!currentOwner.OwnedCards.Any());
        Assert.IsTrue(newOwner.OwnedCards.Contains(card));
        Assert.IsTrue(card.Owner == newOwner);
    }

    /// <summary>
    /// Sets non-ownable Card's owner using method <see cref="CardUtils.SetCardOwner"/>.
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
        CardUtils.SetCardOwner(null, card, newOwner);

        // Assert
        Assert.IsTrue(!newOwner.OwnedCards.Any());
        Assert.IsTrue(card.Owner is null);
    }
}