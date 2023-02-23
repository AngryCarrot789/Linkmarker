using System.Threading.Tasks;
using Linkmarker.Core.Utils;

namespace Linkmarker.Core.Dialogs.Message {
    public interface IMessageDialogService {
        Task ShowMessageAsync(string caption, string message);

        Task ShowMessageAsync(string message);

        Task<MsgDialogResult> ShowDialogAsync(string caption, string message, MsgDialogType type = MsgDialogType.OK, MsgDialogResult defaultResult = MsgDialogResult.OK);

        Task<bool> ShowYesNoDialogAsync(string caption, string message, bool defaultResult = true);
    }
}