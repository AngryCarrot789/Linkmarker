using Linkmarker.Core.Dialogs.Message;
using Linkmarker.Core.Framework;

namespace Linkmarker.Core {
    public static class IoC {
        public static SimpleIoC Instance { get; } = new SimpleIoC();
        public static IMessageDialogService MessageDialogs => Instance.Provide<IMessageDialogService>();
    }
}
