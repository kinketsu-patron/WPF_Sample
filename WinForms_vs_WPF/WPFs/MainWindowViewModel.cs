using Prism.Commands;
using System.Windows.Input;

namespace WPFs
{
    public class MainWindowViewModel : NotifyChanged
    {
        private uint _Acount;
        public uint Acount
        {
            get { return _Acount; }
            set
            {
                if ( _Acount != value )
                {
                    _Acount = value;
                    RaisePropertyChanged( );
                }
            }
        }

        private uint _Bcount;
        public uint Bcount
        {
            get { return _Bcount; }
            set
            {
                if ( _Bcount != value )
                {
                    _Bcount = value;
                    RaisePropertyChanged( );
                }
            }
        }

        private bool _Abutton_Is_Enabled = true;
        public bool Abutton_Is_Enabled
        {
            get { return _Abutton_Is_Enabled; }
            set
            {
                if ( _Abutton_Is_Enabled != value )
                {
                    _Abutton_Is_Enabled = value;
                    RaisePropertyChanged( );
                }
            }
        }

        private bool _Bbutton_Is_Enabled = true;
        public bool Bbutton_Is_Enabled
        {
            get { return _Bbutton_Is_Enabled; }
            set
            {
                if ( _Bbutton_Is_Enabled != value )
                {
                    _Bbutton_Is_Enabled = value;
                    RaisePropertyChanged( );
                }
            }
        }

        public ICommand Abutton_Command { get; }
        public ICommand Bbutton_Command { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel( )
        {
            Acount = 0;
            Bcount = 0;
            Abutton_Is_Enabled = true;
            Bbutton_Is_Enabled = false;
            Abutton_Command = new DelegateCommand( ( ) => Abutton_Click( ) );
            Bbutton_Command = new DelegateCommand( ( ) => Bbutton_Click( ) );
        }

        private void Abutton_Click( )
        {
            Acount++;
            Abutton_Is_Enabled = false;
            Bbutton_Is_Enabled = true;
        }

        private void Bbutton_Click( )
        {
            Bcount++;
            Abutton_Is_Enabled = true;
            Bbutton_Is_Enabled = false;
        }
    }
}
