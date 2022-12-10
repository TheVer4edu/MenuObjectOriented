using System;

namespace UselessClasses.Interaction.KeyHandlers {
    public abstract class KeyHandler {
        public ConsoleKey Key { get; }
        protected KeyHandler(ConsoleKey key) {
            Key = key;
        }

        public abstract bool Handle();
    }
}