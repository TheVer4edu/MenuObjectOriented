using System.Collections.Generic;
using UselessClasses.Menu.MenuElements;

namespace UselessClasses.Menu {
    public class Menu {
        public List<MenuEntry> Entries = new List<MenuEntry>();

        public void HandleChoise(int entryIndex) {
            MenuEntry entry = Entries[entryIndex];
            entry.ProceedMenuAction();
        }
    }
}