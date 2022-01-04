using Talisman.Logic.Core.Cards.Implementation;

namespace Talisman.Logic.ExternalPackageExample.Objects
{
    public sealed class Sword : ObjectCard
    {
        /// <inheritdoc />
        public Sword(string name, string description) : base("Sword", "Sample description.")
        {
        }
    }
}