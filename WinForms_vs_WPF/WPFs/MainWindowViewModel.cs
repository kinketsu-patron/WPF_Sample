using ScottPlot_MVVM_Sample;

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

        private bool _Abutton_Is_Enabled;
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

        private bool _Bbutton_Is_Enabled;
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

        public MainWindowViewModel( )
        {
            Acount = 0;
            Bcount = 0;
            Abutton_Is_Enabled = true;
            Bbutton_Is_Enabled = false;
        }
    }
}
