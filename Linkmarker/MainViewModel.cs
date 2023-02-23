using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Linkmarker.Core;
using Linkmarker.Core.Framework;
using Linkmarker.Core.Framework.Commands;

namespace Linkmarker {
    public class MainViewModel : BaseViewModel {
        public ObservableCollection<BookmarkViewModel> Bookmarks { get; }

        public ICommand NewBookmarkCommand { get; }

        public MainViewModel() {
            this.Bookmarks = new ObservableCollection<BookmarkViewModel>();
            this.NewBookmarkCommand = new RelayCommand(CreateBookmarkAction);
        }

        public void CreateBookmarkAction() {

        }
    }
}
