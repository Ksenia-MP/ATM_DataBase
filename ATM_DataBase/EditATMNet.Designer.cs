
namespace ATM_DataBase
{
    partial class EditATMNet
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ch_adsl = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_ext_gw = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ext_mask = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ext_ip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_bank_gw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bank_mask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_bank_ip = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ch_adsl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_ext_gw);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_ext_mask);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_ext_ip);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_bank_gw);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_bank_mask);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_bank_ip);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 358);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сетевые параметры";
            // 
            // ch_adsl
            // 
            this.ch_adsl.AutoSize = true;
            this.ch_adsl.Location = new System.Drawing.Point(9, 325);
            this.ch_adsl.Name = "ch_adsl";
            this.ch_adsl.Size = new System.Drawing.Size(66, 21);
            this.ch_adsl.TabIndex = 16;
            this.ch_adsl.Text = "ADSL";
            this.ch_adsl.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "GateWay(внеш.)";
            // 
            // tb_ext_gw
            // 
            this.tb_ext_gw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ext_gw.Location = new System.Drawing.Point(6, 285);
            this.tb_ext_gw.MaxLength = 15;
            this.tb_ext_gw.Name = "tb_ext_gw";
            this.tb_ext_gw.Size = new System.Drawing.Size(284, 22);
            this.tb_ext_gw.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mask(внеш.)";
            // 
            // tb_ext_mask
            // 
            this.tb_ext_mask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ext_mask.Location = new System.Drawing.Point(6, 240);
            this.tb_ext_mask.MaxLength = 15;
            this.tb_ext_mask.Name = "tb_ext_mask";
            this.tb_ext_mask.Size = new System.Drawing.Size(284, 22);
            this.tb_ext_mask.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "IP(внеш.)";
            // 
            // tb_ext_ip
            // 
            this.tb_ext_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ext_ip.Location = new System.Drawing.Point(6, 195);
            this.tb_ext_ip.MaxLength = 15;
            this.tb_ext_ip.Name = "tb_ext_ip";
            this.tb_ext_ip.Size = new System.Drawing.Size(284, 22);
            this.tb_ext_ip.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "GateWay(внутр.)";
            // 
            // tb_bank_gw
            // 
            this.tb_bank_gw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_bank_gw.Location = new System.Drawing.Point(6, 128);
            this.tb_bank_gw.MaxLength = 15;
            this.tb_bank_gw.Name = "tb_bank_gw";
            this.tb_bank_gw.Size = new System.Drawing.Size(284, 22);
            this.tb_bank_gw.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mask(внутр.)";
            // 
            // tb_bank_mask
            // 
            this.tb_bank_mask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_bank_mask.Location = new System.Drawing.Point(6, 83);
            this.tb_bank_mask.MaxLength = 15;
            this.tb_bank_mask.Name = "tb_bank_mask";
            this.tb_bank_mask.Size = new System.Drawing.Size(284, 22);
            this.tb_bank_mask.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "IP(внутр.)";
            // 
            // tb_bank_ip
            // 
            this.tb_bank_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_bank_ip.Location = new System.Drawing.Point(6, 38);
            this.tb_bank_ip.MaxLength = 15;
            this.tb_bank_ip.Name = "tb_bank_ip";
            this.tb_bank_ip.Size = new System.Drawing.Size(284, 22);
            this.tb_bank_ip.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(220, 382);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 31);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(126, 382);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 31);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "Изменить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // EditATMNet
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(320, 425);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditATMNet";
            this.Text = "Сетевые параментры";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ch_adsl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_ext_gw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ext_mask;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ext_ip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_bank_gw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bank_mask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_bank_ip;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}