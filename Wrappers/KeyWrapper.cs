using Quiccent.Constants;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiccent.Wrappers
{
    public class KeyWrapper
    {
        protected Accents Accents { get; set; }
        public IList<string> CharacterSelections { get; private set; }
        public Keys Key { get; private set; }
        public bool Caps { get; private set; }

        public KeyWrapper(Accents accents, Keys key, bool caps = false)
        {
            Accents = accents;
            CharacterSelections = new List<string>();
            Set(key, caps);
        }

        public void Set(Keys key, bool caps = false)
        {
            ResolveNewCurrentHeldKeyState(key, caps);
        }

        private void ResolveNewCurrentHeldKeyState(Keys key, bool caps = false)
        {
            Key = key;
            Caps = caps;

            CharacterSelections = Caps ? Accents.Mappings[Constants.Constants.PossibleCapitalizedAccentedKeys[Key]] : Accents.Mappings[Constants.Constants.PossibleAccentedKeys[Key]];
        }
    }
}
