using System;

namespace UselessClasses.Menu.MenuElements {
    class ExitGame : MenuEntry {
        public ExitGame(string entryName) : base(entryName) { }

        public override void ProceedMenuAction() {
            Exit();
        }

        private void Exit() {
            Console.WriteLine("Произошёл выход");
            Environment.Exit(0);
        }
    }
}