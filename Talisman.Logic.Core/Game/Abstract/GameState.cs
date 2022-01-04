namespace Talisman.Logic.Core.Game.Abstract
{
    /// <summary>
    /// Game states.
    /// </summary>
    public enum GameState
    {
        /// <summary>
        /// Game has not been started.
        /// </summary>
        NotStarted = 0,

        /// <summary>
        /// Game has been started, and the initial setup is being performed.
        /// </summary>
        InitialSetup,

        /// <summary>
        /// Players are selecting characters.
        /// </summary>
        CharacterPick,

        /// <summary>
        /// Game is in progress.
        /// </summary>
        Playing,

        /// <summary>
        /// Game has been finished.
        /// </summary>
        Finished
    }
}