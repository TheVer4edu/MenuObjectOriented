using System;

namespace UselessClasses.Interaction.KeyHandlers {
    public class EscapeKeyHandler : KeyHandler {
        public EscapeKeyHandler() : base(ConsoleKey.Escape) { }

        public override bool Handle() {
            Environment.Exit(0);
            return false;
        }
    }
}