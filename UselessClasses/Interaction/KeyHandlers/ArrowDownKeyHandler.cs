using System;

namespace UselessClasses.Interaction.KeyHandlers {
    public class ArrowDownKeyHandler : KeyHandler {
        private readonly MenuDrawer _drawer;
        public ArrowDownKeyHandler(MenuDrawer drawer) : base(ConsoleKey.DownArrow) {
            _drawer = drawer;
        }

        public override bool Handle() {
            _drawer.IncreaseChoise();
            return true;
        }
    }
}