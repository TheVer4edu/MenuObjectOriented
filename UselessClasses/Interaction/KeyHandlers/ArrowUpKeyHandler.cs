using System;

namespace UselessClasses.Interaction.KeyHandlers {
    public class ArrowUpKeyHandler : KeyHandler {
        private readonly MenuDrawer _drawer;

        public ArrowUpKeyHandler(MenuDrawer drawer) : base(ConsoleKey.UpArrow) {
            _drawer = drawer;
        }

        public override bool Handle() {
            _drawer.DecreaseChoise();
            return true;
        }
    }
}