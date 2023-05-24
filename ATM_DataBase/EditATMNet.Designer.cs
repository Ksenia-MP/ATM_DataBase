
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
            this.tb_ext_gw = new System.Windows.Forms.MaskedTextBox();
            this.tb_ext_mask = new System.Windows.Forms.MaskedTextBox();
            this.tb_ext_ip = new System.Windows.Forms.MaskedTextBox();
            this.tb_bank_gw = new System.Windows.Forms.MaskedTextBox();
            this.tb_bank_mask = new System.Windows.Forms.MaskedTextBox();
            this.tb_bank_ip = new System.Windows.Forms.MaskedTextBox();
            this.ch_adsl = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tb_ext_gw);
            this.groupBox2.Controls.Add(this.tb_ext_mask);
            this.groupBox2.Controls.Add(this.tb_ext_ip);
            this.groupBox2.Controls.Add(this.tb_bank_gw);
            this.groupBox2.Controls.Add(this.tb_bank_mask);
            this.groupBox2.Controls.Add(this.tb_bank_ip);
            this.groupBox2.Controls.Add(this.ch_adsl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(14, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(333, 515);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сетевые параметры";
            // 
            // tb_ext_gw
            // 
            this.tb_ext_gw.Location = new System.Drawing.Point(7, 410);
            this.tb_ext_gw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ext_gw.Mask = "000.000.000.000";
            this.tb_ext_gw.Name = "tb_ext_gw";
            this.tb_ext_gw.Size = new System.Drawing.Size(319, 30);
            this.tb_ext_gw.TabIndex = 22;
            // 
            // tb_ext_mask
            // 
            this.tb_ext_mask.Location = new System.Drawing.Point(7, 345);
            this.tb_ext_mask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ext_mask.Mask = "000.000.000.000";
            this.tb_ext_mask.Name = "tb_ext_mask";
            this.tb_ext_mask.Size = new System.Drawing.Size(319, 30);
            this.tb_ext_mask.TabIndex = 21;
            this.tb_ext_mask.Text = "2552552550";
            // 
            // tb_ext_ip
            // 
            this.tb_ext_ip.Location = new System.Drawing.Point(7, 280);
            this.tb_ext_ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ext_ip.Mask = "000.000.000.000";
            this.tb_ext_ip.Name = "tb_ext_ip";
            this.tb_ext_ip.Size = new System.Drawing.Size(319, 30);
            this.tb_ext_ip.TabIndex = 20;
            // 
            // tb_bank_gw
            // 
            this.tb_bank_gw.Location = new System.Drawing.Point(7, 184);
            this.tb_bank_gw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bank_gw.Mask = "000.000.000.000";
            this.tb_bank_gw.Name = "tb_bank_gw";
            this.tb_bank_gw.Size = new System.Drawing.Size(319, 30);
            this.tb_bank_gw.TabIndex = 19;
            // 
            // tb_bank_mask
            // 
            this.tb_bank_mask.Location = new System.Drawing.Point(7, 119);
            this.tb_bank_mask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bank_mask.Mask = "000.000.000.000";
            this.tb_bank_mask.Name = "tb_bank_mask";
            this.tb_bank_mask.Size = new System.Drawing.Size(319, 30);
            this.tb_bank_mask.TabIndex = 18;
            this.tb_bank_mask.Text = "2552552550";
            // 
            // tb_bank_ip
            // 
            this.tb_bank_ip.Location = new System.Drawing.Point(7, 55);
            this.tb_bank_ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bank_ip.Mask = "000.000.000.000";
            this.tb_bank_ip.Name = "tb_bank_ip";
            this.tb_bank_ip.Size = new System.Drawing.Size(319, 30);
            this.tb_bank_ip.TabIndex = 17;
            // 
            // ch_adsl
            // 
            this.ch_adsl.AutoSize = true;
            this.ch_adsl.Location = new System.Drawing.Point(10, 467);
            this.ch_adsl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_adsl.Name = "ch_adsl";
            this.ch_adsl.Size = new System.Drawing.Size(72, 27);
            this.ch_adsl.TabIndex = 16;
            this.ch_adsl.Text = "ADSL";
            this.ch_adsl.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "GateWay(внеш.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mask(внеш.)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "IP(внеш.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "GateWay(внутр.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mask(внутр.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "IP(внутр.)";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(249, 547);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 45);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(143, 547);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 45);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "Изменить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // EditATMNet
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(360, 605);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(378, 652);
            this.Name = "EditATMNet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сетевые параментры";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ch_adsl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.MaskedTextBox tb_bank_gw;
        private System.Windows.Forms.MaskedTextBox tb_bank_mask;
        private System.Windows.Forms.MaskedTextBox tb_bank_ip;
        private System.Windows.Forms.MaskedTextBox tb_ext_gw;
        private System.Windows.Forms.MaskedTextBox tb_ext_mask;
        private System.Windows.Forms.MaskedTextBox tb_ext_ip;
    }
}