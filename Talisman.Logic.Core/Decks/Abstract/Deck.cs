using System.Collections;
using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Implementation;

namespace Talisman.Logic.Core.Decks.Abstract
{
    /// <summary>
    /// Represents a card deck.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Deck cards.
        /// </summary>
        public IList<BaseCard> Cards { get; set; } = new List<BaseCard>();
    }
}