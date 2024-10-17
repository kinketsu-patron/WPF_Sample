using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private uint m_Acount;
        private uint m_Bcount;

        public Form1( )
        {
            InitializeComponent( );

            m_Acount = 0;
            m_Bcount = 0;

            BtnA.Enabled = true;
            BtnB.Enabled = false;
        }

        private void ButtonA_Click( object sender, EventArgs e )
        {
            m_Acount++;
            Lbl_AClick_Count.Text = m_Acount.ToString( );
            BtnA.Enabled = false;
            BtnB.Enabled = true;
        }

        private void ButtonB_Click( object sender, EventArgs e )
        {
            m_Bcount++;
            Lbl_BClick_Count.Text = m_Bcount.ToString( );
            BtnA.Enabled = true;
            BtnB.Enabled = false;
        }
    }
}
