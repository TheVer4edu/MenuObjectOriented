using System;
using UselessClasses.Interaction;
using UselessClasses.Menu.MenuElements;

namespace UselessClasses {
    public class MenuDrawer {
        private Menu.Menu _menu;
        public int SelectedPosition { get; private set; }
        private const int PADDING = 2;
        private const int BULLET = 6;
        public Interactor Interactor { get; set; }

        public MenuDrawer(Menu.Menu menu) {
            _menu = menu;
        }

        public void Draw() {
            int maxLength = CalculateMaxLenghth();
            string separator = new String('-', maxLength + PADDING + BULLET);
            Console.WriteLine(separator);
            for (int i = 0; i < _menu.Entries.Count; i++) {
                MenuEntry entry = _menu.Entries[i];
                char bullet = i == SelectedPosition 
                    ? '*' 
                    : ' ';
                Console.WriteLine($"| {bullet} {entry.EntryName.PadRight(maxLength)} {bullet} |");
                Console.WriteLine(separator);
            }
        }
        
        public void InteractWithUser() {
            Interactor.Proceed();
        }
        public void IncreaseChoise() {
            SelectedPosition++;
            if (SelectedPosition >= _menu.Entries.Count) {
                SelectedPosition = 0;
            }
        }
        public void DecreaseChoise() {
            SelectedPosition--;
            if (SelectedPosition < 0) {
                SelectedPosition = _menu.Entries.Count - 1;
            }
        }
        public void HandleChoise(int selectedPosition) {
            _menu.HandleChoise(selectedPosition);
        }
        private int CalculateMaxLenghth() {
            int maxLength = 0;
            foreach (MenuEntry entry in _menu.Entries) {
                if (entry.EntryName.Length > maxLength) {
                    maxLength = entry.EntryName.Length;
                }
            }
            return maxLength;
        }
    }
}