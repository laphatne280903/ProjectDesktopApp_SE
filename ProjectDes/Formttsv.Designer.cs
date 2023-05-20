namespace ProjectDes
{
    partial class Formttsv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_bodyttsv = new System.Windows.Forms.Panel();
            this.btn_capnhattt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_bodyttsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel_bodyttsv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel_bodyttsv
            // 
            this.panel_bodyttsv.BackColor = System.Drawing.Color.White;
            this.panel_bodyttsv.Controls.Add(this.btn_capnhattt);
            this.panel_bodyttsv.Location = new System.Drawing.Point(15, 48);
            this.panel_bodyttsv.Name = "panel_bodyttsv";
            this.panel_bodyttsv.Size = new System.Drawing.Size(736, 487);
            this.panel_bodyttsv.TabIndex = 1;
            // 
            // btn_capnhattt
            // 
            this.btn_capnhattt.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_capnhattt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhattt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_capnhattt.Location = new System.Drawing.Point(306, 433);
            this.btn_capnhattt.Name = "btn_capnhattt";
            this.btn_capnhattt.Size = new System.Drawing.Size(141, 29);
            this.btn_capnhattt.TabIndex = 0;
            this.btn_capnhattt.Text = "Cập nhật thông tin";
            this.btn_capnhattt.UseVisualStyleBackColor = false;
            this.btn_capnhattt.Click += new System.EventHandler(this.btn_capnhattt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // Formttsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.panel1);
            this.Name = "Formttsv";
            this.Text = "Formttsv";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_bodyttsv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bodyttsv;
        private System.Windows.Forms.Button btn_capnhattt;
    }
}