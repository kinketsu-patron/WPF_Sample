using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private uint _Acount;
        private uint _Bcount;

        public Form1( )
        {
            InitializeComponent( );

            _Acount = 0;
            _Bcount = 0;

            BtnA.Enabled = true;
            BtnB.Enabled = false;
        }

        private void ButtonA_Click( object sender, EventArgs e )
        {
            _Acount++;
            Lbl_AClick_Count.Text = _Acount.ToString( );
            BtnA.Enabled = false;
            BtnB.Enabled = true;
        }

        private void ButtonB_Click( object sender, EventArgs e )
        {
            _Bcount++;
            Lbl_BClick_Count.Text = _Bcount.ToString( );
            BtnA.Enabled = true;
            BtnB.Enabled = false;
        }
    }
}
