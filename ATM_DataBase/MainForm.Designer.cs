﻿
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvATM = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.провайдерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_renter_company = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_renter_phone = new System.Windows.Forms.Label();
            this.lb_renter_name = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_pr_contract_date = new System.Windows.Forms.Label();
            this.lb_pr_name = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lb_pr_contract_no = new System.Windows.Forms.Label();
            this.lb_pr_line_no = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
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
            this.btnDelEquip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRetEquip = new System.Windows.Forms.Button();
            this.buttonAddEquip = new System.Windows.Forms.Button();
            this.buttonCreateEquip = new System.Windows.Forms.Button();
            this.buttonEditEquip = new System.Windows.Forms.Button();
            this.lb_eq_part_no = new System.Windows.Forms.Label();
            this.lb_eq_sn = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dgv_atm_equip = new System.Windows.Forms.DataGridView();
            this.tabJournal = new System.Windows.Forms.TabPage();
            this.btnDelJournal = new System.Windows.Forms.Button();
            this.btnAddJournal = new System.Windows.Forms.Button();
            this.btnEditJournal = new System.Windows.Forms.Button();
            this.dgv_journal = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ping = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.clear_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvATM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabNet.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabEquipment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atm_equip)).BeginInit();
            this.tabJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_journal)).BeginInit();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvATM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvATM.Location = new System.Drawing.Point(14, 77);
            this.dgvATM.MultiSelect = false;
            this.dgvATM.Name = "dgvATM";
            this.dgvATM.ReadOnly = true;
            this.dgvATM.RowHeadersVisible = false;
            this.dgvATM.RowHeadersWidth = 51;
            this.dgvATM.RowTemplate.Height = 32;
            this.dgvATM.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvATM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvATM.Size = new System.Drawing.Size(633, 539);
            this.dgvATM.TabIndex = 0;
            this.dgvATM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvATM_DataError);
            this.dgvATM.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvATM_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.storageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(140, 27);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
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
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(313, 28);
            this.ModelToolStripMenuItem.Text = "Модели банкоматов";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // EquipToolStripMenuItem
            // 
            this.EquipToolStripMenuItem.Name = "EquipToolStripMenuItem";
            this.EquipToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EquipToolStripMenuItem.Size = new System.Drawing.Size(313, 28);
            this.EquipToolStripMenuItem.Text = "Оборудование";
            this.EquipToolStripMenuItem.Click += new System.EventHandler(this.EquipToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(310, 6);
            // 
            // провайдерыToolStripMenuItem
            // 
            this.провайдерыToolStripMenuItem.Name = "провайдерыToolStripMenuItem";
            this.провайдерыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.провайдерыToolStripMenuItem.Size = new System.Drawing.Size(313, 28);
            this.провайдерыToolStripMenuItem.Text = "Провайдеры";
            this.провайдерыToolStripMenuItem.Click += new System.EventHandler(this.ProviderToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(189, 27);
            this.storageToolStripMenuItem.Text = "Склад оборудования";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabNet);
            this.tabControl1.Controls.Add(this.tabContacts);
            this.tabControl1.Controls.Add(this.tabModel);
            this.tabControl1.Controls.Add(this.tabEquipment);
            this.tabControl1.Controls.Add(this.tabJournal);
            this.tabControl1.Location = new System.Drawing.Point(652, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 571);
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
            this.tabGeneral.Location = new System.Drawing.Point(4, 32);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(511, 535);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Общие";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // ch_ups
            // 
            this.ch_ups.AutoCheck = false;
            this.ch_ups.AutoSize = true;
            this.ch_ups.Location = new System.Drawing.Point(174, 278);
            this.ch_ups.Name = "ch_ups";
            this.ch_ups.Size = new System.Drawing.Size(18, 17);
            this.ch_ups.TabIndex = 15;
            this.ch_ups.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 23);
            this.label20.TabIndex = 14;
            this.label20.Text = "UPS: ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(405, 486);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 43);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // lb_setting_date
            // 
            this.lb_setting_date.AutoSize = true;
            this.lb_setting_date.Location = new System.Drawing.Point(171, 236);
            this.lb_setting_date.Name = "lb_setting_date";
            this.lb_setting_date.Size = new System.Drawing.Size(80, 23);
            this.lb_setting_date.TabIndex = 12;
            this.lb_setting_date.Text = "__________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Дата установки: ";
            // 
            // lb_e
            // 
            this.lb_e.AutoSize = true;
            this.lb_e.Location = new System.Drawing.Point(171, 184);
            this.lb_e.Name = "lb_e";
            this.lb_e.Size = new System.Drawing.Size(52, 23);
            this.lb_e.TabIndex = 10;
            this.lb_e.Text = "______";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Долгота: ";
            // 
            // lb_n
            // 
            this.lb_n.AutoSize = true;
            this.lb_n.Location = new System.Drawing.Point(171, 161);
            this.lb_n.Name = "lb_n";
            this.lb_n.Size = new System.Drawing.Size(52, 23);
            this.lb_n.TabIndex = 8;
            this.lb_n.Text = "______";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Широта: ";
            // 
            // lb_address
            // 
            this.lb_address.Location = new System.Drawing.Point(171, 105);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(279, 49);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "____________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес: ";
            // 
            // lb_serial_no
            // 
            this.lb_serial_no.AutoSize = true;
            this.lb_serial_no.Location = new System.Drawing.Point(171, 60);
            this.lb_serial_no.Name = "lb_serial_no";
            this.lb_serial_no.Size = new System.Drawing.Size(80, 23);
            this.lb_serial_no.TabIndex = 4;
            this.lb_serial_no.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "S/N: ";
            // 
            // lb_bank_no
            // 
            this.lb_bank_no.AutoSize = true;
            this.lb_bank_no.Location = new System.Drawing.Point(171, 20);
            this.lb_bank_no.Name = "lb_bank_no";
            this.lb_bank_no.Size = new System.Drawing.Size(45, 23);
            this.lb_bank_no.TabIndex = 2;
            this.lb_bank_no.Text = "_____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
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
            this.tabNet.Location = new System.Drawing.Point(4, 32);
            this.tabNet.Name = "tabNet";
            this.tabNet.Padding = new System.Windows.Forms.Padding(3);
            this.tabNet.Size = new System.Drawing.Size(511, 535);
            this.tabNet.TabIndex = 1;
            this.tabNet.Text = "Сетевые ";
            this.tabNet.UseVisualStyleBackColor = true;
            // 
            // lb_bank_mask
            // 
            this.lb_bank_mask.AutoSize = true;
            this.lb_bank_mask.Location = new System.Drawing.Point(172, 53);
            this.lb_bank_mask.Name = "lb_bank_mask";
            this.lb_bank_mask.Size = new System.Drawing.Size(115, 23);
            this.lb_bank_mask.TabIndex = 35;
            this.lb_bank_mask.Text = "_______________";
            // 
            // lb_bank_gw
            // 
            this.lb_bank_gw.AutoSize = true;
            this.lb_bank_gw.Location = new System.Drawing.Point(172, 92);
            this.lb_bank_gw.Name = "lb_bank_gw";
            this.lb_bank_gw.Size = new System.Drawing.Size(115, 23);
            this.lb_bank_gw.TabIndex = 34;
            this.lb_bank_gw.Text = "_______________";
            // 
            // lb_ext_ip
            // 
            this.lb_ext_ip.AutoSize = true;
            this.lb_ext_ip.Location = new System.Drawing.Point(172, 161);
            this.lb_ext_ip.Name = "lb_ext_ip";
            this.lb_ext_ip.Size = new System.Drawing.Size(115, 23);
            this.lb_ext_ip.TabIndex = 33;
            this.lb_ext_ip.Text = "_______________";
            // 
            // lb_ext_mask
            // 
            this.lb_ext_mask.AutoSize = true;
            this.lb_ext_mask.Location = new System.Drawing.Point(172, 200);
            this.lb_ext_mask.Name = "lb_ext_mask";
            this.lb_ext_mask.Size = new System.Drawing.Size(115, 23);
            this.lb_ext_mask.TabIndex = 32;
            this.lb_ext_mask.Text = "_______________";
            // 
            // lb_ext_gw
            // 
            this.lb_ext_gw.AutoSize = true;
            this.lb_ext_gw.Location = new System.Drawing.Point(172, 237);
            this.lb_ext_gw.Name = "lb_ext_gw";
            this.lb_ext_gw.Size = new System.Drawing.Size(115, 23);
            this.lb_ext_gw.TabIndex = 31;
            this.lb_ext_gw.Text = "_______________";
            // 
            // lb_bank_ip
            // 
            this.lb_bank_ip.AutoSize = true;
            this.lb_bank_ip.Location = new System.Drawing.Point(172, 14);
            this.lb_bank_ip.Name = "lb_bank_ip";
            this.lb_bank_ip.Size = new System.Drawing.Size(115, 23);
            this.lb_bank_ip.TabIndex = 30;
            this.lb_bank_ip.Text = "_______________";
            // 
            // ch_adsl
            // 
            this.ch_adsl.AutoCheck = false;
            this.ch_adsl.AutoSize = true;
            this.ch_adsl.Location = new System.Drawing.Point(18, 298);
            this.ch_adsl.Name = "ch_adsl";
            this.ch_adsl.Size = new System.Drawing.Size(72, 27);
            this.ch_adsl.TabIndex = 29;
            this.ch_adsl.Text = "ADSL";
            this.ch_adsl.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "GateWay(внеш.):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Mask(внеш.):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "IP(внеш.):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "GateWay(внутр.):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Mask(внутр.):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 23);
            this.label17.TabIndex = 18;
            this.label17.Text = "IP(внутр.):";
            // 
            // buttonEdit_net
            // 
            this.buttonEdit_net.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_net.Location = new System.Drawing.Point(405, 486);
            this.buttonEdit_net.Name = "buttonEdit_net";
            this.buttonEdit_net.Size = new System.Drawing.Size(100, 43);
            this.buttonEdit_net.TabIndex = 14;
            this.buttonEdit_net.Text = "Изменить";
            this.buttonEdit_net.UseVisualStyleBackColor = true;
            this.buttonEdit_net.Click += new System.EventHandler(this.buttonEdit_net_Click);
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.groupBox3);
            this.tabContacts.Controls.Add(this.groupBox2);
            this.tabContacts.Controls.Add(this.buttonEdit_provider);
            this.tabContacts.Location = new System.Drawing.Point(4, 32);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(511, 535);
            this.tabContacts.TabIndex = 3;
            this.tabContacts.Text = "Контакты";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lb_renter_company);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lb_renter_phone);
            this.groupBox3.Controls.Add(this.lb_renter_name);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Location = new System.Drawing.Point(7, 247);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(496, 217);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Арендодатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Организация:";
            // 
            // lb_renter_company
            // 
            this.lb_renter_company.AutoSize = true;
            this.lb_renter_company.Location = new System.Drawing.Point(162, 39);
            this.lb_renter_company.Name = "lb_renter_company";
            this.lb_renter_company.Size = new System.Drawing.Size(185, 23);
            this.lb_renter_company.TabIndex = 32;
            this.lb_renter_company.Text = "_________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Контактное лицо:";
            // 
            // lb_renter_phone
            // 
            this.lb_renter_phone.AutoSize = true;
            this.lb_renter_phone.Location = new System.Drawing.Point(162, 119);
            this.lb_renter_phone.Name = "lb_renter_phone";
            this.lb_renter_phone.Size = new System.Drawing.Size(115, 23);
            this.lb_renter_phone.TabIndex = 36;
            this.lb_renter_phone.Text = "_______________";
            // 
            // lb_renter_name
            // 
            this.lb_renter_name.AutoSize = true;
            this.lb_renter_name.Location = new System.Drawing.Point(162, 79);
            this.lb_renter_name.Name = "lb_renter_name";
            this.lb_renter_name.Size = new System.Drawing.Size(185, 23);
            this.lb_renter_name.TabIndex = 34;
            this.lb_renter_name.Text = "_________________________";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 119);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 23);
            this.label30.TabIndex = 35;
            this.label30.Text = "Номер телефона:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lb_pr_contract_date);
            this.groupBox2.Controls.Add(this.lb_pr_name);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lb_pr_contract_no);
            this.groupBox2.Controls.Add(this.lb_pr_line_no);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(496, 217);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Провайдер";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 23);
            this.label21.TabIndex = 31;
            this.label21.Text = "Наименование:";
            // 
            // lb_pr_contract_date
            // 
            this.lb_pr_contract_date.AutoSize = true;
            this.lb_pr_contract_date.Location = new System.Drawing.Point(162, 158);
            this.lb_pr_contract_date.Name = "lb_pr_contract_date";
            this.lb_pr_contract_date.Size = new System.Drawing.Size(80, 23);
            this.lb_pr_contract_date.TabIndex = 38;
            this.lb_pr_contract_date.Text = "__________";
            // 
            // lb_pr_name
            // 
            this.lb_pr_name.AutoSize = true;
            this.lb_pr_name.Location = new System.Drawing.Point(162, 39);
            this.lb_pr_name.Name = "lb_pr_name";
            this.lb_pr_name.Size = new System.Drawing.Size(150, 23);
            this.lb_pr_name.TabIndex = 32;
            this.lb_pr_name.Text = "____________________";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 158);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 23);
            this.label27.TabIndex = 37;
            this.label27.Text = "Дата договора: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 23);
            this.label23.TabIndex = 33;
            this.label23.Text = "№ линии:";
            // 
            // lb_pr_contract_no
            // 
            this.lb_pr_contract_no.AutoSize = true;
            this.lb_pr_contract_no.Location = new System.Drawing.Point(162, 119);
            this.lb_pr_contract_no.Name = "lb_pr_contract_no";
            this.lb_pr_contract_no.Size = new System.Drawing.Size(150, 23);
            this.lb_pr_contract_no.TabIndex = 36;
            this.lb_pr_contract_no.Text = "____________________";
            // 
            // lb_pr_line_no
            // 
            this.lb_pr_line_no.AutoSize = true;
            this.lb_pr_line_no.Location = new System.Drawing.Point(162, 79);
            this.lb_pr_line_no.Name = "lb_pr_line_no";
            this.lb_pr_line_no.Size = new System.Drawing.Size(150, 23);
            this.lb_pr_line_no.TabIndex = 34;
            this.lb_pr_line_no.Text = "____________________";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 23);
            this.label25.TabIndex = 35;
            this.label25.Text = "№ договора:";
            // 
            // buttonEdit_provider
            // 
            this.buttonEdit_provider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_provider.Location = new System.Drawing.Point(405, 486);
            this.buttonEdit_provider.Name = "buttonEdit_provider";
            this.buttonEdit_provider.Size = new System.Drawing.Size(100, 43);
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
            this.tabModel.Location = new System.Drawing.Point(4, 32);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(511, 535);
            this.tabModel.TabIndex = 4;
            this.tabModel.Text = "О Модели";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Location = new System.Drawing.Point(172, 56);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(115, 23);
            this.lb_weight.TabIndex = 48;
            this.lb_weight.Text = "_______________";
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(172, 101);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(115, 23);
            this.lb_height.TabIndex = 47;
            this.lb_height.Text = "_______________";
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(172, 144);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(115, 23);
            this.lb_width.TabIndex = 46;
            this.lb_width.Text = "_______________";
            // 
            // lb_depth
            // 
            this.lb_depth.AutoSize = true;
            this.lb_depth.Location = new System.Drawing.Point(172, 187);
            this.lb_depth.Name = "lb_depth";
            this.lb_depth.Size = new System.Drawing.Size(115, 23);
            this.lb_depth.TabIndex = 45;
            this.lb_depth.Text = "_______________";
            // 
            // lb_model_name
            // 
            this.lb_model_name.AutoSize = true;
            this.lb_model_name.Location = new System.Drawing.Point(172, 14);
            this.lb_model_name.Name = "lb_model_name";
            this.lb_model_name.Size = new System.Drawing.Size(115, 23);
            this.lb_model_name.TabIndex = 43;
            this.lb_model_name.Text = "_______________";
            // 
            // ch_cashin
            // 
            this.ch_cashin.AutoCheck = false;
            this.ch_cashin.AutoSize = true;
            this.ch_cashin.Location = new System.Drawing.Point(18, 244);
            this.ch_cashin.Name = "ch_cashin";
            this.ch_cashin.Size = new System.Drawing.Size(84, 27);
            this.ch_cashin.TabIndex = 42;
            this.ch_cashin.Text = "CashIn";
            this.ch_cashin.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 187);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 23);
            this.label22.TabIndex = 40;
            this.label22.Text = "Глубина, см:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 144);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 23);
            this.label24.TabIndex = 39;
            this.label24.Text = "Ширина, см:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 101);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 23);
            this.label26.TabIndex = 38;
            this.label26.Text = "Высота, см:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 23);
            this.label28.TabIndex = 37;
            this.label28.Text = "Вес, кг:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(15, 14);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(133, 23);
            this.label29.TabIndex = 36;
            this.label29.Text = "Наименование:";
            // 
            // buttonEdit_model
            // 
            this.buttonEdit_model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit_model.Location = new System.Drawing.Point(405, 486);
            this.buttonEdit_model.Name = "buttonEdit_model";
            this.buttonEdit_model.Size = new System.Drawing.Size(100, 43);
            this.buttonEdit_model.TabIndex = 16;
            this.buttonEdit_model.Text = "Изменить";
            this.buttonEdit_model.UseVisualStyleBackColor = true;
            this.buttonEdit_model.Click += new System.EventHandler(this.buttonEdit_model_Click);
            // 
            // tabEquipment
            // 
            this.tabEquipment.Controls.Add(this.btnDelEquip);
            this.tabEquipment.Controls.Add(this.groupBox1);
            this.tabEquipment.Controls.Add(this.buttonCreateEquip);
            this.tabEquipment.Controls.Add(this.buttonEditEquip);
            this.tabEquipment.Controls.Add(this.lb_eq_part_no);
            this.tabEquipment.Controls.Add(this.lb_eq_sn);
            this.tabEquipment.Controls.Add(this.label31);
            this.tabEquipment.Controls.Add(this.label32);
            this.tabEquipment.Controls.Add(this.dgv_atm_equip);
            this.tabEquipment.Location = new System.Drawing.Point(4, 32);
            this.tabEquipment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Size = new System.Drawing.Size(511, 535);
            this.tabEquipment.TabIndex = 5;
            this.tabEquipment.Text = "Оборудование";
            this.tabEquipment.UseVisualStyleBackColor = true;
            // 
            // btnDelEquip
            // 
            this.btnDelEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelEquip.Location = new System.Drawing.Point(398, 401);
            this.btnDelEquip.Name = "btnDelEquip";
            this.btnDelEquip.Size = new System.Drawing.Size(100, 43);
            this.btnDelEquip.TabIndex = 62;
            this.btnDelEquip.Text = "Удалить";
            this.btnDelEquip.UseVisualStyleBackColor = true;
            this.btnDelEquip.Click += new System.EventHandler(this.btnDelEquip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRetEquip);
            this.groupBox1.Controls.Add(this.buttonAddEquip);
            this.groupBox1.Location = new System.Drawing.Point(187, 451);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(317, 84);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции со складом";
            // 
            // buttonRetEquip
            // 
            this.buttonRetEquip.Location = new System.Drawing.Point(164, 26);
            this.buttonRetEquip.Name = "buttonRetEquip";
            this.buttonRetEquip.Size = new System.Drawing.Size(147, 43);
            this.buttonRetEquip.TabIndex = 20;
            this.buttonRetEquip.Text = "Вернуть на склад";
            this.buttonRetEquip.UseVisualStyleBackColor = true;
            this.buttonRetEquip.Click += new System.EventHandler(this.buttonRetEquip_Click);
            // 
            // buttonAddEquip
            // 
            this.buttonAddEquip.Location = new System.Drawing.Point(6, 26);
            this.buttonAddEquip.Name = "buttonAddEquip";
            this.buttonAddEquip.Size = new System.Drawing.Size(147, 43);
            this.buttonAddEquip.TabIndex = 19;
            this.buttonAddEquip.Text = "Добавить со склада";
            this.buttonAddEquip.UseVisualStyleBackColor = true;
            this.buttonAddEquip.Click += new System.EventHandler(this.buttonAddEquip_Click);
            // 
            // buttonCreateEquip
            // 
            this.buttonCreateEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateEquip.Location = new System.Drawing.Point(186, 401);
            this.buttonCreateEquip.Name = "buttonCreateEquip";
            this.buttonCreateEquip.Size = new System.Drawing.Size(100, 43);
            this.buttonCreateEquip.TabIndex = 60;
            this.buttonCreateEquip.Text = "Добавить";
            this.buttonCreateEquip.UseVisualStyleBackColor = true;
            this.buttonCreateEquip.Click += new System.EventHandler(this.buttonCreateEquip_Click);
            // 
            // buttonEditEquip
            // 
            this.buttonEditEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEquip.Location = new System.Drawing.Point(292, 401);
            this.buttonEditEquip.Name = "buttonEditEquip";
            this.buttonEditEquip.Size = new System.Drawing.Size(100, 43);
            this.buttonEditEquip.TabIndex = 17;
            this.buttonEditEquip.Text = "Изменить";
            this.buttonEditEquip.UseVisualStyleBackColor = true;
            this.buttonEditEquip.Click += new System.EventHandler(this.buttonEditEquip_Click);
            // 
            // lb_eq_part_no
            // 
            this.lb_eq_part_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_eq_part_no.AutoSize = true;
            this.lb_eq_part_no.Location = new System.Drawing.Point(341, 364);
            this.lb_eq_part_no.Name = "lb_eq_part_no";
            this.lb_eq_part_no.Size = new System.Drawing.Size(115, 23);
            this.lb_eq_part_no.TabIndex = 59;
            this.lb_eq_part_no.Text = "_______________";
            // 
            // lb_eq_sn
            // 
            this.lb_eq_sn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_eq_sn.AutoSize = true;
            this.lb_eq_sn.Location = new System.Drawing.Point(45, 364);
            this.lb_eq_sn.Name = "lb_eq_sn";
            this.lb_eq_sn.Size = new System.Drawing.Size(115, 23);
            this.lb_eq_sn.TabIndex = 55;
            this.lb_eq_sn.Text = "_______________";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(224, 364);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(128, 23);
            this.label31.TabIndex = 50;
            this.label31.Text = "Номер партии:";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 364);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 23);
            this.label32.TabIndex = 49;
            this.label32.Text = "s/n:";
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
            this.dgv_atm_equip.Location = new System.Drawing.Point(3, 3);
            this.dgv_atm_equip.MultiSelect = false;
            this.dgv_atm_equip.Name = "dgv_atm_equip";
            this.dgv_atm_equip.ReadOnly = true;
            this.dgv_atm_equip.RowHeadersVisible = false;
            this.dgv_atm_equip.RowHeadersWidth = 51;
            this.dgv_atm_equip.RowTemplate.Height = 24;
            this.dgv_atm_equip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atm_equip.Size = new System.Drawing.Size(501, 358);
            this.dgv_atm_equip.TabIndex = 18;
            this.dgv_atm_equip.SelectionChanged += new System.EventHandler(this.dgv_atm_equip_SelectionChanged);
            // 
            // tabJournal
            // 
            this.tabJournal.Controls.Add(this.btnDelJournal);
            this.tabJournal.Controls.Add(this.btnAddJournal);
            this.tabJournal.Controls.Add(this.btnEditJournal);
            this.tabJournal.Controls.Add(this.dgv_journal);
            this.tabJournal.Location = new System.Drawing.Point(4, 32);
            this.tabJournal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabJournal.Name = "tabJournal";
            this.tabJournal.Size = new System.Drawing.Size(511, 535);
            this.tabJournal.TabIndex = 6;
            this.tabJournal.Text = "Журнал";
            this.tabJournal.UseVisualStyleBackColor = true;
            // 
            // btnDelJournal
            // 
            this.btnDelJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelJournal.Location = new System.Drawing.Point(406, 493);
            this.btnDelJournal.Name = "btnDelJournal";
            this.btnDelJournal.Size = new System.Drawing.Size(100, 43);
            this.btnDelJournal.TabIndex = 65;
            this.btnDelJournal.Text = "Удалить";
            this.btnDelJournal.UseVisualStyleBackColor = true;
            this.btnDelJournal.Click += new System.EventHandler(this.buttonDelJournal_Click);
            // 
            // btnAddJournal
            // 
            this.btnAddJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJournal.Location = new System.Drawing.Point(194, 493);
            this.btnAddJournal.Name = "btnAddJournal";
            this.btnAddJournal.Size = new System.Drawing.Size(100, 43);
            this.btnAddJournal.TabIndex = 64;
            this.btnAddJournal.Text = "Добавить";
            this.btnAddJournal.UseVisualStyleBackColor = true;
            this.btnAddJournal.Click += new System.EventHandler(this.buttonAddJournal_Click);
            // 
            // btnEditJournal
            // 
            this.btnEditJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditJournal.Location = new System.Drawing.Point(300, 493);
            this.btnEditJournal.Name = "btnEditJournal";
            this.btnEditJournal.Size = new System.Drawing.Size(100, 43);
            this.btnEditJournal.TabIndex = 63;
            this.btnEditJournal.Text = "Изменить";
            this.btnEditJournal.UseVisualStyleBackColor = true;
            this.btnEditJournal.Click += new System.EventHandler(this.buttonEditJournal_Click);
            // 
            // dgv_journal
            // 
            this.dgv_journal.AllowUserToAddRows = false;
            this.dgv_journal.AllowUserToDeleteRows = false;
            this.dgv_journal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_journal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_journal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_journal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_journal.Location = new System.Drawing.Point(3, 3);
            this.dgv_journal.MultiSelect = false;
            this.dgv_journal.Name = "dgv_journal";
            this.dgv_journal.ReadOnly = true;
            this.dgv_journal.RowHeadersVisible = false;
            this.dgv_journal.RowHeadersWidth = 51;
            this.dgv_journal.RowTemplate.Height = 24;
            this.dgv_journal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_journal.Size = new System.Drawing.Size(503, 484);
            this.dgv_journal.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ping
            // 
            this.btn_ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ping.Location = new System.Drawing.Point(1104, 0);
            this.btn_ping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(81, 32);
            this.btn_ping.TabIndex = 3;
            this.btn_ping.Text = "on ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filter.Location = new System.Drawing.Point(14, 45);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(597, 30);
            this.tb_filter.TabIndex = 5;
            this.tb_filter.TextChanged += new System.EventHandler(this.tb_filter_TextChanged);
            // 
            // clear_filter
            // 
            this.clear_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_filter.Location = new System.Drawing.Point(617, 45);
            this.clear_filter.Name = "clear_filter";
            this.clear_filter.Size = new System.Drawing.Size(29, 26);
            this.clear_filter.TabIndex = 6;
            this.clear_filter.Text = "X";
            this.clear_filter.UseVisualStyleBackColor = true;
            this.clear_filter.Click += new System.EventHandler(this.clear_filter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 632);
            this.Controls.Add(this.clear_filter);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.btn_ping);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvATM);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ATM: Учет и Сопровождение";
            ((System.ComponentModel.ISupportInitialize)(this.dgvATM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabNet.ResumeLayout(false);
            this.tabNet.PerformLayout();
            this.tabContacts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.tabModel.PerformLayout();
            this.tabEquipment.ResumeLayout(false);
            this.tabEquipment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atm_equip)).EndInit();
            this.tabJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_journal)).EndInit();
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
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.Button buttonEdit_provider;
        private System.Windows.Forms.Label lb_pr_line_no;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lb_pr_name;
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
        private System.Windows.Forms.Button buttonRetEquip;
        private System.Windows.Forms.Button buttonAddEquip;
        private System.Windows.Forms.DataGridView dgv_atm_equip;
        private System.Windows.Forms.Button buttonEditEquip;
        private System.Windows.Forms.Label lb_eq_part_no;
        private System.Windows.Forms.Label lb_eq_sn;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateEquip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnDelEquip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabJournal;
        private System.Windows.Forms.Button btnDelJournal;
        private System.Windows.Forms.Button btnAddJournal;
        private System.Windows.Forms.Button btnEditJournal;
        private System.Windows.Forms.DataGridView dgv_journal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_renter_company;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_renter_phone;
        private System.Windows.Forms.Label lb_renter_name;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button clear_filter;
    }
}

