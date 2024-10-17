using Prism.Mvvm;

namespace WPFs
{
    public class ABCounter : BindableBase
    {
        private uint m_Acount = 0;
        public uint Acount
        {
            get { return m_Acount; }
            set
            {
                SetProperty( ref m_Acount, value );
            }
        }

        private uint m_Bcount = 0;
        public uint Bcount
        {
            get { return m_Bcount; }
            set
            {
                SetProperty( ref m_Bcount, value );
            }
        }

        private bool m_Abutton_Is_Enabled = true;
        public bool Abutton_Is_Enabled
        {
            get { return m_Abutton_Is_Enabled; }
            set
            {
                SetProperty( ref m_Abutton_Is_Enabled, value );
            }
        }

        private bool m_Bbutton_Is_Enabled = false;
        public bool Bbutton_Is_Enabled
        {
            get { return m_Bbutton_Is_Enabled; }
            set
            {
                SetProperty( ref m_Bbutton_Is_Enabled, value );
            }
        }

        public void A_Add( )
        {
            Acount++;
            Abutton_Is_Enabled = false;
            Bbutton_Is_Enabled = true;
        }

        public void B_Add( )
        {
            Bcount++;
            Abutton_Is_Enabled = true;
            Bbutton_Is_Enabled = false;
        }
    }
}
