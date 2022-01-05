using System;

namespace Talisman.Logic.Core.Gameplay.Implementation;

/// <summary>
/// Static manager for dice-related operations.
/// </summary>
public static class DiceManager
{
    /// <summary>
    /// Pseudo-random number generator.
    /// </summary>
    private static readonly Random _Random = new();

    /// <summary>
    /// Rolls a dice with the specified number of sides.
    /// </summary>
    /// 
    /// <param name="sides">Number of dice sides; the value must be >= 1.</param>
    /// 
    /// <returns>Roll result with minimal value of 1, and the maximum value of <paramref name="sides"/>.</returns>
    public static int RollDice(int sides = 6)
    {
        if (sides < 1)
        {
            throw new ArgumentException($"{nameof(sides)} must be >= 1.", nameof(sides));
        }

        return _Random.Next(1, sides + 1);
    }

    /// <summary>
    /// Rolls multiple dice with the specified number of sides.
    /// </summary>
    /// 
    /// <param name="numberOfDice">Number of dice to roll.</param>
    /// <param name="sides">Number of dice sides on each dice; the value must be >= 1.</param>
    /// 
    /// <returns>Array of roll results for each dice rolled with minimal value of 1, and the maximum value of <paramref name="sides"/>.</returns>
    public static int[] RollMultipleDice(int numberOfDice, int sides = 6)
    {
        int[] result = new int[numberOfDice];

        for (int i = 0; i < numberOfDice; i++)
        {
            result[i] = RollDice(sides);
        }

        return result;
    }
}