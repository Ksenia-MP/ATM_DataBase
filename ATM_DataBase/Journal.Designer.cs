
namespace ATM_DataBase
{
    partial class Journal
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
            this.tb_coment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tb_date = new System.Windows.Forms.MaskedTextBox();
            this.dtp_journal_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_coment
            // 
            this.tb_coment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_coment.Location = new System.Drawing.Point(12, 12);
            this.tb_coment.MaxLength = 200;
            this.tb_coment.Multiline = true;
            this.tb_coment.Name = "tb_coment";
            this.tb_coment.Size = new System.Drawing.Size(475, 177);
            this.tb_coment.TabIndex = 0;
            this.tb_coment.TextChanged += new System.EventHandler(this.EnableOK);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(305, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(399, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tb_date
            // 
            this.tb_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_date.Location = new System.Drawing.Point(12, 222);
            this.tb_date.Mask = "00/00/0000";
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(135, 22);
            this.tb_date.TabIndex = 23;
            this.tb_date.ValidatingType = typeof(System.DateTime);
            this.tb_date.TextChanged += new System.EventHandler(this.EnableOK);
            // 
            // dtp_journal_date
            // 
            this.dtp_journal_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp_journal_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_journal_date.Location = new System.Drawing.Point(150, 222);
            this.dtp_journal_date.Name = "dtp_journal_date";
            this.dtp_journal_date.Size = new System.Drawing.Size(18, 22);
            this.dtp_journal_date.TabIndex = 22;
            this.dtp_journal_date.ValueChanged += new System.EventHandler(this.dtp_journal_date_ValueChanged);
            // 
            // Journal
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 265);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.dtp_journal_date);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tb_coment);
            this.Name = "Journal";
            this.Text = "Журнал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_coment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox tb_date;
        private System.Windows.Forms.DateTimePicker dtp_journal_date;
    }
}