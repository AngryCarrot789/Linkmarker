using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linkmarker.Core.Dialogs.Bookmarks {
    public interface IBookmarkDialogService {
        Task<BookmarkDialogResult> ShowNewBookmarkDialogAsync(string defaultName = null, string defaultLink = null);
    }
}
