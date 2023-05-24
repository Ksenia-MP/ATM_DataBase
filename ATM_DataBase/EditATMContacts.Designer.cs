
namespace ATM_DataBase
{
    partial class EditATMContacts
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_date = new System.Windows.Forms.MaskedTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.dtp_contract_date = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_contract_no = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_pr_line_no = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_phone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_renter_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tb_date);
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.cb_name);
            this.groupBox3.Controls.Add(this.dtp_contract_date);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tb_contract_no);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tb_pr_line_no);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(14, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(325, 278);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Провайдер";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(6, 231);
            this.tb_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_date.Mask = "00/00/0000";
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(151, 30);
            this.tb_date.TabIndex = 6;
            this.tb_date.ValidatingType = typeof(System.DateTime);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClear.Location = new System.Drawing.Point(292, 30);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(27, 34);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "X";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(261, 30);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(27, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // cb_name
            // 
            this.cb_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(6, 31);
            this.cb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(249, 31);
            this.cb_name.TabIndex = 1;
            this.cb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_name_KeyDown);
            // 
            // dtp_contract_date
            // 
            this.dtp_contract_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_contract_date.Location = new System.Drawing.Point(161, 231);
            this.dtp_contract_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_contract_date.Name = "dtp_contract_date";
            this.dtp_contract_date.Size = new System.Drawing.Size(20, 30);
            this.dtp_contract_date.TabIndex = 7;
            this.dtp_contract_date.ValueChanged += new System.EventHandler(this.dtp_contract_date_ValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "Дата договора";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 23);
            this.label17.TabIndex = 7;
            this.label17.Text = "№ договора";
            // 
            // tb_contract_no
            // 
            this.tb_contract_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_contract_no.Location = new System.Drawing.Point(5, 163);
            this.tb_contract_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_contract_no.MaxLength = 15;
            this.tb_contract_no.Name = "tb_contract_no";
            this.tb_contract_no.Size = new System.Drawing.Size(309, 30);
            this.tb_contract_no.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 23);
            this.label18.TabIndex = 5;
            this.label18.Text = "№ линии";
            // 
            // tb_pr_line_no
            // 
            this.tb_pr_line_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pr_line_no.Location = new System.Drawing.Point(5, 99);
            this.tb_pr_line_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pr_line_no.MaxLength = 15;
            this.tb_pr_line_no.Name = "tb_pr_line_no";
            this.tb_pr_line_no.Size = new System.Drawing.Size(309, 30);
            this.tb_pr_line_no.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(5, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 15;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(251, 33);
            this.textBox1.TabIndex = 22;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(135, 556);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 45);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "Изменить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(241, 556);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 45);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_renter_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_company);
            this.groupBox1.Location = new System.Drawing.Point(14, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 243);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Арендодатель";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(5, 198);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_phone.Mask = "8(999)000-00-00";
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(151, 30);
            this.tb_phone.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Контактное лицо";
            // 
            // tb_renter_name
            // 
            this.tb_renter_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_renter_name.Location = new System.Drawing.Point(5, 127);
            this.tb_renter_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_renter_name.MaxLength = 60;
            this.tb_renter_name.Name = "tb_renter_name";
            this.tb_renter_name.Size = new System.Drawing.Size(309, 30);
            this.tb_renter_name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Наименование организации";
            // 
            // tb_company
            // 
            this.tb_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_company.Location = new System.Drawing.Point(5, 60);
            this.tb_company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_company.MaxLength = 50;
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(309, 30);
            this.tb_company.TabIndex = 8;
            // 
            // EditATMContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(352, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(370, 661);
            this.Name = "EditATMContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Контакты";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_contract_date;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_contract_no;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_pr_line_no;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MaskedTextBox tb_date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tb_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_renter_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_company;
    }
}