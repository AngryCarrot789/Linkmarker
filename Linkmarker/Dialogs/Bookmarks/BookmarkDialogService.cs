using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkmarker.Core.Dialogs.Bookmarks;

namespace Linkmarker.Dialogs.Bookmarks {
    public class BookmarkDialogService : IBookmarkDialogService {
        public Task<BookmarkDialogResult> ShowNewBookmarkDialogAsync(string defaultName = null, string defaultLink = null) {
            throw new NotImplementedException();
        }
    }
}
