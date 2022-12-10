using System;
using System.Collections.Generic;
using UselessClasses.Interaction.KeyHandlers;

namespace UselessClasses.Interaction {
    public class UserKeyboardInteractor : Interactor {
        private List<KeyHandler> _handlers = new List<KeyHandler>();

        public UserKeyboardInteractor(MenuDrawer drawer) : base(drawer) { }

        public void AddKeyHandler(KeyHandler handler) {
            _handlers.Add(handler);
        }

        public override void Proceed() {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            foreach (KeyHandler handler in _handlers) {
                if (handler.Key == keyInfo.Key) {
                    bool shouldRedraw = handler.Handle();
                    if (shouldRedraw) {
                        Console.Clear();
                        _drawer.Draw();
                    }
                }
            }
        }
    }
}