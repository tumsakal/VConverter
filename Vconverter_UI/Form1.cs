using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Vconverter_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormConvert_Click(object sender, EventArgs e)
        {
            if (this.pnlContainer.Controls.Find("Form_Convert", false).Length == 0)
            {
                this.pnlContainer.Controls.Clear();
                Form_Convert frm = new Form_Convert() { Dock = DockStyle.Fill, TopLevel = false };
                this.pnlContainer.Controls.Add(frm);
                frm.Show();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (this.pnlContainer.Controls.Find("Form_download", false).Length == 0)
            {
                this.pnlContainer.Controls.Clear();
                Form_download frm = new Form_download() { Dock = DockStyle.Fill, TopLevel = false };
                this.pnlContainer.Controls.Add(frm);
                frm.Show();
            }
        }
    }
}
