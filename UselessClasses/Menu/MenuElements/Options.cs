using System;

namespace UselessClasses.Menu.MenuElements {
    class Options : MenuEntry {
        public Options(string entryName) : base(entryName) { }
        public override void ProceedMenuAction() {
            Console.WriteLine("На экране вы видите опции");
        }
    }
}