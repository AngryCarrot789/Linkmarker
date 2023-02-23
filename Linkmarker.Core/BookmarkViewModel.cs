using Linkmarker.Core.Framework;

namespace Linkmarker.Core {
    public class BookmarkViewModel : BaseViewModel {
        private string name;
        public string Name {
            get => this.name;
            set => this.RaisePropertyChanged(ref this.name, value);
        }

        private string link;
        public string Link {
            get => this.link;
            set => this.RaisePropertyChanged(ref this.link, value);
        }

        private string customInfo;
        public string CustomInfo {
            get => this.customInfo;
            set => this.RaisePropertyChanged(ref this.customInfo, value);
        }
    }
}