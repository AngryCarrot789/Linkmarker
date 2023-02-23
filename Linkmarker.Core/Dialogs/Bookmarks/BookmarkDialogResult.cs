using Linkmarker.Core.Framework.Views;

namespace Linkmarker.Core.Dialogs.Bookmarks {
    public class BookmarkDialogResult : BaseDialogResult {
        public string Name { get; set; }

        public string Link { get; set; }

        public string CustomInfo { get; set; }
    }
}
