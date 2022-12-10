using UselessClasses.Interaction;
using UselessClasses.Interaction.KeyHandlers;
using UselessClasses.Menu;
using UselessClasses.Menu.MenuElements;

namespace UselessClasses {
    class Program {
        public static void Main(string[] args) {
            Menu.Menu menu = new MenuBuilder()
                .AddNewEntry(new PlayGame("Играть"))
                .AddNewEntry(new Options("Опции"))
                .AddNewEntry(new ExitGame("Выйти"))
                .build();
            MenuDrawer drawer = new MenuDrawer(menu);
            drawer.Interactor = GetInteractor(drawer);
            drawer.Draw();
            while (true) {
                drawer.InteractWithUser();
            }
        }

        public static Interactor GetInteractor(MenuDrawer drawer) {
            UserKeyboardInteractor interactor = new UserKeyboardInteractor(drawer);
            interactor.AddKeyHandler(new ArrowUpKeyHandler(drawer));
            interactor.AddKeyHandler(new ArrowDownKeyHandler(drawer));
            interactor.AddKeyHandler(new EnterKeyHandler(drawer));
            interactor.AddKeyHandler(new EscapeKeyHandler());
            return interactor;
        }
    }
}