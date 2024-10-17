using Prism.Commands;
using Prism.Mvvm;

namespace WPFs
{
    public class MainWindowViewModel : BindableBase
    {
        private ABCounter m_ABCounter;

        public DelegateCommand Abutton_Command { get; }
        public DelegateCommand Bbutton_Command { get; }

        public uint Acount
        {
            get { return m_ABCounter.Acount; }
            set { m_ABCounter.Acount = value; }
        }

        public uint Bcount
        {
            get { return m_ABCounter.Bcount; }
            set { m_ABCounter.Bcount = value; }
        }

        public bool Abutton_Is_Enabled
        {
            get { return m_ABCounter.Abutton_Is_Enabled; }
            set { m_ABCounter.Abutton_Is_Enabled = value; }
        }

        public bool Bbutton_Is_Enabled
        {
            get { return m_ABCounter.Bbutton_Is_Enabled; }
            set { m_ABCounter.Bbutton_Is_Enabled = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel( )
        {
            m_ABCounter = new ABCounter( );
            m_ABCounter.PropertyChanged += ( sender, e ) => RaisePropertyChanged( e.PropertyName );
            Abutton_Command = new DelegateCommand( Abutton_Click );
            Bbutton_Command = new DelegateCommand( Bbutton_Click );
        }

        private void Abutton_Click( )
        {
            m_ABCounter.A_Add( );
        }

        private void Bbutton_Click( )
        {
            m_ABCounter.B_Add( );
        }
    }
}
