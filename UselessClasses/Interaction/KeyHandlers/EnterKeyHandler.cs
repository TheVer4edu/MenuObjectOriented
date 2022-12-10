using System;

namespace UselessClasses.Interaction.KeyHandlers {
    public class EnterKeyHandler : KeyHandler {
        private readonly MenuDrawer _drawer;

        public EnterKeyHandler(MenuDrawer drawer) : base(ConsoleKey.Enter) {
            _drawer = drawer;
        }

        public override bool Handle() {
            Console.Clear();
            _drawer.HandleChoise(_drawer.SelectedPosition);
            return false;
        }
    }
}