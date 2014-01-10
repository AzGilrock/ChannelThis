namespace ChannelThis
{
  partial class mainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
      this.ribbon1 = new System.Windows.Forms.Ribbon();
      this.menu_exit = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
      this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
      this.cmdNew = new System.Windows.Forms.RibbonButton();
      this.cmdOpen = new System.Windows.Forms.RibbonButton();
      this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
      this.cmdSave = new System.Windows.Forms.RibbonButton();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.device_grid = new AdvancedDataGridView.TreeGridView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.fixture_grid = new System.Windows.Forms.DataGridView();
      this.fixture_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fixture_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fixture_num_members = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.channel_grid = new System.Windows.Forms.DataGridView();
      this.channel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Circuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Network = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_channel_count = new System.Windows.Forms.Label();
      this.btnNumberUniverse = new System.Windows.Forms.Button();
      this.txtUniverse = new System.Windows.Forms.TextBox();
      this.txtCircuitStart = new System.Windows.Forms.TextBox();
      this.btnRenumberCircuits = new System.Windows.Forms.Button();
      this.Image = new System.Windows.Forms.DataGridViewImageColumn();
      this.device_name = new AdvancedDataGridView.TreeGridColumn();
      this.channel_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.channel_network = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.channel_circuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.device_grid)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fixture_grid)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.channel_grid)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon1
      // 
      this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.ribbon1.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.Minimized = false;
      this.ribbon1.Name = "ribbon1";
      // 
      // 
      // 
      this.ribbon1.OrbDropDown.BorderRoundness = 8;
      this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.OrbDropDown.MenuItems.Add(this.menu_exit);
      this.ribbon1.OrbDropDown.Name = "";
      this.ribbon1.OrbDropDown.RecentItemsCaption = null;
      this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 116);
      this.ribbon1.OrbDropDown.TabIndex = 0;
      this.ribbon1.OrbImage = null;
      this.ribbon1.OrbText = null;
      // 
      // 
      // 
      this.ribbon1.QuickAcessToolbar.AltKey = null;
      this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
      this.ribbon1.QuickAcessToolbar.Image = null;
      this.ribbon1.QuickAcessToolbar.ShowFlashImage = false;
      this.ribbon1.QuickAcessToolbar.Tag = null;
      this.ribbon1.QuickAcessToolbar.Text = null;
      this.ribbon1.QuickAcessToolbar.ToolTip = null;
      this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
      this.ribbon1.QuickAcessToolbar.Value = null;
      this.ribbon1.Size = new System.Drawing.Size(948, 130);
      this.ribbon1.TabIndex = 0;
      this.ribbon1.Tabs.Add(this.ribbonTab1);
      this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
      this.ribbon1.TabSpacing = 6;
      // 
      // menu_exit
      // 
      this.menu_exit.AltKey = null;
      this.menu_exit.CheckedGroup = null;
      this.menu_exit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.menu_exit.DropDownArrowSize = new System.Drawing.Size(5, 3);
      this.menu_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_exit.Image")));
      this.menu_exit.ShowFlashImage = false;
      this.menu_exit.SmallImage = ((System.Drawing.Image)(resources.GetObject("menu_exit.SmallImage")));
      this.menu_exit.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
      this.menu_exit.Tag = null;
      this.menu_exit.Text = "Exit";
      this.menu_exit.ToolTip = null;
      this.menu_exit.ToolTipTitle = null;
      this.menu_exit.Value = null;
      this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
      // 
      // ribbonTab1
      // 
      this.ribbonTab1.Panels.Add(this.ribbonPanel1);
      this.ribbonTab1.Tag = null;
      this.ribbonTab1.Text = "File";
      this.ribbonTab1.ToolTip = null;
      this.ribbonTab1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
      this.ribbonTab1.ToolTipImage = null;
      this.ribbonTab1.ToolTipTitle = null;
      this.ribbonTab1.Value = null;
      // 
      // ribbonPanel1
      // 
      this.ribbonPanel1.Items.Add(this.cmdNew);
      this.ribbonPanel1.Items.Add(this.cmdOpen);
      this.ribbonPanel1.Items.Add(this.cmdSave);
      this.ribbonPanel1.Tag = null;
      this.ribbonPanel1.Text = "File Operations";
      // 
      // cmdNew
      // 
      this.cmdNew.AltKey = null;
      this.cmdNew.CheckedGroup = null;
      this.cmdNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
      this.cmdNew.DropDownArrowSize = new System.Drawing.Size(5, 3);
      this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
      this.cmdNew.ShowFlashImage = false;
      this.cmdNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdNew.SmallImage")));
      this.cmdNew.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
      this.cmdNew.Tag = null;
      this.cmdNew.Text = "New";
      this.cmdNew.ToolTip = null;
      this.cmdNew.ToolTipTitle = null;
      this.cmdNew.Value = null;
      this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
      // 
      // cmdOpen
      // 
      this.cmdOpen.AltKey = null;
      this.cmdOpen.CheckedGroup = null;
      this.cmdOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
      this.cmdOpen.DropDownArrowSize = new System.Drawing.Size(5, 3);
      this.cmdOpen.DropDownItems.Add(this.ribbonButton1);
      this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
      this.cmdOpen.ShowFlashImage = false;
      this.cmdOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdOpen.SmallImage")));
      this.cmdOpen.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
      this.cmdOpen.Tag = null;
      this.cmdOpen.Text = "Open";
      this.cmdOpen.ToolTip = null;
      this.cmdOpen.ToolTipTitle = null;
      this.cmdOpen.Value = null;
      this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
      // 
      // ribbonButton1
      // 
      this.ribbonButton1.AltKey = null;
      this.ribbonButton1.CheckedGroup = null;
      this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
      this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
      this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
      this.ribbonButton1.ShowFlashImage = false;
      this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
      this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
      this.ribbonButton1.Tag = null;
      this.ribbonButton1.Text = "ribbonButton1";
      this.ribbonButton1.ToolTip = null;
      this.ribbonButton1.ToolTipTitle = null;
      this.ribbonButton1.Value = null;
      // 
      // cmdSave
      // 
      this.cmdSave.AltKey = null;
      this.cmdSave.CheckedGroup = null;
      this.cmdSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
      this.cmdSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
      this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
      this.cmdSave.ShowFlashImage = false;
      this.cmdSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdSave.SmallImage")));
      this.cmdSave.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
      this.cmdSave.Tag = null;
      this.cmdSave.Text = "Save";
      this.cmdSave.ToolTip = null;
      this.cmdSave.ToolTipTitle = null;
      this.cmdSave.Value = null;
      this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(22, 172);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(884, 506);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.device_grid);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(876, 480);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Devices";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // device_grid
      // 
      this.device_grid.AllowUserToAddRows = false;
      this.device_grid.AllowUserToDeleteRows = false;
      this.device_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.device_name,
            this.channel_index,
            this.channel_network,
            this.channel_circuit});
      this.device_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.device_grid.ImageList = null;
      this.device_grid.Location = new System.Drawing.Point(7, 7);
      this.device_grid.Name = "device_grid";
      this.device_grid.RowHeadersWidth = 20;
      this.device_grid.Size = new System.Drawing.Size(863, 467);
      this.device_grid.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.fixture_grid);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(876, 480);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Tracks";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // fixture_grid
      // 
      this.fixture_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.fixture_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fixture_name,
            this.fixture_id,
            this.fixture_num_members});
      this.fixture_grid.Location = new System.Drawing.Point(6, 6);
      this.fixture_grid.Name = "fixture_grid";
      this.fixture_grid.Size = new System.Drawing.Size(346, 468);
      this.fixture_grid.TabIndex = 3;
      // 
      // fixture_name
      // 
      this.fixture_name.HeaderText = "Name";
      this.fixture_name.Name = "fixture_name";
      // 
      // fixture_id
      // 
      this.fixture_id.HeaderText = "ID";
      this.fixture_id.Name = "fixture_id";
      // 
      // fixture_num_members
      // 
      this.fixture_num_members.HeaderText = "Members";
      this.fixture_num_members.Name = "fixture_num_members";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.channel_grid);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(876, 480);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Channels";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // channel_grid
      // 
      this.channel_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.channel_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.channel_name,
            this.Index,
            this.Color,
            this.DeviceType,
            this.Unit,
            this.Circuit,
            this.Network});
      this.channel_grid.Location = new System.Drawing.Point(6, 6);
      this.channel_grid.Name = "channel_grid";
      this.channel_grid.Size = new System.Drawing.Size(864, 474);
      this.channel_grid.TabIndex = 3;
      // 
      // channel_name
      // 
      this.channel_name.HeaderText = "Name";
      this.channel_name.Name = "channel_name";
      // 
      // Index
      // 
      this.Index.HeaderText = "Index";
      this.Index.Name = "Index";
      // 
      // Color
      // 
      this.Color.HeaderText = "Color";
      this.Color.Name = "Color";
      // 
      // DeviceType
      // 
      this.DeviceType.HeaderText = "Device Type";
      this.DeviceType.Name = "DeviceType";
      // 
      // Unit
      // 
      this.Unit.HeaderText = "Unit";
      this.Unit.Name = "Unit";
      // 
      // Circuit
      // 
      this.Circuit.HeaderText = "Circuit";
      this.Circuit.Name = "Circuit";
      // 
      // Network
      // 
      this.Network.HeaderText = "Network";
      this.Network.Name = "Network";
      // 
      // txtFileName
      // 
      this.txtFileName.Enabled = false;
      this.txtFileName.Location = new System.Drawing.Point(80, 139);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(420, 20);
      this.txtFileName.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 142);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Filename:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(629, 145);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Channel Count:";
      // 
      // lbl_channel_count
      // 
      this.lbl_channel_count.AutoSize = true;
      this.lbl_channel_count.Location = new System.Drawing.Point(716, 145);
      this.lbl_channel_count.Name = "lbl_channel_count";
      this.lbl_channel_count.Size = new System.Drawing.Size(0, 13);
      this.lbl_channel_count.TabIndex = 10;
      // 
      // btnNumberUniverse
      // 
      this.btnNumberUniverse.Location = new System.Drawing.Point(26, 701);
      this.btnNumberUniverse.Name = "btnNumberUniverse";
      this.btnNumberUniverse.Size = new System.Drawing.Size(82, 23);
      this.btnNumberUniverse.TabIndex = 11;
      this.btnNumberUniverse.Text = "Set Universe";
      this.btnNumberUniverse.UseVisualStyleBackColor = true;
      this.btnNumberUniverse.Click += new System.EventHandler(this.btnNumberUniverse_Click);
      // 
      // txtUniverse
      // 
      this.txtUniverse.Location = new System.Drawing.Point(125, 703);
      this.txtUniverse.Name = "txtUniverse";
      this.txtUniverse.Size = new System.Drawing.Size(100, 20);
      this.txtUniverse.TabIndex = 12;
      // 
      // txtCircuitStart
      // 
      this.txtCircuitStart.Location = new System.Drawing.Point(386, 702);
      this.txtCircuitStart.Name = "txtCircuitStart";
      this.txtCircuitStart.Size = new System.Drawing.Size(100, 20);
      this.txtCircuitStart.TabIndex = 14;
      // 
      // btnRenumberCircuits
      // 
      this.btnRenumberCircuits.Location = new System.Drawing.Point(287, 700);
      this.btnRenumberCircuits.Name = "btnRenumberCircuits";
      this.btnRenumberCircuits.Size = new System.Drawing.Size(82, 23);
      this.btnRenumberCircuits.TabIndex = 13;
      this.btnRenumberCircuits.Text = "Renumber Circuits";
      this.btnRenumberCircuits.UseVisualStyleBackColor = true;
      this.btnRenumberCircuits.Click += new System.EventHandler(this.btnRenumberCircuits_Click);
      // 
      // Image
      // 
      this.Image.HeaderText = "";
      this.Image.Name = "Image";
      this.Image.Width = 20;
      // 
      // device_name
      // 
      this.device_name.DefaultNodeImage = null;
      this.device_name.HeaderText = "Name";
      this.device_name.Name = "device_name";
      this.device_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.device_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // channel_index
      // 
      this.channel_index.HeaderText = "Index";
      this.channel_index.Name = "channel_index";
      this.channel_index.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.channel_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // channel_network
      // 
      this.channel_network.HeaderText = "Network";
      this.channel_network.Name = "channel_network";
      this.channel_network.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.channel_network.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // channel_circuit
      // 
      this.channel_circuit.HeaderText = "Circuit";
      this.channel_circuit.Name = "channel_circuit";
      this.channel_circuit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.channel_circuit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(948, 774);
      this.Controls.Add(this.txtCircuitStart);
      this.Controls.Add(this.btnRenumberCircuits);
      this.Controls.Add(this.txtUniverse);
      this.Controls.Add(this.btnNumberUniverse);
      this.Controls.Add(this.lbl_channel_count);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtFileName);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.ribbon1);
      this.Name = "mainForm";
      this.Text = "ChannelThis";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.device_grid)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fixture_grid)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.channel_grid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Ribbon ribbon1;
    private System.Windows.Forms.RibbonTab ribbonTab1;
    private System.Windows.Forms.RibbonPanel ribbonPanel1;
    private System.Windows.Forms.RibbonButton cmdNew;
    private System.Windows.Forms.RibbonButton cmdOpen;
    private System.Windows.Forms.RibbonButton ribbonButton1;
    private System.Windows.Forms.RibbonButton cmdSave;
    private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView fixture_grid;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_num_members;
    private System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView channel_grid;
    private System.Windows.Forms.DataGridViewTextBoxColumn channel_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn Index;
    private System.Windows.Forms.DataGridViewTextBoxColumn Color;
    private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
    private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    private System.Windows.Forms.DataGridViewTextBoxColumn Circuit;
    private System.Windows.Forms.DataGridViewTextBoxColumn Network;
    private System.Windows.Forms.RibbonOrbMenuItem menu_exit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_channel_count;
    private System.Windows.Forms.Button btnNumberUniverse;
    private System.Windows.Forms.TextBox txtUniverse;
    private System.Windows.Forms.TextBox txtCircuitStart;
    private System.Windows.Forms.Button btnRenumberCircuits;
    private AdvancedDataGridView.TreeGridView device_grid;
    private System.Windows.Forms.DataGridViewImageColumn Image;
    private AdvancedDataGridView.TreeGridColumn device_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn channel_index;
    private System.Windows.Forms.DataGridViewTextBoxColumn channel_network;
    private System.Windows.Forms.DataGridViewTextBoxColumn channel_circuit;

  }
}

