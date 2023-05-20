using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDes
{
    public partial class Form1 : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelmenu.Controls.Add(leftBorderBtn);

        }
        private void ActivateButton(object sender, Color color)
        {
            DisableButton();
            if (sender != null)
            {
                currentBtn = (Button)sender;
                currentBtn.BackColor = Color.FromArgb(255,255,228,196);
                //currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private struct RGBcolor
        {
            public static Color color1 = Color.Goldenrod;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            { 
                currentBtn.BackColor = Color.Transparent;
                //currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
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
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lb_trangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formtrangchu());
            Reset();
        }
        private void panellogo_DoubleClick(object sender, EventArgs e)
        {
            OpenChildForm(new Formtrangchu());
            Reset();
        }

        private void Reset()
        {
           DisableButton();
           leftBorderBtn.Visible = false;
        }

        private void btn_ttsv_Click(object sender, EventArgs e)
        {
            Reset();
            
            OpenChildForm(new Formttsv());
            ActivateButton(sender, RGBcolor.color1);
        }

        private void btn_kqht_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new FormKqhoctap());

            ActivateButton(sender, RGBcolor.color1);
        }

        private void btn_dsmh_Click(object sender, EventArgs e)
        {
            Reset();

            OpenChildForm(new Formnganh_chuyennganh());
            ActivateButton(sender, RGBcolor.color1);
        }

        private void btn_dsl_Click(object sender, EventArgs e)
        {
            Reset();

            ActivateButton(sender, RGBcolor.color1);
        }

        
    } 
}
