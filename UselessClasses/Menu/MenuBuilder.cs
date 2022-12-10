using System.Collections.Generic;
using UselessClasses.Menu.MenuElements;

namespace UselessClasses.Menu {
    public class MenuBuilder {
        private Menu _menu = new Menu();

        public MenuBuilder AddNewEntry(MenuEntry entry) {
            _menu.Entries.Add(entry);
            return this;
        }

        public Menu build() {
            return _menu;
        }
    }
}