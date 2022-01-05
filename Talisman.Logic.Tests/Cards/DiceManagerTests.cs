using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Talisman.Logic.Core.Gameplay.Implementation;

namespace Talisman.Game.Logic.Tests.Cards;

/// <summary>
/// Tests for class <see cref="DiceManager"/>.
/// </summary>
[TestClass]
public class DiceManagerTests
{
    /// <summary>
    /// Rolls 100 12-sided dice using method <see cref="DiceManager.RollDice"/> and validates the roll results.
    /// </summary>
    [TestMethod]
    public void RollDice_100RollsTest()
    {
        // Arrange
        int[] rollResults = new int[100];

        // Act
        for (int i = 0; i < rollResults.Length; i++)
        {
            rollResults[i] = DiceManager.RollDice(12);
        }

        // Assert
        foreach (int rollResult in rollResults)
        {
            Assert.IsTrue(rollResult is >= 1 and <= 12);
        }
    }

    /// <summary>
    /// Rolls 100 6-sided dice with 2 dice per roll using method <see cref="DiceManager.RollMultipleDice"/> and validates the roll results.
    /// </summary>
    [TestMethod]
    public void RollMultipleDice_50RollsTest()
    {
        // Arrange
        int[][] rollResults = new int[50][];

        // Act
        for (int i = 0; i < 50; i++)
        {
            rollResults[i] = DiceManager.RollMultipleDice(2, 6);
        }

        // Assert
        foreach (int[] rollResult in rollResults)
        {
            Assert.IsTrue(rollResult.All(item => item is >= 1 and <= 6));
        }
    }

    /// <summary>
    /// Calls method <see cref="DiceManager.RollDice"/> providing invalid arguments.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void RollDice_ArgumentExceptionTest()
    {
        // Arrange

        // Act
        DiceManager.RollDice(0);

        // Assert
        Assert.Fail($"Exception {nameof(ArgumentException)} has not been thrown.");
    }
}