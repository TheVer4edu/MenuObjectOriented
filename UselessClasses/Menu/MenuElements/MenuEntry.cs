namespace UselessClasses.Menu.MenuElements {
    public abstract class MenuEntry {
        public string EntryName { get; }

        public MenuEntry(string entryName) {
            this.EntryName = entryName;
        }

        public abstract void ProceedMenuAction();
    }
}