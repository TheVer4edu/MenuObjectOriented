using System;

namespace UselessClasses.Menu.MenuElements {
    class PlayGame : MenuEntry {
        public PlayGame(string entryName) : base(entryName) {
            
        }

        public override void ProceedMenuAction() {
            Console.WriteLine("Игра началась");
        }
    }
}