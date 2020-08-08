namespace Contestcalls
    {
    partial class Form1
        {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ListView1Calls = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.btnAktualisierenStop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3Locator = new System.Windows.Forms.TabPage();
            this.ListView1Locator = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.NumericUpDown1SchriftgrößeListView = new System.Windows.Forms.NumericUpDown();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.RadioButton3AnzeigeDetailliste = new System.Windows.Forms.RadioButton();
            this.RadioButton3AnzeigeListe = new System.Windows.Forms.RadioButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.RadioButton1SortierenLocator = new System.Windows.Forms.RadioButton();
            this.RadioButton1SortierenCalls = new System.Windows.Forms.RadioButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ComboBox1Tabellenblatt = new System.Windows.Forms.ComboBox();
            this.TbMDBpfad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOFD = new System.Windows.Forms.Button();
            this.lblPfad = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1Sekunden = new System.Windows.Forms.NumericUpDown();
            this.RbtnCallsLocator = new System.Windows.Forms.RadioButton();
            this.RbtnAlleCalls = new System.Windows.Forms.RadioButton();
            this.BtnStartTimer = new System.Windows.Forms.Button();
            this.CheckBox1Autostart = new System.Windows.Forms.CheckBox();
            this.label1Coundwon = new System.Windows.Forms.Label();
            this.BtnStopTimer = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabPage3Info = new System.Windows.Forms.TabPage();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DateiToolStripMenuItemDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.SortierungToolStripMenuItemSortierung = new System.Windows.Forms.ToolStripMenuItem();
            this.Label14AnzahlCalls = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3Locator.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1SchriftgrößeListView)).BeginInit();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Sekunden)).BeginInit();
            this.TabPage3Info.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Maroon;
            this.Button1.Location = new System.Drawing.Point(99, 104);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(155, 42);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Calls darstellen";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.BtnLesen_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage3Locator);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Controls.Add(this.TabPage3Info);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(615, 298);
            this.TabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.ListView1Calls);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnAktualisierenStop);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(160, 257);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // ListView1Calls
            // 
            this.ListView1Calls.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListView1Calls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView1Calls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1Calls.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1Calls.GridLines = true;
            this.ListView1Calls.HideSelection = false;
            this.ListView1Calls.Location = new System.Drawing.Point(3, 3);
            this.ListView1Calls.Name = "ListView1Calls";
            this.ListView1Calls.Size = new System.Drawing.Size(601, 254);
            this.ListView1Calls.TabIndex = 18;
            this.ListView1Calls.UseCompatibleStateImageBehavior = false;
            this.ListView1Calls.SelectedIndexChanged += new System.EventHandler(this.ListView1Calls_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Call";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Locator";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Land";
            this.columnHeader3.Width = 200;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Aktualisierung";
            // 
            // btnAktualisierenStop
            // 
            this.btnAktualisierenStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisierenStop.Location = new System.Drawing.Point(688, 305);
            this.btnAktualisierenStop.Name = "btnAktualisierenStop";
            this.btnAktualisierenStop.Size = new System.Drawing.Size(44, 21);
            this.btnAktualisierenStop.TabIndex = 16;
            this.btnAktualisierenStop.Text = "Stop";
            this.btnAktualisierenStop.UseVisualStyleBackColor = true;
            this.btnAktualisierenStop.Click += new System.EventHandler(this.BtnAktualisierenStop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "0000";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(160, 73);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3Locator
            // 
            this.tabPage3Locator.Controls.Add(this.ListView1Locator);
            this.tabPage3Locator.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Locator.Name = "tabPage3Locator";
            this.tabPage3Locator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Locator.Size = new System.Drawing.Size(607, 272);
            this.tabPage3Locator.TabIndex = 2;
            this.tabPage3Locator.Text = "Locator";
            this.tabPage3Locator.UseVisualStyleBackColor = true;
            // 
            // ListView1Locator
            // 
            this.ListView1Locator.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListView1Locator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1Locator.HideSelection = false;
            this.ListView1Locator.Location = new System.Drawing.Point(3, 3);
            this.ListView1Locator.Name = "ListView1Locator";
            this.ListView1Locator.Size = new System.Drawing.Size(601, 266);
            this.ListView1Locator.TabIndex = 1;
            this.ListView1Locator.UseCompatibleStateImageBehavior = false;
            this.ListView1Locator.SelectedIndexChanged += new System.EventHandler(this.ListView1Locator_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Call";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Locator";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Land";
            // 
            // TabPage2
            // 
            this.TabPage2.AutoScroll = true;
            this.TabPage2.BackColor = System.Drawing.Color.Azure;
            this.TabPage2.Controls.Add(this.NumericUpDown1SchriftgrößeListView);
            this.TabPage2.Controls.Add(this.Panel4);
            this.TabPage2.Controls.Add(this.Panel3);
            this.TabPage2.Controls.Add(this.Panel2);
            this.TabPage2.Controls.Add(this.Panel1);
            this.TabPage2.Controls.Add(this.Label13);
            this.TabPage2.Controls.Add(this.Label10);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.label12);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.label6);
            this.TabPage2.Controls.Add(this.label7);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.label2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(607, 272);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Einstellungen";
            // 
            // NumericUpDown1SchriftgrößeListView
            // 
            this.NumericUpDown1SchriftgrößeListView.Location = new System.Drawing.Point(423, 234);
            this.NumericUpDown1SchriftgrößeListView.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDown1SchriftgrößeListView.Name = "NumericUpDown1SchriftgrößeListView";
            this.NumericUpDown1SchriftgrößeListView.Size = new System.Drawing.Size(62, 20);
            this.NumericUpDown1SchriftgrößeListView.TabIndex = 18;
            this.NumericUpDown1SchriftgrößeListView.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDown1SchriftgrößeListView.ValueChanged += new System.EventHandler(this.NumericUpDown1SchriftgrößeListView_ValueChanged);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightGray;
            this.Panel4.Controls.Add(this.RadioButton3AnzeigeDetailliste);
            this.Panel4.Controls.Add(this.RadioButton3AnzeigeListe);
            this.Panel4.Location = new System.Drawing.Point(431, 148);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(117, 67);
            this.Panel4.TabIndex = 17;
            // 
            // RadioButton3AnzeigeDetailliste
            // 
            this.RadioButton3AnzeigeDetailliste.AutoSize = true;
            this.RadioButton3AnzeigeDetailliste.Location = new System.Drawing.Point(10, 36);
            this.RadioButton3AnzeigeDetailliste.Name = "RadioButton3AnzeigeDetailliste";
            this.RadioButton3AnzeigeDetailliste.Size = new System.Drawing.Size(77, 17);
            this.RadioButton3AnzeigeDetailliste.TabIndex = 0;
            this.RadioButton3AnzeigeDetailliste.Text = "Detail Liste";
            this.RadioButton3AnzeigeDetailliste.UseVisualStyleBackColor = true;
            this.RadioButton3AnzeigeDetailliste.CheckedChanged += new System.EventHandler(this.RadioButton1SortierenLocator_CheckedChanged);
            // 
            // RadioButton3AnzeigeListe
            // 
            this.RadioButton3AnzeigeListe.AutoSize = true;
            this.RadioButton3AnzeigeListe.Checked = true;
            this.RadioButton3AnzeigeListe.Location = new System.Drawing.Point(10, 13);
            this.RadioButton3AnzeigeListe.Name = "RadioButton3AnzeigeListe";
            this.RadioButton3AnzeigeListe.Size = new System.Drawing.Size(67, 17);
            this.RadioButton3AnzeigeListe.TabIndex = 0;
            this.RadioButton3AnzeigeListe.TabStop = true;
            this.RadioButton3AnzeigeListe.Text = "Call Liste";
            this.RadioButton3AnzeigeListe.UseVisualStyleBackColor = true;
            this.RadioButton3AnzeigeListe.CheckedChanged += new System.EventHandler(this.RadioButton1SortierenCalls_CheckedChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightGray;
            this.Panel3.Controls.Add(this.RadioButton1SortierenLocator);
            this.Panel3.Controls.Add(this.RadioButton1SortierenCalls);
            this.Panel3.Location = new System.Drawing.Point(299, 148);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(117, 67);
            this.Panel3.TabIndex = 17;
            // 
            // RadioButton1SortierenLocator
            // 
            this.RadioButton1SortierenLocator.AutoSize = true;
            this.RadioButton1SortierenLocator.Location = new System.Drawing.Point(10, 36);
            this.RadioButton1SortierenLocator.Name = "RadioButton1SortierenLocator";
            this.RadioButton1SortierenLocator.Size = new System.Drawing.Size(81, 17);
            this.RadioButton1SortierenLocator.TabIndex = 0;
            this.RadioButton1SortierenLocator.Text = "Aufsteigend";
            this.RadioButton1SortierenLocator.UseVisualStyleBackColor = true;
            this.RadioButton1SortierenLocator.CheckedChanged += new System.EventHandler(this.RadioButton1SortierenLocator_CheckedChanged);
            // 
            // RadioButton1SortierenCalls
            // 
            this.RadioButton1SortierenCalls.AutoSize = true;
            this.RadioButton1SortierenCalls.Checked = true;
            this.RadioButton1SortierenCalls.Location = new System.Drawing.Point(10, 13);
            this.RadioButton1SortierenCalls.Name = "RadioButton1SortierenCalls";
            this.RadioButton1SortierenCalls.Size = new System.Drawing.Size(78, 17);
            this.RadioButton1SortierenCalls.TabIndex = 0;
            this.RadioButton1SortierenCalls.TabStop = true;
            this.RadioButton1SortierenCalls.Text = "Absteigend";
            this.RadioButton1SortierenCalls.UseVisualStyleBackColor = true;
            this.RadioButton1SortierenCalls.CheckedChanged += new System.EventHandler(this.RadioButton1SortierenCalls_CheckedChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.ComboBox1Tabellenblatt);
            this.Panel2.Controls.Add(this.TbMDBpfad);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.BtnOFD);
            this.Panel2.Controls.Add(this.lblPfad);
            this.Panel2.Location = new System.Drawing.Point(6, 25);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(263, 155);
            this.Panel2.TabIndex = 16;
            // 
            // ComboBox1Tabellenblatt
            // 
            this.ComboBox1Tabellenblatt.DisplayMember = "1";
            this.ComboBox1Tabellenblatt.FormattingEnabled = true;
            this.ComboBox1Tabellenblatt.Items.AddRange(new object[] {
            "144MHz",
            "432MHz",
            "1296MHz",
            "2320MHz"});
            this.ComboBox1Tabellenblatt.Location = new System.Drawing.Point(15, 78);
            this.ComboBox1Tabellenblatt.Name = "ComboBox1Tabellenblatt";
            this.ComboBox1Tabellenblatt.Size = new System.Drawing.Size(100, 21);
            this.ComboBox1Tabellenblatt.TabIndex = 9;
            this.ComboBox1Tabellenblatt.Tag = "";
            this.ComboBox1Tabellenblatt.Text = "144MHz";
            this.ComboBox1Tabellenblatt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1Tabellenblatt_SelectedIndexChanged);
            // 
            // TbMDBpfad
            // 
            this.TbMDBpfad.Location = new System.Drawing.Point(15, 26);
            this.TbMDBpfad.Name = "TbMDBpfad";
            this.TbMDBpfad.Size = new System.Drawing.Size(239, 20);
            this.TbMDBpfad.TabIndex = 5;
            this.TbMDBpfad.Text = " erst Datenbank öffnen....";
            this.TbMDBpfad.TextChanged += new System.EventHandler(this.TbMDBpfad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabelle:";
            // 
            // BtnOFD
            // 
            this.BtnOFD.Location = new System.Drawing.Point(192, 52);
            this.BtnOFD.Name = "BtnOFD";
            this.BtnOFD.Size = new System.Drawing.Size(62, 23);
            this.BtnOFD.TabIndex = 8;
            this.BtnOFD.Text = "Öffnen";
            this.BtnOFD.UseVisualStyleBackColor = true;
            this.BtnOFD.Click += new System.EventHandler(this.BtnOFD_Click);
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Location = new System.Drawing.Point(12, 10);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(83, 13);
            this.lblPfad.TabIndex = 6;
            this.lblPfad.Text = "Pfad mdb Datei:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.Panel1.Controls.Add(this.numericUpDown1Sekunden);
            this.Panel1.Controls.Add(this.RbtnCallsLocator);
            this.Panel1.Controls.Add(this.RbtnAlleCalls);
            this.Panel1.Controls.Add(this.BtnStartTimer);
            this.Panel1.Controls.Add(this.CheckBox1Autostart);
            this.Panel1.Controls.Add(this.label1Coundwon);
            this.Panel1.Controls.Add(this.BtnStopTimer);
            this.Panel1.Location = new System.Drawing.Point(299, 26);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(263, 89);
            this.Panel1.TabIndex = 15;
            // 
            // numericUpDown1Sekunden
            // 
            this.numericUpDown1Sekunden.Location = new System.Drawing.Point(3, 6);
            this.numericUpDown1Sekunden.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.numericUpDown1Sekunden.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1Sekunden.Name = "numericUpDown1Sekunden";
            this.numericUpDown1Sekunden.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1Sekunden.TabIndex = 16;
            this.numericUpDown1Sekunden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1Sekunden.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1Sekunden.ValueChanged += new System.EventHandler(this.NumericUpDown1Sekunden_ValueChanged);
            // 
            // RbtnCallsLocator
            // 
            this.RbtnCallsLocator.AutoSize = true;
            this.RbtnCallsLocator.Checked = true;
            this.RbtnCallsLocator.Location = new System.Drawing.Point(166, 60);
            this.RbtnCallsLocator.Name = "RbtnCallsLocator";
            this.RbtnCallsLocator.Size = new System.Drawing.Size(83, 17);
            this.RbtnCallsLocator.TabIndex = 15;
            this.RbtnCallsLocator.TabStop = true;
            this.RbtnCallsLocator.Text = "nur Call/Loc";
            this.RbtnCallsLocator.UseVisualStyleBackColor = true;
            this.RbtnCallsLocator.CheckedChanged += new System.EventHandler(this.RbtnCallsLocator_CheckedChanged);
            // 
            // RbtnAlleCalls
            // 
            this.RbtnAlleCalls.AutoSize = true;
            this.RbtnAlleCalls.Location = new System.Drawing.Point(166, 38);
            this.RbtnAlleCalls.Name = "RbtnAlleCalls";
            this.RbtnAlleCalls.Size = new System.Drawing.Size(67, 17);
            this.RbtnAlleCalls.TabIndex = 15;
            this.RbtnAlleCalls.Text = "Alle Calls";
            this.RbtnAlleCalls.UseVisualStyleBackColor = true;
            this.RbtnAlleCalls.CheckedChanged += new System.EventHandler(this.RbtnAlleCalls_CheckedChanged);
            // 
            // BtnStartTimer
            // 
            this.BtnStartTimer.Location = new System.Drawing.Point(3, 32);
            this.BtnStartTimer.Name = "BtnStartTimer";
            this.BtnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.BtnStartTimer.TabIndex = 10;
            this.BtnStartTimer.Text = "Start";
            this.BtnStartTimer.UseVisualStyleBackColor = true;
            this.BtnStartTimer.Click += new System.EventHandler(this.BtnStartTimer_Click);
            // 
            // CheckBox1Autostart
            // 
            this.CheckBox1Autostart.AutoSize = true;
            this.CheckBox1Autostart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1Autostart.Location = new System.Drawing.Point(3, 61);
            this.CheckBox1Autostart.Name = "CheckBox1Autostart";
            this.CheckBox1Autostart.Size = new System.Drawing.Size(124, 18);
            this.CheckBox1Autostart.TabIndex = 13;
            this.CheckBox1Autostart.Text = "Automatisch Starten";
            this.CheckBox1Autostart.UseVisualStyleBackColor = true;
            this.CheckBox1Autostart.CheckedChanged += new System.EventHandler(this.CheckBox1Autostart_CheckedChanged);
            // 
            // label1Coundwon
            // 
            this.label1Coundwon.AutoSize = true;
            this.label1Coundwon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Coundwon.Location = new System.Drawing.Point(68, 6);
            this.label1Coundwon.Name = "label1Coundwon";
            this.label1Coundwon.Size = new System.Drawing.Size(49, 20);
            this.label1Coundwon.TabIndex = 14;
            this.label1Coundwon.Text = "0000";
            this.label1Coundwon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1Coundwon.Click += new System.EventHandler(this.Label1Coundwon_Click);
            // 
            // BtnStopTimer
            // 
            this.BtnStopTimer.Location = new System.Drawing.Point(84, 32);
            this.BtnStopTimer.Name = "BtnStopTimer";
            this.BtnStopTimer.Size = new System.Drawing.Size(75, 23);
            this.BtnStopTimer.TabIndex = 11;
            this.BtnStopTimer.Text = "Stop";
            this.BtnStopTimer.UseVisualStyleBackColor = true;
            this.BtnStopTimer.Click += new System.EventHandler(this.BtnStopTimer_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(342, 234);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(83, 16);
            this.Label13.TabIndex = 6;
            this.Label13.Text = "Schriftgröße:";
            this.Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(8, 231);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(175, 16);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "4. den Kartenreiter anklicken";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 215);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(183, 16);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "3. Auf Calls darstellen klicken!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Anzeige";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(8, 199);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(173, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "2. Tabellenblatt auswählen..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "sortieren nach ....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Automatische Aktualisierung in Sek....";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 183);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 16);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "1. Datenbank öffnen..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzeigen der Daten...";
            // 
            // TabPage3Info
            // 
            this.TabPage3Info.Controls.Add(this.Label11);
            this.TabPage3Info.Controls.Add(this.TextBox1);
            this.TabPage3Info.Location = new System.Drawing.Point(4, 22);
            this.TabPage3Info.Name = "TabPage3Info";
            this.TabPage3Info.Size = new System.Drawing.Size(607, 272);
            this.TabPage3Info.TabIndex = 0;
            this.TabPage3Info.Text = "Info";
            this.TabPage3Info.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.SystemColors.Window;
            this.Label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label11.Location = new System.Drawing.Point(0, 259);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(41, 13);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "label11";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(607, 272);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateiToolStripMenuItemDatei,
            this.StartToolStripMenuItemStart,
            this.StopToolStripMenuItemStop,
            this.SortierungToolStripMenuItemSortierung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DateiToolStripMenuItemDatei
            // 
            this.DateiToolStripMenuItemDatei.Name = "DateiToolStripMenuItemDatei";
            this.DateiToolStripMenuItemDatei.Size = new System.Drawing.Size(46, 20);
            this.DateiToolStripMenuItemDatei.Text = "Datei";
            this.DateiToolStripMenuItemDatei.Click += new System.EventHandler(this.DateiToolStripMenuItemDatei_Click);
            // 
            // StartToolStripMenuItemStart
            // 
            this.StartToolStripMenuItemStart.Image = global::Contestcalls.Properties.Resources.clock_ein;
            this.StartToolStripMenuItemStart.Name = "StartToolStripMenuItemStart";
            this.StartToolStripMenuItemStart.Size = new System.Drawing.Size(59, 20);
            this.StartToolStripMenuItemStart.Text = "Start";
            this.StartToolStripMenuItemStart.Click += new System.EventHandler(this.StartToolStripMenuItemStart_Click);
            // 
            // StopToolStripMenuItemStop
            // 
            this.StopToolStripMenuItemStop.Image = global::Contestcalls.Properties.Resources.clock_aus;
            this.StopToolStripMenuItemStop.Name = "StopToolStripMenuItemStop";
            this.StopToolStripMenuItemStop.Size = new System.Drawing.Size(59, 20);
            this.StopToolStripMenuItemStop.Text = "Stop";
            this.StopToolStripMenuItemStop.Click += new System.EventHandler(this.StopToolStripMenuItemStop_Click);
            // 
            // SortierungToolStripMenuItemSortierung
            // 
            this.SortierungToolStripMenuItemSortierung.Image = global::Contestcalls.Properties.Resources.arrow_down;
            this.SortierungToolStripMenuItemSortierung.Name = "SortierungToolStripMenuItemSortierung";
            this.SortierungToolStripMenuItemSortierung.Size = new System.Drawing.Size(90, 20);
            this.SortierungToolStripMenuItemSortierung.Text = "Sortierung";
            this.SortierungToolStripMenuItemSortierung.Click += new System.EventHandler(this.SortierungToolStripMenuItemSortierung_Click);
            // 
            // Label14AnzahlCalls
            // 
            this.Label14AnzahlCalls.AutoSize = true;
            this.Label14AnzahlCalls.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label14AnzahlCalls.Location = new System.Drawing.Point(551, 24);
            this.Label14AnzahlCalls.Name = "Label14AnzahlCalls";
            this.Label14AnzahlCalls.Size = new System.Drawing.Size(64, 13);
            this.Label14AnzahlCalls.TabIndex = 8;
            this.Label14AnzahlCalls.Text = "Anzahl Calls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(615, 322);
            this.Controls.Add(this.Label14AnzahlCalls);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Contestcalls @ DL1RLB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3Locator.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1SchriftgrößeListView)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Sekunden)).EndInit();
            this.TabPage3Info.ResumeLayout(false);
            this.TabPage3Info.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPfad;
        private System.Windows.Forms.TextBox TbMDBpfad;
        private System.Windows.Forms.ComboBox ComboBox1Tabellenblatt;
        private System.Windows.Forms.Button BtnOFD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1Coundwon;
        private System.Windows.Forms.CheckBox CheckBox1Autostart;
        private System.Windows.Forms.Button BtnStopTimer;
        private System.Windows.Forms.Button BtnStartTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RbtnCallsLocator;
        private System.Windows.Forms.RadioButton RbtnAlleCalls;
        private System.Windows.Forms.NumericUpDown numericUpDown1Sekunden;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.RadioButton RadioButton1SortierenLocator;
        private System.Windows.Forms.RadioButton RadioButton1SortierenCalls;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAktualisierenStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TabPage3Info;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.ListView ListView1Calls;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.RadioButton RadioButton3AnzeigeDetailliste;
        private System.Windows.Forms.RadioButton RadioButton3AnzeigeListe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DateiToolStripMenuItemDatei;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem SortierungToolStripMenuItemSortierung;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown NumericUpDown1SchriftgrößeListView;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage3Locator;
        private System.Windows.Forms.ListView ListView1Locator;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label14AnzahlCalls;
    }
    }

