using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgProc1
{
    public partial class FrmLogBrightness : Form
    {
        public FrmLogBrightness()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HScrlBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbLgBrightness.Text = hScrlBrightness.Value.ToString();
        }

        private void TbLgBrightness_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(tbLgBrightness.Text, out int n);
            if (isNumeric == true)
            {
                int value = int.Parse(tbLgBrightness.Text);
                if (value > 105)
                {
                    tbLgBrightness.Text = "105";
                }else if(value < 0)
                {
                    tbLgBrightness.Text = "0";
                }
            }
        }
    }
}
