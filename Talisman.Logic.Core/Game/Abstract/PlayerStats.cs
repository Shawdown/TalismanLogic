namespace Talisman.Logic.Core.Game.Abstract
{
    /// <summary>
    /// Player stats.
    /// </summary>
    public class PlayerStats
    {
        public uint Health { get; set; }
        public uint MinStrength { get; set; }
        public uint Strength { get; set; }
        public uint MinCraft { get; set; }
        public uint Craft { get; set; }
        public uint Fate { get; set; }
        public uint DarkFate { get; set; }
        public uint LightFate { get; set; }
        public uint Gold { get; set; }
        public Alignment Alignment { get; set; }
    }
}