using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            ButtonA.Enabled = true;
            ButtonB.Enabled = false;
        }

        private void ButtonA_Click( object sender, EventArgs e )
        {
            _Acount++;
            ButtonA_Count.Text = _Acount.ToString( );
            ButtonA.Enabled = false;
            ButtonB.Enabled = true;
        }

        private void ButtonB_Click( object sender, EventArgs e )
        {
            _Bcount++;
            ButtonB_Count.Text = _Bcount.ToString( );
            ButtonA.Enabled = true;
            ButtonB.Enabled = false;
        }
    }
}
