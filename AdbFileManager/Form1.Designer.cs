﻿namespace AdbFileManager {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			dataGridView_soubory = new DataGridView();
			timer1 = new System.Windows.Forms.Timer(components);
			cur_path = new TextBox();
			toolTip1 = new ToolTip(components);
			panel_dolniTlacitka = new Panel();
			checkBox_android6fix_fastmode = new CheckBox();
			comboBox_lang = new ComboBox();
			checkBox_unwrapfolders = new CheckBox();
			checkBox_preview = new CheckBox();
			button1 = new Button();
			checkBox_android6fix = new CheckBox();
			version = new LinkLabel();
			checkBox_filedate = new CheckBox();
			panel_tlacitkaUprostred = new Panel();
			button_android2pc = new Button();
			verticalLabel_refresh = new randz.CustomControls.VerticalLabel();
			button_pc2android = new Button();
			explorerBrowser1 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
			explorer_path = new TextBox();
			button_forward = new Button();
			button_back = new Button();
			panel_main = new Panel();
			deco_panel1 = new Panel();
			deco_panel2 = new Panel();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)dataGridView_soubory).BeginInit();
			panel_dolniTlacitka.SuspendLayout();
			panel_tlacitkaUprostred.SuspendLayout();
			panel_main.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView_soubory
			// 
			resources.ApplyResources(dataGridView_soubory, "dataGridView_soubory");
			dataGridView_soubory.AllowUserToAddRows = false;
			dataGridView_soubory.AllowUserToDeleteRows = false;
			dataGridView_soubory.AllowUserToResizeRows = false;
			dataGridView_soubory.BackgroundColor = SystemColors.ButtonHighlight;
			dataGridView_soubory.GridColor = Color.White;
			dataGridView_soubory.Name = "dataGridView_soubory";
			dataGridView_soubory.RowHeadersVisible = false;
			dataGridView_soubory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			toolTip1.SetToolTip(dataGridView_soubory, resources.GetString("dataGridView_soubory.ToolTip"));
			dataGridView_soubory.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
			dataGridView_soubory.ColumnHeaderMouseDoubleClick += dataGridView1_ColumnHeaderMouseDoubleClick;
			dataGridView_soubory.KeyDown += dataGridView1_KeyDown;
			// 
			// timer1
			// 
			timer1.Interval = 500;
			timer1.Tick += timer1_Tick;
			// 
			// cur_path
			// 
			resources.ApplyResources(cur_path, "cur_path");
			cur_path.Name = "cur_path";
			toolTip1.SetToolTip(cur_path, resources.GetString("cur_path.ToolTip"));
			cur_path.TextChanged += cur_path_TextChanged;
			// 
			// panel_dolniTlacitka
			// 
			resources.ApplyResources(panel_dolniTlacitka, "panel_dolniTlacitka");
			panel_dolniTlacitka.BackColor = Color.FromArgb(192, 255, 255);
			panel_dolniTlacitka.Controls.Add(checkBox_android6fix_fastmode);
			panel_dolniTlacitka.Controls.Add(comboBox_lang);
			panel_dolniTlacitka.Controls.Add(checkBox_unwrapfolders);
			panel_dolniTlacitka.Controls.Add(checkBox_preview);
			panel_dolniTlacitka.Controls.Add(button1);
			panel_dolniTlacitka.Controls.Add(checkBox_android6fix);
			panel_dolniTlacitka.Controls.Add(version);
			panel_dolniTlacitka.Controls.Add(checkBox_filedate);
			panel_dolniTlacitka.Name = "panel_dolniTlacitka";
			toolTip1.SetToolTip(panel_dolniTlacitka, resources.GetString("panel_dolniTlacitka.ToolTip"));
			// 
			// checkBox_android6fix_fastmode
			// 
			resources.ApplyResources(checkBox_android6fix_fastmode, "checkBox_android6fix_fastmode");
			checkBox_android6fix_fastmode.Name = "checkBox_android6fix_fastmode";
			toolTip1.SetToolTip(checkBox_android6fix_fastmode, resources.GetString("checkBox_android6fix_fastmode.ToolTip"));
			checkBox_android6fix_fastmode.UseVisualStyleBackColor = true;
			// 
			// comboBox_lang
			// 
			resources.ApplyResources(comboBox_lang, "comboBox_lang");
			comboBox_lang.FormattingEnabled = true;
			comboBox_lang.Name = "comboBox_lang";
			toolTip1.SetToolTip(comboBox_lang, resources.GetString("comboBox_lang.ToolTip"));
			// 
			// checkBox_unwrapfolders
			// 
			resources.ApplyResources(checkBox_unwrapfolders, "checkBox_unwrapfolders");
			checkBox_unwrapfolders.Name = "checkBox_unwrapfolders";
			toolTip1.SetToolTip(checkBox_unwrapfolders, resources.GetString("checkBox_unwrapfolders.ToolTip"));
			checkBox_unwrapfolders.UseVisualStyleBackColor = true;
			// 
			// checkBox_preview
			// 
			resources.ApplyResources(checkBox_preview, "checkBox_preview");
			checkBox_preview.Name = "checkBox_preview";
			toolTip1.SetToolTip(checkBox_preview, resources.GetString("checkBox_preview.ToolTip"));
			checkBox_preview.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			resources.ApplyResources(button1, "button1");
			button1.Name = "button1";
			toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// checkBox_android6fix
			// 
			resources.ApplyResources(checkBox_android6fix, "checkBox_android6fix");
			checkBox_android6fix.Name = "checkBox_android6fix";
			toolTip1.SetToolTip(checkBox_android6fix, resources.GetString("checkBox_android6fix.ToolTip"));
			checkBox_android6fix.UseVisualStyleBackColor = true;
			checkBox_android6fix.CheckedChanged += checkBox_android6fix_CheckedChanged;
			// 
			// version
			// 
			resources.ApplyResources(version, "version");
			version.Name = "version";
			version.TabStop = true;
			toolTip1.SetToolTip(version, resources.GetString("version.ToolTip"));
			version.LinkClicked += version_LinkClicked;
			// 
			// checkBox_filedate
			// 
			resources.ApplyResources(checkBox_filedate, "checkBox_filedate");
			checkBox_filedate.Name = "checkBox_filedate";
			toolTip1.SetToolTip(checkBox_filedate, resources.GetString("checkBox_filedate.ToolTip"));
			checkBox_filedate.UseVisualStyleBackColor = true;
			// 
			// panel_tlacitkaUprostred
			// 
			resources.ApplyResources(panel_tlacitkaUprostred, "panel_tlacitkaUprostred");
			panel_tlacitkaUprostred.Controls.Add(button_android2pc);
			panel_tlacitkaUprostred.Controls.Add(verticalLabel_refresh);
			panel_tlacitkaUprostred.Controls.Add(button_pc2android);
			panel_tlacitkaUprostred.Controls.Add(deco_panel1);
			panel_tlacitkaUprostred.Controls.Add(deco_panel2);
			panel_tlacitkaUprostred.Controls.Add(panel1);
			panel_tlacitkaUprostred.Name = "panel_tlacitkaUprostred";
			toolTip1.SetToolTip(panel_tlacitkaUprostred, resources.GetString("panel_tlacitkaUprostred.ToolTip"));
			// 
			// button_android2pc
			// 
			resources.ApplyResources(button_android2pc, "button_android2pc");
			button_android2pc.BackColor = SystemColors.ControlLight;
			button_android2pc.FlatAppearance.BorderSize = 0;
			button_android2pc.Name = "button_android2pc";
			toolTip1.SetToolTip(button_android2pc, resources.GetString("button_android2pc.ToolTip"));
			button_android2pc.UseVisualStyleBackColor = false;
			button_android2pc.Click += android2pc_Click;
			// 
			// verticalLabel_refresh
			// 
			resources.ApplyResources(verticalLabel_refresh, "verticalLabel_refresh");
			verticalLabel_refresh.BackColor = SystemColors.ControlLight;
			verticalLabel_refresh.ForeColor = SystemColors.ControlText;
			verticalLabel_refresh.Name = "verticalLabel_refresh";
			verticalLabel_refresh.RenderingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			verticalLabel_refresh.TextDrawMode = randz.CustomControls.DrawMode.TopBottom;
			toolTip1.SetToolTip(verticalLabel_refresh, resources.GetString("verticalLabel_refresh.ToolTip"));
			verticalLabel_refresh.TransparentBackground = false;
			verticalLabel_refresh.Click += verticalLabel1_Click;
			verticalLabel_refresh.DoubleClick += verticalLabel1_Click;
			verticalLabel_refresh.MouseClick += verticalLabel1_Click;
			verticalLabel_refresh.MouseDoubleClick += verticalLabel1_Click;
			// 
			// button_pc2android
			// 
			resources.ApplyResources(button_pc2android, "button_pc2android");
			button_pc2android.BackColor = SystemColors.ControlLight;
			button_pc2android.FlatAppearance.BorderSize = 0;
			button_pc2android.Name = "button_pc2android";
			toolTip1.SetToolTip(button_pc2android, resources.GetString("button_pc2android.ToolTip"));
			button_pc2android.UseVisualStyleBackColor = false;
			button_pc2android.Click += pc2android_Click;
			// 
			// explorerBrowser1
			// 
			resources.ApplyResources(explorerBrowser1, "explorerBrowser1");
			explorerBrowser1.Name = "explorerBrowser1";
			explorerBrowser1.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
			toolTip1.SetToolTip(explorerBrowser1, resources.GetString("explorerBrowser1.ToolTip"));
			explorerBrowser1.NavigationComplete += explorerBrowser1_NavigationComplete;
			explorerBrowser1.Load += explorerBrowser1_Load;
			explorerBrowser1.PreviewKeyDown += explorerBrowser1_PreviewKeyDown;
			// 
			// explorer_path
			// 
			resources.ApplyResources(explorer_path, "explorer_path");
			explorer_path.Name = "explorer_path";
			toolTip1.SetToolTip(explorer_path, resources.GetString("explorer_path.ToolTip"));
			explorer_path.KeyPress += explorer_path_KeyPress;
			// 
			// button_forward
			// 
			resources.ApplyResources(button_forward, "button_forward");
			button_forward.FlatAppearance.BorderSize = 0;
			button_forward.Image = Properties.Resources.travel_forward_enabled;
			button_forward.Name = "button_forward";
			toolTip1.SetToolTip(button_forward, resources.GetString("button_forward.ToolTip"));
			button_forward.UseVisualStyleBackColor = true;
			button_forward.Click += button_forward_Click;
			button_forward.MouseDown += buttonforward_MouseDown;
			button_forward.MouseEnter += buttonforward_MouseEnter;
			button_forward.MouseLeave += buttonforward_MouseLeave;
			button_forward.MouseUp += buttonforward_MouseUp;
			// 
			// button_back
			// 
			resources.ApplyResources(button_back, "button_back");
			button_back.FlatAppearance.BorderSize = 0;
			button_back.Image = Properties.Resources.travel_back_enabled;
			button_back.Name = "button_back";
			toolTip1.SetToolTip(button_back, resources.GetString("button_back.ToolTip"));
			button_back.UseVisualStyleBackColor = true;
			button_back.Click += button_back_Click;
			button_back.MouseDown += buttonback_MouseDown;
			button_back.MouseEnter += buttonback_MouseEnter;
			button_back.MouseLeave += buttonback_MouseLeave;
			button_back.MouseUp += buttonback_MouseUp;
			// 
			// panel_main
			// 
			resources.ApplyResources(panel_main, "panel_main");
			panel_main.Controls.Add(button_back);
			panel_main.Controls.Add(button_forward);
			panel_main.Controls.Add(explorer_path);
			panel_main.Controls.Add(explorerBrowser1);
			panel_main.Controls.Add(panel_tlacitkaUprostred);
			panel_main.Controls.Add(panel_dolniTlacitka);
			panel_main.Name = "panel_main";
			toolTip1.SetToolTip(panel_main, resources.GetString("panel_main.ToolTip"));
			// 
			// deco_panel1
			// 
			resources.ApplyResources(deco_panel1, "deco_panel1");
			deco_panel1.BackColor = Color.Gray;
			deco_panel1.ForeColor = SystemColors.ControlText;
			deco_panel1.Name = "deco_panel1";
			toolTip1.SetToolTip(deco_panel1, resources.GetString("deco_panel1.ToolTip"));
			// 
			// deco_panel2
			// 
			resources.ApplyResources(deco_panel2, "deco_panel2");
			deco_panel2.BackColor = Color.Gray;
			deco_panel2.Name = "deco_panel2";
			toolTip1.SetToolTip(deco_panel2, resources.GetString("deco_panel2.ToolTip"));
			// 
			// panel1
			// 
			resources.ApplyResources(panel1, "panel1");
			panel1.BackColor = Color.Gray;
			panel1.Name = "panel1";
			toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(cur_path);
			Controls.Add(dataGridView_soubory);
			Controls.Add(panel_main);
			Name = "Form1";
			toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			FormClosing += Form1_FormClosing;
			FormClosed += Form1_FormClosed;
			Load += Form1_Load;
			Resize += Form1_Resize;
			((System.ComponentModel.ISupportInitialize)dataGridView_soubory).EndInit();
			panel_dolniTlacitka.ResumeLayout(false);
			panel_dolniTlacitka.PerformLayout();
			panel_tlacitkaUprostred.ResumeLayout(false);
			panel_main.ResumeLayout(false);
			panel_main.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public DataGridView dataGridView_soubory;
		private System.Windows.Forms.Timer timer1;
		private TextBox cur_path;
		private ToolTip toolTip1;
		private Panel panel_dolniTlacitka;
		private CheckBox checkBox_android6fix_fastmode;
		public ComboBox comboBox_lang;
		private CheckBox checkBox_unwrapfolders;
		private CheckBox checkBox_preview;
		private Button button1;
		public CheckBox checkBox_android6fix;
		private LinkLabel version;
		private CheckBox checkBox_filedate;
		private Panel panel_tlacitkaUprostred;
		private Button button_android2pc;
		private randz.CustomControls.VerticalLabel verticalLabel_refresh;
		private Button button_pc2android;
		public Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser1;
		private TextBox explorer_path;
		private Button button_forward;
		private Button button_back;
		private Panel panel_main;
		private Panel deco_panel1;
		private Panel deco_panel2;
		private Panel panel1;
	}
}