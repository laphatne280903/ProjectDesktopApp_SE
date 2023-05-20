using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDes
{
    public partial class Formttsv : Form
    {
        public Formttsv()
        {
            InitializeComponent();
        }
        private Form cformChild;
        private void OpenChildForm(Form childForm)
        {
            if (cformChild != null)
            {
                cformChild.Close();
            }
            cformChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_bodyttsv.Controls.Add(childForm);
            panel_bodyttsv.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_capnhattt_Click(object sender, EventArgs e)
        {
            FormCapnhatTTSV fcn=new FormCapnhatTTSV();
            
            //Mở ra form mới
            //fcn.StartPosition= FormStartPosition.CenterParent;
            //fcn.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            //fcn.Show();
            OpenChildForm(new FormCapnhatTTSV());
        }
    }
}
