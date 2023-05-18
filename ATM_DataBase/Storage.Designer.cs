
namespace ATM_DataBase
{
    partial class Storage
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
            this.checkBoxUsb = new System.Windows.Forms.CheckBox();
            this.checkBoxCom = new System.Windows.Forms.CheckBox();
            this.buttonAddEq = new System.Windows.Forms.Button();
            this.lb_eq_part_no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipStorage = new System.Windows.Forms.DataGridView();
            this.buttonEditEq = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonDeleteEq = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxUsb
            // 
            this.checkBoxUsb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUsb.AutoCheck = false;
            this.checkBoxUsb.AutoSize = true;
            this.checkBoxUsb.Location = new System.Drawing.Point(694, 75);
            this.checkBoxUsb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxUsb.Name = "checkBoxUsb";
            this.checkBoxUsb.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUsb.TabIndex = 81;
            this.checkBoxUsb.UseVisualStyleBackColor = true;
            // 
            // checkBoxCom
            // 
            this.checkBoxCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCom.AutoCheck = false;
            this.checkBoxCom.AutoSize = true;
            this.checkBoxCom.Location = new System.Drawing.Point(694, 43);
            this.checkBoxCom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxCom.Name = "checkBoxCom";
            this.checkBoxCom.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCom.TabIndex = 80;
            this.checkBoxCom.UseVisualStyleBackColor = true;
            // 
            // buttonAddEq
            // 
            this.buttonAddEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEq.Location = new System.Drawing.Point(624, 107);
            this.buttonAddEq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddEq.Name = "buttonAddEq";
            this.buttonAddEq.Size = new System.Drawing.Size(115, 42);
            this.buttonAddEq.TabIndex = 77;
            this.buttonAddEq.Text = "Добавить";
            this.buttonAddEq.UseVisualStyleBackColor = true;
            this.buttonAddEq.Click += new System.EventHandler(this.buttonAddEq_Click);
            // 
            // lb_eq_part_no
            // 
            this.lb_eq_part_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_eq_part_no.AutoSize = true;
            this.lb_eq_part_no.Location = new System.Drawing.Point(690, 12);
            this.lb_eq_part_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_eq_part_no.Name = "lb_eq_part_no";
            this.lb_eq_part_no.Size = new System.Drawing.Size(83, 17);
            this.lb_eq_part_no.TabIndex = 74;
            this.lb_eq_part_no.Text = "_______________";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "USB:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Номер партии:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "COM: ";
            // 
            // dgvEquipStorage
            // 
            this.dgvEquipStorage.AllowUserToAddRows = false;
            this.dgvEquipStorage.AllowUserToDeleteRows = false;
            this.dgvEquipStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipStorage.Location = new System.Drawing.Point(10, 12);
            this.dgvEquipStorage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvEquipStorage.MultiSelect = false;
            this.dgvEquipStorage.Name = "dgvEquipStorage";
            this.dgvEquipStorage.ReadOnly = true;
            this.dgvEquipStorage.RowHeadersVisible = false;
            this.dgvEquipStorage.RowHeadersWidth = 51;
            this.dgvEquipStorage.RowTemplate.Height = 24;
            this.dgvEquipStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipStorage.Size = new System.Drawing.Size(573, 453);
            this.dgvEquipStorage.TabIndex = 70;
            // 
            // buttonEditEq
            // 
            this.buttonEditEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEq.Location = new System.Drawing.Point(624, 164);
            this.buttonEditEq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEditEq.Name = "buttonEditEq";
            this.buttonEditEq.Size = new System.Drawing.Size(115, 42);
            this.buttonEditEq.TabIndex = 76;
            this.buttonEditEq.Text = "Изменить";
            this.buttonEditEq.UseVisualStyleBackColor = true;
            this.buttonEditEq.Click += new System.EventHandler(this.buttonEditEq_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(624, 164);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(115, 42);
            this.buttonConfirm.TabIndex = 78;
            this.buttonConfirm.Text = "Выбрать";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonDeleteEq
            // 
            this.buttonDeleteEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEq.Location = new System.Drawing.Point(624, 221);
            this.buttonDeleteEq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDeleteEq.Name = "buttonDeleteEq";
            this.buttonDeleteEq.Size = new System.Drawing.Size(115, 42);
            this.buttonDeleteEq.TabIndex = 75;
            this.buttonDeleteEq.Text = "Удалить";
            this.buttonDeleteEq.UseVisualStyleBackColor = true;
            this.buttonDeleteEq.Click += new System.EventHandler(this.buttonDeleteEq_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(624, 221);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 42);
            this.buttonCancel.TabIndex = 79;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 477);
            this.Controls.Add(this.checkBoxUsb);
            this.Controls.Add(this.checkBoxCom);
            this.Controls.Add(this.buttonAddEq);
            this.Controls.Add(this.lb_eq_part_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEquipStorage);
            this.Controls.Add(this.buttonEditEq);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonDeleteEq);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUsb;
        private System.Windows.Forms.CheckBox checkBoxCom;
        private System.Windows.Forms.Button buttonAddEq;
        private System.Windows.Forms.Label lb_eq_part_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipStorage;
        private System.Windows.Forms.Button buttonEditEq;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonDeleteEq;
        private System.Windows.Forms.Button buttonCancel;
    }
}