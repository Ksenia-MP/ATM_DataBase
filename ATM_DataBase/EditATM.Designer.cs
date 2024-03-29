﻿
namespace ATM_DataBase
{
    partial class EditATM
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_e = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_serial_no = new System.Windows.Forms.MaskedTextBox();
            this.tb_bank_no = new System.Windows.Forms.MaskedTextBox();
            this.tb_setting_date = new System.Windows.Forms.MaskedTextBox();
            this.dtp_setting_date = new System.Windows.Forms.DateTimePicker();
            this.ch_ups = new System.Windows.Forms.CheckBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(122, 529);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "№ ATM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "S/N";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(235, 529);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 40);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес";
            // 
            // tb_address
            // 
            this.tb_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_address.Location = new System.Drawing.Point(10, 197);
            this.tb_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_address.MaxLength = 60;
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(307, 95);
            this.tb_address.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Широта";
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(10, 334);
            this.tb_n.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(113, 30);
            this.tb_n.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Долгота";
            // 
            // tb_e
            // 
            this.tb_e.Location = new System.Drawing.Point(142, 334);
            this.tb_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_e.Name = "tb_e";
            this.tb_e.Size = new System.Drawing.Size(113, 30);
            this.tb_e.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата установки";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_serial_no);
            this.groupBox1.Controls.Add(this.tb_bank_no);
            this.groupBox1.Controls.Add(this.tb_setting_date);
            this.groupBox1.Controls.Add(this.dtp_setting_date);
            this.groupBox1.Controls.Add(this.ch_ups);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_e);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_n);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(324, 497);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные параметры";
            // 
            // tb_serial_no
            // 
            this.tb_serial_no.Location = new System.Drawing.Point(10, 125);
            this.tb_serial_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_serial_no.Mask = "0000000000";
            this.tb_serial_no.Name = "tb_serial_no";
            this.tb_serial_no.Size = new System.Drawing.Size(307, 30);
            this.tb_serial_no.TabIndex = 2;
            // 
            // tb_bank_no
            // 
            this.tb_bank_no.Location = new System.Drawing.Point(10, 55);
            this.tb_bank_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bank_no.Mask = "00000";
            this.tb_bank_no.Name = "tb_bank_no";
            this.tb_bank_no.Size = new System.Drawing.Size(307, 30);
            this.tb_bank_no.TabIndex = 1;
            this.tb_bank_no.ValidatingType = typeof(int);
            // 
            // tb_setting_date
            // 
            this.tb_setting_date.Location = new System.Drawing.Point(10, 407);
            this.tb_setting_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_setting_date.Mask = "00/00/0000";
            this.tb_setting_date.Name = "tb_setting_date";
            this.tb_setting_date.Size = new System.Drawing.Size(151, 30);
            this.tb_setting_date.TabIndex = 6;
            this.tb_setting_date.ValidatingType = typeof(System.DateTime);
            // 
            // dtp_setting_date
            // 
            this.dtp_setting_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_setting_date.Location = new System.Drawing.Point(165, 407);
            this.dtp_setting_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_setting_date.Name = "dtp_setting_date";
            this.dtp_setting_date.Size = new System.Drawing.Size(20, 30);
            this.dtp_setting_date.TabIndex = 7;
            this.dtp_setting_date.ValueChanged += new System.EventHandler(this.dtp_setting_date_ValueChanged);
            // 
            // ch_ups
            // 
            this.ch_ups.AutoSize = true;
            this.ch_ups.Location = new System.Drawing.Point(10, 457);
            this.ch_ups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_ups.Name = "ch_ups";
            this.ch_ups.Size = new System.Drawing.Size(63, 27);
            this.ch_ups.TabIndex = 8;
            this.ch_ups.Text = "UPS";
            this.ch_ups.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(122, 529);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 40);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // EditATM
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(351, 582);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(369, 629);
            this.Name = "EditATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditATM";
            this.Shown += new System.EventHandler(this.EditATM_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_e;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ch_ups;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MaskedTextBox tb_setting_date;
        private System.Windows.Forms.DateTimePicker dtp_setting_date;
        private System.Windows.Forms.MaskedTextBox tb_bank_no;
        private System.Windows.Forms.MaskedTextBox tb_serial_no;
    }
}