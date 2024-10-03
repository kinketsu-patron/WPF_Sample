using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFs
{
    public class NotifyChanged : INotifyPropertyChanged
    {
        #region イベントハンドラ
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 変更通知
        protected void RaisePropertyChanged( [CallerMemberName] string p_Name = "" )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( p_Name ) );
        }
        #endregion
    }
}
