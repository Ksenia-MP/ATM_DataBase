
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
            this.tb_coment.Location = new System.Drawing.Point(11, 12);
            this.tb_coment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_coment.MaxLength = 200;
            this.tb_coment.Multiline = true;
            this.tb_coment.Name = "tb_coment";
            this.tb_coment.Size = new System.Drawing.Size(414, 188);
            this.tb_coment.TabIndex = 0;
            this.tb_coment.TextChanged += new System.EventHandler(this.EnableOK);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(245, 227);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(337, 227);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tb_date
            // 
            this.tb_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_date.Location = new System.Drawing.Point(11, 237);
            this.tb_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_date.Mask = "00/00/0000";
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(118, 25);
            this.tb_date.TabIndex = 23;
            this.tb_date.ValidatingType = typeof(System.DateTime);
            this.tb_date.TextChanged += new System.EventHandler(this.EnableOK);
            // 
            // dtp_journal_date
            // 
            this.dtp_journal_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp_journal_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_journal_date.Location = new System.Drawing.Point(132, 237);
            this.dtp_journal_date.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_journal_date.Name = "dtp_journal_date";
            this.dtp_journal_date.Size = new System.Drawing.Size(16, 25);
            this.dtp_journal_date.TabIndex = 22;
            this.dtp_journal_date.ValueChanged += new System.EventHandler(this.dtp_journal_date_ValueChanged);
            // 
            // Journal
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 281);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.dtp_journal_date);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tb_coment);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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