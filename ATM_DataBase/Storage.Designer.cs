
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EquipPage = new System.Windows.Forms.TabPage();
            this.buttonAddEq = new System.Windows.Forms.Button();
            this.buttonEditEq = new System.Windows.Forms.Button();
            this.buttonDeleteEq = new System.Windows.Forms.Button();
            this.lb_atm_bank_no = new System.Windows.Forms.Label();
            this.lb_eq_part_no = new System.Windows.Forms.Label();
            this.lb_eq_sn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipStorage = new System.Windows.Forms.DataGridView();
            this.AlarmPage = new System.Windows.Forms.TabPage();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.EquipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.EquipPage);
            this.tabControl1.Controls.Add(this.AlarmPage);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // EquipPage
            // 
            this.EquipPage.Controls.Add(this.buttonAddEq);
            this.EquipPage.Controls.Add(this.buttonEditEq);
            this.EquipPage.Controls.Add(this.buttonDeleteEq);
            this.EquipPage.Controls.Add(this.lb_atm_bank_no);
            this.EquipPage.Controls.Add(this.lb_eq_part_no);
            this.EquipPage.Controls.Add(this.lb_eq_sn);
            this.EquipPage.Controls.Add(this.label3);
            this.EquipPage.Controls.Add(this.label2);
            this.EquipPage.Controls.Add(this.label1);
            this.EquipPage.Controls.Add(this.dgvEquipStorage);
            this.EquipPage.Controls.Add(this.buttonConfirm);
            this.EquipPage.Controls.Add(this.buttonCancel);
            this.EquipPage.Location = new System.Drawing.Point(4, 22);
            this.EquipPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EquipPage.Name = "EquipPage";
            this.EquipPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EquipPage.Size = new System.Drawing.Size(740, 479);
            this.EquipPage.TabIndex = 0;
            this.EquipPage.Text = "Оборудование";
            this.EquipPage.UseVisualStyleBackColor = true;
            // 
            // buttonAddEq
            // 
            this.buttonAddEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEq.Location = new System.Drawing.Point(431, 443);
            this.buttonAddEq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddEq.Name = "buttonAddEq";
            this.buttonAddEq.Size = new System.Drawing.Size(99, 32);
            this.buttonAddEq.TabIndex = 65;
            this.buttonAddEq.Text = "Добавить";
            this.buttonAddEq.UseVisualStyleBackColor = true;
            this.buttonAddEq.Click += new System.EventHandler(this.buttonAddEq_Click);
            // 
            // buttonEditEq
            // 
            this.buttonEditEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEq.Location = new System.Drawing.Point(534, 443);
            this.buttonEditEq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditEq.Name = "buttonEditEq";
            this.buttonEditEq.Size = new System.Drawing.Size(99, 32);
            this.buttonEditEq.TabIndex = 64;
            this.buttonEditEq.Text = "Изменить";
            this.buttonEditEq.UseVisualStyleBackColor = true;
            this.buttonEditEq.Click += new System.EventHandler(this.buttonEditEq_Click);
            // 
            // buttonDeleteEq
            // 
            this.buttonDeleteEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEq.Location = new System.Drawing.Point(637, 443);
            this.buttonDeleteEq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteEq.Name = "buttonDeleteEq";
            this.buttonDeleteEq.Size = new System.Drawing.Size(99, 32);
            this.buttonDeleteEq.TabIndex = 63;
            this.buttonDeleteEq.Text = "Удалить";
            this.buttonDeleteEq.UseVisualStyleBackColor = true;
            this.buttonDeleteEq.Click += new System.EventHandler(this.buttonDeleteEq_Click);
            // 
            // lb_atm_bank_no
            // 
            this.lb_atm_bank_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_atm_bank_no.AutoSize = true;
            this.lb_atm_bank_no.Location = new System.Drawing.Point(550, 89);
            this.lb_atm_bank_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_atm_bank_no.Name = "lb_atm_bank_no";
            this.lb_atm_bank_no.Size = new System.Drawing.Size(97, 13);
            this.lb_atm_bank_no.TabIndex = 62;
            this.lb_atm_bank_no.Text = "_______________";
            // 
            // lb_eq_part_no
            // 
            this.lb_eq_part_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_eq_part_no.AutoSize = true;
            this.lb_eq_part_no.Location = new System.Drawing.Point(550, 66);
            this.lb_eq_part_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_eq_part_no.Name = "lb_eq_part_no";
            this.lb_eq_part_no.Size = new System.Drawing.Size(97, 13);
            this.lb_eq_part_no.TabIndex = 61;
            this.lb_eq_part_no.Text = "_______________";
            // 
            // lb_eq_sn
            // 
            this.lb_eq_sn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_eq_sn.AutoSize = true;
            this.lb_eq_sn.Location = new System.Drawing.Point(550, 42);
            this.lb_eq_sn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_eq_sn.Name = "lb_eq_sn";
            this.lb_eq_sn.Size = new System.Drawing.Size(97, 13);
            this.lb_eq_sn.TabIndex = 60;
            this.lb_eq_sn.Text = "_______________";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "№ ATM:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер партии:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Серийный номер: ";
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
            this.dgvEquipStorage.Location = new System.Drawing.Point(4, 4);
            this.dgvEquipStorage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEquipStorage.MultiSelect = false;
            this.dgvEquipStorage.Name = "dgvEquipStorage";
            this.dgvEquipStorage.ReadOnly = true;
            this.dgvEquipStorage.RowHeadersVisible = false;
            this.dgvEquipStorage.RowHeadersWidth = 51;
            this.dgvEquipStorage.RowTemplate.Height = 24;
            this.dgvEquipStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipStorage.Size = new System.Drawing.Size(419, 474);
            this.dgvEquipStorage.TabIndex = 1;
            this.dgvEquipStorage.SelectionChanged += new System.EventHandler(this.dgvEquipStorage_SelectionChanged);
            // 
            // AlarmPage
            // 
            this.AlarmPage.Location = new System.Drawing.Point(4, 22);
            this.AlarmPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlarmPage.Name = "AlarmPage";
            this.AlarmPage.Size = new System.Drawing.Size(740, 479);
            this.AlarmPage.TabIndex = 1;
            this.AlarmPage.Text = "Сигнализация";
            this.AlarmPage.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(534, 443);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(99, 32);
            this.buttonConfirm.TabIndex = 66;
            this.buttonConfirm.Text = "Выбрать";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(637, 443);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 32);
            this.buttonCancel.TabIndex = 67;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 525);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(674, 453);
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.tabControl1.ResumeLayout(false);
            this.EquipPage.ResumeLayout(false);
            this.EquipPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EquipPage;
        private System.Windows.Forms.TabPage AlarmPage;
        private System.Windows.Forms.DataGridView dgvEquipStorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_eq_part_no;
        private System.Windows.Forms.Label lb_eq_sn;
        private System.Windows.Forms.Label lb_atm_bank_no;
        private System.Windows.Forms.Button buttonAddEq;
        private System.Windows.Forms.Button buttonEditEq;
        private System.Windows.Forms.Button buttonDeleteEq;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}