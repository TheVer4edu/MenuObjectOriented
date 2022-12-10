namespace UselessClasses.Interaction {
    public abstract class Interactor {

        protected MenuDrawer _drawer;
        
        protected Interactor(MenuDrawer drawer) {
            _drawer = drawer;
        }

        public abstract void Proceed();

    }
}