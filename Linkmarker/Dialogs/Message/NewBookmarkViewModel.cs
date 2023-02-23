using Linkmarker.Core;
using Linkmarker.Core.Framework.Views;

namespace Linkmarker.Dialogs.Message {
    public class NewBookmarkViewModel : BaseConfirmableDialogViewModel {
        /// <summary>
        /// The bookmark view model for the window to bind to
        /// </summary>
        public BookmarkViewModel Bookmark { get; }

        public NewBookmarkViewModel(IView view) : base(view) {
            this.Bookmark = new BookmarkViewModel();
        }
    }
}