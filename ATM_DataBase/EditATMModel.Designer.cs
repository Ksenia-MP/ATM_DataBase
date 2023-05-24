
namespace ATM_DataBase
{
    partial class EditATMModel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tb_depth = new System.Windows.Forms.TextBox();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_cashin = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.tb_depth);
            this.groupBox1.Controls.Add(this.tb_width);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.tb_height);
            this.groupBox1.Controls.Add(this.tb_weight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ch_cashin);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 395);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Модель";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClear.Location = new System.Drawing.Point(339, 54);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(27, 33);
            this.buttonClear.TabIndex = 52;
            this.buttonClear.Text = "X";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tb_depth
            // 
            this.tb_depth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_depth.Location = new System.Drawing.Point(9, 317);
            this.tb_depth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_depth.MaxLength = 15;
            this.tb_depth.Name = "tb_depth";
            this.tb_depth.ReadOnly = true;
            this.tb_depth.Size = new System.Drawing.Size(358, 30);
            this.tb_depth.TabIndex = 59;
            // 
            // tb_width
            // 
            this.tb_width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_width.Location = new System.Drawing.Point(9, 254);
            this.tb_width.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_width.MaxLength = 15;
            this.tb_width.Name = "tb_width";
            this.tb_width.ReadOnly = true;
            this.tb_width.Size = new System.Drawing.Size(358, 30);
            this.tb_width.TabIndex = 58;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 288);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 23);
            this.label22.TabIndex = 57;
            this.label22.Text = "Глубина, см:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 226);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 23);
            this.label24.TabIndex = 56;
            this.label24.Text = "Ширина, см:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 163);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 23);
            this.label26.TabIndex = 55;
            this.label26.Text = "Высота, см:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 23);
            this.label28.TabIndex = 54;
            this.label28.Text = "Вес, кг:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(309, 54);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(26, 33);
            this.buttonAdd.TabIndex = 52;
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
            this.cb_name.Location = new System.Drawing.Point(9, 55);
            this.cb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(293, 31);
            this.cb_name.TabIndex = 51;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            this.cb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_name_KeyDown);
            // 
            // tb_height
            // 
            this.tb_height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_height.Location = new System.Drawing.Point(9, 192);
            this.tb_height.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_height.MaxLength = 15;
            this.tb_height.Name = "tb_height";
            this.tb_height.ReadOnly = true;
            this.tb_height.Size = new System.Drawing.Size(358, 30);
            this.tb_height.TabIndex = 50;
            // 
            // tb_weight
            // 
            this.tb_weight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_weight.Location = new System.Drawing.Point(9, 129);
            this.tb_weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_weight.MaxLength = 15;
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.ReadOnly = true;
            this.tb_weight.Size = new System.Drawing.Size(358, 30);
            this.tb_weight.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Наименование";
            // 
            // ch_cashin
            // 
            this.ch_cashin.AutoCheck = false;
            this.ch_cashin.AutoSize = true;
            this.ch_cashin.Location = new System.Drawing.Point(6, 355);
            this.ch_cashin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_cashin.Name = "ch_cashin";
            this.ch_cashin.Size = new System.Drawing.Size(84, 27);
            this.ch_cashin.TabIndex = 47;
            this.ch_cashin.Text = "CashIn";
            this.ch_cashin.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(284, 417);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 36);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(178, 417);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 36);
            this.buttonOK.TabIndex = 49;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 15;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(295, 33);
            this.textBox1.TabIndex = 60;
            // 
            // EditATMModel
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(395, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(413, 513);
            this.Name = "EditATMModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель АТМ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_depth;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ch_cashin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
    }
}