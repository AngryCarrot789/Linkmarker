namespace Linkmarker.Core.Framework.Views {
    public abstract class BaseDialogViewModel : BaseViewModel {
        public IView View { get; }

        protected BaseDialogViewModel(IView view) {
            this.View = view;
        }
    }
}