using System;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Represents a single player stat data.
/// </summary>
public class PlayerStatData
{
    /// <summary>
    /// Minimum stat value.
    /// </summary>
    public uint MinValue { get; set; }

    /// <summary>
    /// Maximum stat value.
    /// </summary>
    public uint MaxValue { get; set; }

    /// <summary>
    /// Current stat value.
    /// </summary>
    public uint CurrentValue { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="maxValue">Maximal stat value.</param>
    /// <param name="currentValue">Current stat value</param>
    /// <param name="minValue">Minimum stat value.</param>
    public PlayerStatData(uint maxValue, uint currentValue, uint minValue = 0)
    {
        MaxValue = maxValue;
        CurrentValue = currentValue;
        MinValue = minValue;
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public PlayerStatData()
    {
        MaxValue = 0;
        CurrentValue = 0;
        MinValue = 0;
    }

    /// <summary>
    /// Adds <paramref name="restoreByValue"/> to <see cref="CurrentValue"/> if its resulting value does not exceed <see cref="MaxValue"/>.
    /// </summary>
    /// 
    /// <param name="restoreByValue">Int to add to existing value.</param>
    public void RestoreCurrentValue(uint restoreByValue)
    {
        if (restoreByValue > 0 && CurrentValue + restoreByValue <= MaxValue)
        {
            CurrentValue += restoreByValue;
        }
    }

    /// <summary>
    /// Updates required value based on the specified value type by adding <paramref name="updateByValue"/> to its existing value.
    /// </summary>
    /// 
    /// <param name="valueType">Value type to update.</param>
    /// <param name="updateByValue">Int to add to existing value.</param>
    public void UpdateValue(PlayerStatValueType valueType, int updateByValue)
    {
        switch (valueType)
        {
            case PlayerStatValueType.Current:
                CurrentValue = (uint)((int)CurrentValue + updateByValue > 0 ? CurrentValue + updateByValue : 0);
                break;
            case PlayerStatValueType.Max:
                MaxValue = (uint)((int)MaxValue + updateByValue > 0 ? MaxValue + updateByValue : 0);
                break;
            case PlayerStatValueType.Min:
                MinValue = (uint)((int)MinValue + updateByValue > 0 ? MinValue + updateByValue : 0);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(valueType), valueType, null);
        }
    }

    /// <summary>
    /// Sets required value based on the specified value type to <paramref name="valueToSet"/>.
    /// </summary>
    /// 
    /// <param name="valueType">Value type to set.</param>
    /// <param name="valueToSet">Int to set the specified value to.</param>
    public void SetValue(PlayerStatValueType valueType, uint valueToSet)
    {
        switch (valueType)
        {
            case PlayerStatValueType.Current:
                CurrentValue = valueToSet;
                break;
            case PlayerStatValueType.Max:
                MaxValue = valueToSet;
                break;
            case PlayerStatValueType.Min:
                MinValue = valueToSet;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(valueType), valueType, null);
        }
    }
}