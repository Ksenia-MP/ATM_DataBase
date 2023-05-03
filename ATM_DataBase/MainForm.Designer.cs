
namespace ATM_DataBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvATM = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.провайдерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.ch_ups = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.lb_setting_date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_e = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_n = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_serial_no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_bank_no = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNet = new System.Windows.Forms.TabPage();
            this.lb_bank_mask = new System.Windows.Forms.Label();
            this.lb_bank_gw = new System.Windows.Forms.Label();
            this.lb_ext_ip = new System.Windows.Forms.Label();
            this.lb_ext_mask = new System.Windows.Forms.Label();
            this.lb_ext_gw = new System.Windows.Forms.Label();
            this.lb_bank_ip = new System.Windows.Forms.Label();
            this.ch_adsl = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonEdit_net = new System.Windows.Forms.Button();
            this.tabProvider = new System.Windows.Forms.TabPage();
            this.lb_pr_contract_date = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lb_pr_contract_no = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lb_pr_line_no = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lb_pr_name = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonEdit_provider = new System.Windows.Forms.Button();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.lb_weight = new System.Windows.Forms.Label();
            this.lb_height = new System.Windows.Forms.Label();
            this.lb_width = new System.Windows.Forms.Label();
            this.lb_depth = new System.Windows.Forms.Label();
            this.lb_model_name = new System.Windows.Forms.Label();
            this.ch_cashin = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonEdit_model = new System.Windows.Forms.Button();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.buttonAddToStorage = new System.Windows.Forms.Button();
            this.lb_eq_part_no = new System.Windows.Forms.Label();
            this.lb_eq_sn = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonDelEquip = new System.Windows.Forms.Button();
            this.buttonAddEquip = new System.Windows.Forms.Button();
            this.dgv_atm_equip = new System.Windows.Forms.DataGridView();
            this.buttonEditEquip = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvATM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabNet.SuspendLayout();
            this.tabProvider.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atm_equip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvATM
            // 
            this.dgvATM.AllowUserToAddRows = false;
            this.dgvATM.AllowUserToDeleteRows = false;
            this.dgvATM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvATM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvATM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvATM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvATM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvATM.Location = new System.Drawing.Point(12, 31);
            this.dgvATM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvATM.MultiSelect = false;
            this.dgvATM.Name = "dgvATM";
            this.dgvATM.ReadOnly = true;
            this.dgvATM.RowHeadersVisible = false;
            this.dgvATM.RowHeadersWidth = 51;
            this.dgvATM.RowTemplate.Height = 24;
            this.dgvATM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvATM.Size = new System.Drawing.Size(536, 503);
            this.dgvATM.TabIndex = 0;
            this.dgvATM.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvATM_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.storageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1026, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModelToolStripMenuItem,
            this.EquipToolStripMenuItem,
            this.toolStripSeparator1,
            this.провайдерыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // EquipToolStripMenuItem
            // 
            this.EquipToolStripMenuItem.Name = "EquipToolStripMenuItem";
            this.EquipToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EquipToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.EquipToolStripMenuItem.Text = "Оборудование";
            this.EquipToolStripMenuItem.Click += new System.EventHandler(this.EquipToolStripMenuItem_Click);
            // 
            // провайдерыToolStripMenuItem
            // 
            this.провайдерыToolStripMenuItem.Name = "провайдерыToolStripMenuItem";
            this.провайдерыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.провайдерыToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.провайдерыToolStripMenuItem.Text = "Провайдеры";
            this.провайдерыToolStripMenuItem.Click += new System.EventHandler(this.ProviderToolStripMenuItem_Click);
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.ModelToolStripMenuItem.Text = "Модели банкоматов";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.storageToolStripMenuItem.Text = "Склад";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabNet);
            this.tabControl1.Controls.Add(this.tabProvider);
            this.tabControl1.Controls.Add(this.tabModel);
            this.tabControl1.Controls.Add(this.tabEquipment);
            this.tabControl1.Location = new System.Drawing.Point(553, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 503);
            this.tabControl1.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.ch_ups);
            this.tabGeneral.Controls.Add(this.label20);
            this.tabGeneral.Controls.Add(this.buttonEdit);
            this.tabGeneral.Controls.Add(this.lb_setting_date);
            this.tabGeneral.Controls.Add(this.label11);
            this.tabGeneral.Controls.Add(this.lb_e);
            this.tabGeneral.Controls.Add(this.label9);
            this.tabGeneral.Controls.Add(this.lb_n);
            this.tabGeneral.Controls.Add(this.label7);
            this.tabGeneral.Controls.Add(this.lb_address);
            this.tabGeneral.Controls.Add(this.label5);
            this.tabGeneral.Controls.Add(this.lb_serial_no);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.lb_bank_no);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGeneral.Size = new System.Drawing.Size(453, 474);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Общие";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // ch_ups
            // 
            this.ch_ups.AutoCheck = false;
            this.ch_ups.AutoSize = true;
            this.ch_ups.Location = new System.Drawing.Point(155, 194);
            this.ch_ups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_ups.Name = "ch_ups";
            this.ch_ups.Size = new System.Drawing.Size(18, 17);
            this.ch_ups.TabIndex = 15;
            this.ch_ups.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "UPS: ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(358, 438);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(89, 30);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // lb_setting_date
            // 
            this.lb_setting_date.AutoSize = true;
            this.lb_setting_date.Location = new System.Drawing.Point(152, 165);
            this.lb_setting_date.Name = "lb_setting_date";
            this.lb_setting_date.Size = new System.Drawing.Size(88, 17);
            this.lb_setting_date.TabIndex = 12;
            this.lb_setting_date.Text = "__________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Дата установки: ";
            // 
            // lb_e
            // 
            this.lb_e.AutoSize = true;
            this.lb_e.Location = new System.Drawing.Point(152, 129);
            this.lb_e.Name = "lb_e";
            this.lb_e.Size = new System.Drawing.Size(56, 17);
            this.lb_e.TabIndex = 10;
            this.lb_e.Text = "______";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Долгота: ";
            // 
            // lb_n
            // 
            this.lb_n.AutoSize = true;
            this.lb_n.Location = new System.Drawing.Point(152, 112);
            this.lb_n.Name = "lb_n";
            this.lb_n.Size = new System.Drawing.Size(56, 17);
            this.lb_n.TabIndex = 8;
            this.lb_n.Text = "______";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Широта: ";
            // 
            // lb_address
            // 
            this.lb_address.Location = new System.Drawing.Point(152, 73);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(248, 34);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "____________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес: ";
            // 
            // lb_serial_no
            // 
            this.lb_serial_no.AutoSize = true;
            this.lb_serial_no.Location = new System.Drawing.Point(152, 42);
            this.lb_serial_no.Name = "lb_serial_no";
            this.lb_serial_no.Size = new System.Drawing.Size(88, 17);
            this.lb_serial_no.TabIndex = 4;
            this.lb_serial_no.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "S/N: ";
            // 
            // lb_bank_no
            // 
            this.lb_bank_no.AutoSize = true;
            this.lb_bank_no.Location = new System.Drawing.Point(152, 14);
            this.lb_bank_no.Name = "lb_bank_no";
            this.lb_bank_no.Size = new System.Drawing.Size(48, 17);
            this.lb_bank_no.TabIndex = 2;
            this.lb_bank_no.Text = "_____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ ATM: ";
            // 
            // tabNet
            // 
            this.tabNet.Controls.Add(this.lb_bank_mask);
            this.tabNet.Controls.Add(this.lb_bank_gw);
            this.tabNet.Controls.Add(this.lb_ext_ip);
            this.tabNet.Controls.Add(this.lb_ext_mask);
            this.tabNet.Controls.Add(this.lb_ext_gw);
            this.tabNet.Controls.Add(this.lb_bank_ip);
            this.tabNet.Controls.Add(this.ch_adsl);
            this.tabNet.Controls.Add(this.label12);
            this.tabNet.Controls.Add(this.label13);
            this.tabNet.Controls.Add(this.label14);
            this.tabNet.Controls.Add(this.label15);
            this.tabNet.Controls.Add(this.label16);
            this.tabNet.Controls.Add(this.label17);
            this.tabNet.Controls.Add(this.buttonEdit_net);
            this.tabNet.Location = new System.Drawing.Point(4, 25);
            this.tabNet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNet.Name = "tabNet";
            this.tabNet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNet.Size = new System.Drawing.Size(453, 474);
            this.tabNet.TabIndex = 1;
            this.tabNet.Text = "Сетевые ";
            this.tabNet.UseVisualStyleBackColor = true;
            // 
            // lb_bank_mask
            // 
            this.lb_bank_mask.AutoSize = true;
            this.lb_bank_mask.Location = new System.Drawing.Point(153, 37);
            this.lb_bank_mask.Name = "lb_bank_mask";
            this.lb_bank_mask.Size = new System.Drawing.Size(128, 17);
            this.lb_bank_mask.TabIndex = 35;
            this.lb_bank_mask.Text = "_______________";
            // 
            // lb_bank_gw
            // 
            this.lb_bank_gw.AutoSize = true;
            this.lb_bank_gw.Location = new System.Drawing.Point(153, 64);
            this.lb_bank_gw.Name = "lb_bank_gw";
            this.lb_bank_gw.Size = new System.Drawing.Size(128, 17);
            this.lb_bank_gw.TabIndex = 34;
            this.lb_bank_gw.Text = "_______________";
            // 
            // lb_ext_ip
            // 
            this.lb_ext_ip.AutoSize = true;
            this.lb_ext_ip.Location = new System.Drawing.Point(153, 112);
            this.lb_ext_ip.Name = "lb_ext_ip";
            this.lb_ext_ip.Size = new System.Drawing.Size(128, 17);
            this.lb_ext_ip.TabIndex = 33;
            this.lb_ext_ip.Text = "_______________";
            // 
            // lb_ext_mask
            // 
            this.lb_ext_mask.AutoSize = true;
            this.lb_ext_mask.Location = new System.Drawing.Point(153, 139);
            this.lb_ext_mask.Name = "lb_ext_mask";
            this.lb_ext_mask.Size = new System.Drawing.Size(128, 17);
            this.lb_ext_mask.TabIndex = 32;
            this.lb_ext_mask.Text = "_______________";
            // 
            // lb_ext_gw
            // 
            this.lb_ext_gw.AutoSize = true;
            this.lb_ext_gw.Location = new System.Drawing.Point(153, 165);
            this.lb_ext_gw.Name = "lb_ext_gw";
            this.lb_ext_gw.Size = new System.Drawing.Size(128, 17);
            this.lb_ext_gw.TabIndex = 31;
            this.lb_ext_gw.Text = "_______________";
            // 
            // lb_bank_ip
            // 
            this.lb_bank_ip.AutoSize = true;
            this.lb_bank_ip.Location = new System.Drawing.Point(153, 10);
            this.lb_bank_ip.Name = "lb_bank_ip";
            this.lb_bank_ip.Size = new System.Drawing.Size(128, 17);
            this.lb_bank_ip.TabIndex = 30;
            this.lb_bank_ip.Text = "_______________";
            // 
            // ch_adsl
            // 
            this.ch_adsl.AutoCheck = false;
            this.ch_adsl.AutoSize = true;
            this.ch_adsl.Location = new System.Drawing.Point(16, 207);
            this.ch_adsl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_adsl.Name = "ch_adsl";
            this.ch_adsl.Size = new System.Drawing.Size(66, 21);
            this.ch_adsl.TabIndex = 29;
            this.ch_adsl.Text = "ADSL";
            this.ch_adsl.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "GateWay(внеш.):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Mask(внеш.):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "IP(внеш.):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "GateWay(внутр.):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Mask(внутр.):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "IP(внутр.):";
            // 
            // buttonEdit_net
            // 
            this.buttonEdit_net.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_net.Location = new System.Drawing.Point(358, 438);
            this.buttonEdit_net.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit_net.Name = "buttonEdit_net";
            this.buttonEdit_net.Size = new System.Drawing.Size(89, 30);
            this.buttonEdit_net.TabIndex = 14;
            this.buttonEdit_net.Text = "Изменить";
            this.buttonEdit_net.UseVisualStyleBackColor = true;
            this.buttonEdit_net.Click += new System.EventHandler(this.buttonEdit_net_Click);
            // 
            // tabProvider
            // 
            this.tabProvider.Controls.Add(this.lb_pr_contract_date);
            this.tabProvider.Controls.Add(this.label27);
            this.tabProvider.Controls.Add(this.lb_pr_contract_no);
            this.tabProvider.Controls.Add(this.label25);
            this.tabProvider.Controls.Add(this.lb_pr_line_no);
            this.tabProvider.Controls.Add(this.label23);
            this.tabProvider.Controls.Add(this.lb_pr_name);
            this.tabProvider.Controls.Add(this.label21);
            this.tabProvider.Controls.Add(this.buttonEdit_provider);
            this.tabProvider.Location = new System.Drawing.Point(4, 25);
            this.tabProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProvider.Name = "tabProvider";
            this.tabProvider.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProvider.Size = new System.Drawing.Size(453, 474);
            this.tabProvider.TabIndex = 3;
            this.tabProvider.Text = "Провайдер";
            this.tabProvider.UseVisualStyleBackColor = true;
            // 
            // lb_pr_contract_date
            // 
            this.lb_pr_contract_date.AutoSize = true;
            this.lb_pr_contract_date.Location = new System.Drawing.Point(157, 97);
            this.lb_pr_contract_date.Name = "lb_pr_contract_date";
            this.lb_pr_contract_date.Size = new System.Drawing.Size(88, 17);
            this.lb_pr_contract_date.TabIndex = 38;
            this.lb_pr_contract_date.Text = "__________";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 97);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 17);
            this.label27.TabIndex = 37;
            this.label27.Text = "Дата договора: ";
            // 
            // lb_pr_contract_no
            // 
            this.lb_pr_contract_no.AutoSize = true;
            this.lb_pr_contract_no.Location = new System.Drawing.Point(157, 70);
            this.lb_pr_contract_no.Name = "lb_pr_contract_no";
            this.lb_pr_contract_no.Size = new System.Drawing.Size(168, 17);
            this.lb_pr_contract_no.TabIndex = 36;
            this.lb_pr_contract_no.Text = "____________________";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 70);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 17);
            this.label25.TabIndex = 35;
            this.label25.Text = "№ договора:";
            // 
            // lb_pr_line_no
            // 
            this.lb_pr_line_no.AutoSize = true;
            this.lb_pr_line_no.Location = new System.Drawing.Point(157, 42);
            this.lb_pr_line_no.Name = "lb_pr_line_no";
            this.lb_pr_line_no.Size = new System.Drawing.Size(168, 17);
            this.lb_pr_line_no.TabIndex = 34;
            this.lb_pr_line_no.Text = "____________________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 17);
            this.label23.TabIndex = 33;
            this.label23.Text = "№ линии:";
            // 
            // lb_pr_name
            // 
            this.lb_pr_name.AutoSize = true;
            this.lb_pr_name.Location = new System.Drawing.Point(157, 14);
            this.lb_pr_name.Name = "lb_pr_name";
            this.lb_pr_name.Size = new System.Drawing.Size(168, 17);
            this.lb_pr_name.TabIndex = 32;
            this.lb_pr_name.Text = "____________________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Провайдер:";
            // 
            // buttonEdit_provider
            // 
            this.buttonEdit_provider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_provider.Location = new System.Drawing.Point(358, 438);
            this.buttonEdit_provider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit_provider.Name = "buttonEdit_provider";
            this.buttonEdit_provider.Size = new System.Drawing.Size(89, 30);
            this.buttonEdit_provider.TabIndex = 15;
            this.buttonEdit_provider.Text = "Изменить";
            this.buttonEdit_provider.UseVisualStyleBackColor = true;
            this.buttonEdit_provider.Click += new System.EventHandler(this.buttonEdit_provider_Click);
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.lb_weight);
            this.tabModel.Controls.Add(this.lb_height);
            this.tabModel.Controls.Add(this.lb_width);
            this.tabModel.Controls.Add(this.lb_depth);
            this.tabModel.Controls.Add(this.lb_model_name);
            this.tabModel.Controls.Add(this.ch_cashin);
            this.tabModel.Controls.Add(this.label22);
            this.tabModel.Controls.Add(this.label24);
            this.tabModel.Controls.Add(this.label26);
            this.tabModel.Controls.Add(this.label28);
            this.tabModel.Controls.Add(this.label29);
            this.tabModel.Controls.Add(this.buttonEdit_model);
            this.tabModel.Location = new System.Drawing.Point(4, 25);
            this.tabModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(453, 474);
            this.tabModel.TabIndex = 4;
            this.tabModel.Text = "О модели";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Location = new System.Drawing.Point(153, 39);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(128, 17);
            this.lb_weight.TabIndex = 48;
            this.lb_weight.Text = "_______________";
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(153, 70);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(128, 17);
            this.lb_height.TabIndex = 47;
            this.lb_height.Text = "_______________";
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(153, 100);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(128, 17);
            this.lb_width.TabIndex = 46;
            this.lb_width.Text = "_______________";
            // 
            // lb_depth
            // 
            this.lb_depth.AutoSize = true;
            this.lb_depth.Location = new System.Drawing.Point(153, 130);
            this.lb_depth.Name = "lb_depth";
            this.lb_depth.Size = new System.Drawing.Size(128, 17);
            this.lb_depth.TabIndex = 45;
            this.lb_depth.Text = "_______________";
            // 
            // lb_model_name
            // 
            this.lb_model_name.AutoSize = true;
            this.lb_model_name.Location = new System.Drawing.Point(153, 10);
            this.lb_model_name.Name = "lb_model_name";
            this.lb_model_name.Size = new System.Drawing.Size(128, 17);
            this.lb_model_name.TabIndex = 43;
            this.lb_model_name.Text = "_______________";
            // 
            // ch_cashin
            // 
            this.ch_cashin.AutoCheck = false;
            this.ch_cashin.AutoSize = true;
            this.ch_cashin.Location = new System.Drawing.Point(16, 170);
            this.ch_cashin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_cashin.Name = "ch_cashin";
            this.ch_cashin.Size = new System.Drawing.Size(73, 21);
            this.ch_cashin.TabIndex = 42;
            this.ch_cashin.Text = "CashIn";
            this.ch_cashin.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 17);
            this.label22.TabIndex = 40;
            this.label22.Text = "Глубина, см:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 17);
            this.label24.TabIndex = 39;
            this.label24.Text = "Ширина, см:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 17);
            this.label26.TabIndex = 38;
            this.label26.Text = "Высота, см:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 17);
            this.label28.TabIndex = 37;
            this.label28.Text = "Вес, кг:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 17);
            this.label29.TabIndex = 36;
            this.label29.Text = "Наименование:";
            // 
            // buttonEdit_model
            // 
            this.buttonEdit_model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_model.Location = new System.Drawing.Point(358, 439);
            this.buttonEdit_model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit_model.Name = "buttonEdit_model";
            this.buttonEdit_model.Size = new System.Drawing.Size(89, 30);
            this.buttonEdit_model.TabIndex = 16;
            this.buttonEdit_model.Text = "Изменить";
            this.buttonEdit_model.UseVisualStyleBackColor = true;
            this.buttonEdit_model.Click += new System.EventHandler(this.buttonEdit_model_Click);
            // 
            // tabEquipment
            // 
            this.tabEquipment.Controls.Add(this.buttonAddToStorage);
            this.tabEquipment.Controls.Add(this.lb_eq_part_no);
            this.tabEquipment.Controls.Add(this.lb_eq_sn);
            this.tabEquipment.Controls.Add(this.label31);
            this.tabEquipment.Controls.Add(this.label32);
            this.tabEquipment.Controls.Add(this.buttonDelEquip);
            this.tabEquipment.Controls.Add(this.buttonAddEquip);
            this.tabEquipment.Controls.Add(this.dgv_atm_equip);
            this.tabEquipment.Controls.Add(this.buttonEditEquip);
            this.tabEquipment.Location = new System.Drawing.Point(4, 25);
            this.tabEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Size = new System.Drawing.Size(453, 474);
            this.tabEquipment.TabIndex = 5;
            this.tabEquipment.Text = "Оборудование";
            this.tabEquipment.UseVisualStyleBackColor = true;
            // 
            // buttonAddToStorage
            // 
            this.buttonAddToStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToStorage.Location = new System.Drawing.Point(111, 428);
            this.buttonAddToStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToStorage.Name = "buttonAddToStorage";
            this.buttonAddToStorage.Size = new System.Drawing.Size(109, 44);
            this.buttonAddToStorage.TabIndex = 60;
            this.buttonAddToStorage.Text = "Добавить";
            this.buttonAddToStorage.UseVisualStyleBackColor = true;
            this.buttonAddToStorage.Click += new System.EventHandler(this.buttonAddToStorage_Click);
            // 
            // lb_eq_part_no
            // 
            this.lb_eq_part_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_eq_part_no.AutoSize = true;
            this.lb_eq_part_no.Location = new System.Drawing.Point(143, 385);
            this.lb_eq_part_no.Name = "lb_eq_part_no";
            this.lb_eq_part_no.Size = new System.Drawing.Size(128, 17);
            this.lb_eq_part_no.TabIndex = 59;
            this.lb_eq_part_no.Text = "_______________";
            // 
            // lb_eq_sn
            // 
            this.lb_eq_sn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_eq_sn.AutoSize = true;
            this.lb_eq_sn.Location = new System.Drawing.Point(143, 356);
            this.lb_eq_sn.Name = "lb_eq_sn";
            this.lb_eq_sn.Size = new System.Drawing.Size(128, 17);
            this.lb_eq_sn.TabIndex = 55;
            this.lb_eq_sn.Text = "_______________";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 385);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 17);
            this.label31.TabIndex = 50;
            this.label31.Text = "Номер партии:";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 356);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(124, 17);
            this.label32.TabIndex = 49;
            this.label32.Text = "Серийный номер:";
            // 
            // buttonDelEquip
            // 
            this.buttonDelEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelEquip.Location = new System.Drawing.Point(341, 428);
            this.buttonDelEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelEquip.Name = "buttonDelEquip";
            this.buttonDelEquip.Size = new System.Drawing.Size(109, 44);
            this.buttonDelEquip.TabIndex = 20;
            this.buttonDelEquip.Text = "Удалить";
            this.buttonDelEquip.UseVisualStyleBackColor = true;
            this.buttonDelEquip.Click += new System.EventHandler(this.buttonDelEquip_Click);
            // 
            // buttonAddEquip
            // 
            this.buttonAddEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEquip.Location = new System.Drawing.Point(-4, 428);
            this.buttonAddEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEquip.Name = "buttonAddEquip";
            this.buttonAddEquip.Size = new System.Drawing.Size(109, 44);
            this.buttonAddEquip.TabIndex = 19;
            this.buttonAddEquip.Text = "Добавить со склада";
            this.buttonAddEquip.UseVisualStyleBackColor = true;
            this.buttonAddEquip.Click += new System.EventHandler(this.buttonAddEquip_Click);
            // 
            // dgv_atm_equip
            // 
            this.dgv_atm_equip.AllowUserToAddRows = false;
            this.dgv_atm_equip.AllowUserToDeleteRows = false;
            this.dgv_atm_equip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_atm_equip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_atm_equip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atm_equip.Location = new System.Drawing.Point(3, 2);
            this.dgv_atm_equip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_atm_equip.MultiSelect = false;
            this.dgv_atm_equip.Name = "dgv_atm_equip";
            this.dgv_atm_equip.ReadOnly = true;
            this.dgv_atm_equip.RowHeadersVisible = false;
            this.dgv_atm_equip.RowHeadersWidth = 51;
            this.dgv_atm_equip.RowTemplate.Height = 24;
            this.dgv_atm_equip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atm_equip.Size = new System.Drawing.Size(445, 321);
            this.dgv_atm_equip.TabIndex = 18;
            this.dgv_atm_equip.SelectionChanged += new System.EventHandler(this.dgv_atm_equip_SelectionChanged);
            // 
            // buttonEditEquip
            // 
            this.buttonEditEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEquip.Location = new System.Drawing.Point(226, 428);
            this.buttonEditEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditEquip.Name = "buttonEditEquip";
            this.buttonEditEquip.Size = new System.Drawing.Size(109, 44);
            this.buttonEditEquip.TabIndex = 17;
            this.buttonEditEquip.Text = "Изменить";
            this.buttonEditEquip.UseVisualStyleBackColor = true;
            this.buttonEditEquip.Click += new System.EventHandler(this.buttonEditEquip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvATM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(893, 548);
            this.Name = "MainForm";
            this.Text = "Я люблю свою работу";
            ((System.ComponentModel.ISupportInitialize)(this.dgvATM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabNet.ResumeLayout(false);
            this.tabNet.PerformLayout();
            this.tabProvider.ResumeLayout(false);
            this.tabProvider.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.tabModel.PerformLayout();
            this.tabEquipment.ResumeLayout(false);
            this.tabEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atm_equip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvATM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EquipToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabNet;
        private System.Windows.Forms.Label lb_bank_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_serial_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_e;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_setting_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonEdit_net;
        private System.Windows.Forms.CheckBox ch_adsl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_bank_mask;
        private System.Windows.Forms.Label lb_bank_gw;
        private System.Windows.Forms.Label lb_ext_ip;
        private System.Windows.Forms.Label lb_ext_mask;
        private System.Windows.Forms.Label lb_ext_gw;
        private System.Windows.Forms.Label lb_bank_ip;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox ch_ups;
        private System.Windows.Forms.TabPage tabProvider;
        private System.Windows.Forms.Button buttonEdit_provider;
        private System.Windows.Forms.Label lb_pr_line_no;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lb_pr_name;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_pr_contract_date;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lb_pr_contract_no;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolStripMenuItem провайдерыToolStripMenuItem;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.Label lb_depth;
        private System.Windows.Forms.Label lb_model_name;
        private System.Windows.Forms.CheckBox ch_cashin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button buttonEdit_model;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEquipment;
        private System.Windows.Forms.Button buttonDelEquip;
        private System.Windows.Forms.Button buttonAddEquip;
        private System.Windows.Forms.DataGridView dgv_atm_equip;
        private System.Windows.Forms.Button buttonEditEquip;
        private System.Windows.Forms.Label lb_eq_part_no;
        private System.Windows.Forms.Label lb_eq_sn;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddToStorage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

