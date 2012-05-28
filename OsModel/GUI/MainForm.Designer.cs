namespace OsModel.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.realMachineTab = new System.Windows.Forms.TabPage();
            this.registersGroupBox = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sfLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ptrLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cxLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.realMemoryGridView = new System.Windows.Forms.DataGridView();
            this.virtualMachinesTab = new System.Windows.Forms.TabPage();
            this.virtualMachineTabControl = new System.Windows.Forms.TabControl();
            this.processTab = new System.Windows.Forms.TabPage();
            this.processGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkpointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceTab = new System.Windows.Forms.TabPage();
            this.resourcesGridView = new System.Windows.Forms.DataGridView();
            this.resIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resParentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resStateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ioTab = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.executeCountBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.coreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.realMachineTab.SuspendLayout();
            this.registersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realMemoryGridView)).BeginInit();
            this.virtualMachinesTab.SuspendLayout();
            this.processTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).BeginInit();
            this.resourceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).BeginInit();
            this.ioTab.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.realMachineTab);
            this.tabControl.Controls.Add(this.virtualMachinesTab);
            this.tabControl.Controls.Add(this.processTab);
            this.tabControl.Controls.Add(this.resourceTab);
            this.tabControl.Controls.Add(this.ioTab);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(725, 566);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // realMachineTab
            // 
            this.realMachineTab.BackColor = System.Drawing.SystemColors.Control;
            this.realMachineTab.Controls.Add(this.registersGroupBox);
            this.realMachineTab.Controls.Add(this.realMemoryGridView);
            this.realMachineTab.Location = new System.Drawing.Point(4, 22);
            this.realMachineTab.Name = "realMachineTab";
            this.realMachineTab.Size = new System.Drawing.Size(717, 540);
            this.realMachineTab.TabIndex = 0;
            this.realMachineTab.Text = "Real Machine";
            // 
            // registersGroupBox
            // 
            this.registersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registersGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.registersGroupBox.Controls.Add(this.timeLabel);
            this.registersGroupBox.Controls.Add(this.label3);
            this.registersGroupBox.Controls.Add(this.pcLabel);
            this.registersGroupBox.Controls.Add(this.label14);
            this.registersGroupBox.Controls.Add(this.modeLabel);
            this.registersGroupBox.Controls.Add(this.label10);
            this.registersGroupBox.Controls.Add(this.sfLabel);
            this.registersGroupBox.Controls.Add(this.label8);
            this.registersGroupBox.Controls.Add(this.ptrLabel);
            this.registersGroupBox.Controls.Add(this.label6);
            this.registersGroupBox.Controls.Add(this.cxLabel);
            this.registersGroupBox.Controls.Add(this.label4);
            this.registersGroupBox.Controls.Add(this.axLabel);
            this.registersGroupBox.Controls.Add(this.label1);
            this.registersGroupBox.Location = new System.Drawing.Point(6, 482);
            this.registersGroupBox.Name = "registersGroupBox";
            this.registersGroupBox.Size = new System.Drawing.Size(711, 57);
            this.registersGroupBox.TabIndex = 1;
            this.registersGroupBox.TabStop = false;
            this.registersGroupBox.Text = "Registers";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(537, 25);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 13);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "TIME";
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.BackColor = System.Drawing.SystemColors.Info;
            this.pcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcLabel.Location = new System.Drawing.Point(246, 25);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(21, 13);
            this.pcLabel.TabIndex = 13;
            this.pcLabel.Text = "PC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "PC";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(405, 25);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(39, 13);
            this.modeLabel.TabIndex = 9;
            this.modeLabel.Text = "MODE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "MODE";
            // 
            // sfLabel
            // 
            this.sfLabel.AutoSize = true;
            this.sfLabel.BackColor = System.Drawing.SystemColors.Info;
            this.sfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfLabel.Location = new System.Drawing.Point(316, 25);
            this.sfLabel.Name = "sfLabel";
            this.sfLabel.Size = new System.Drawing.Size(20, 13);
            this.sfLabel.TabIndex = 7;
            this.sfLabel.Text = "SF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "SF";
            // 
            // ptrLabel
            // 
            this.ptrLabel.AutoSize = true;
            this.ptrLabel.BackColor = System.Drawing.SystemColors.Info;
            this.ptrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptrLabel.Location = new System.Drawing.Point(171, 25);
            this.ptrLabel.Name = "ptrLabel";
            this.ptrLabel.Size = new System.Drawing.Size(29, 13);
            this.ptrLabel.TabIndex = 5;
            this.ptrLabel.Text = "PTR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "PTR";
            // 
            // cxLabel
            // 
            this.cxLabel.AutoSize = true;
            this.cxLabel.BackColor = System.Drawing.SystemColors.Info;
            this.cxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxLabel.Location = new System.Drawing.Point(97, 25);
            this.cxLabel.Name = "cxLabel";
            this.cxLabel.Size = new System.Drawing.Size(21, 13);
            this.cxLabel.TabIndex = 3;
            this.cxLabel.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CX";
            // 
            // axLabel
            // 
            this.axLabel.AutoSize = true;
            this.axLabel.BackColor = System.Drawing.SystemColors.Info;
            this.axLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axLabel.Location = new System.Drawing.Point(33, 25);
            this.axLabel.Name = "axLabel";
            this.axLabel.Size = new System.Drawing.Size(21, 13);
            this.axLabel.TabIndex = 1;
            this.axLabel.Text = "AX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AX";
            // 
            // realMemoryGridView
            // 
            this.realMemoryGridView.AllowUserToAddRows = false;
            this.realMemoryGridView.AllowUserToDeleteRows = false;
            this.realMemoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realMemoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.realMemoryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.realMemoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realMemoryGridView.Location = new System.Drawing.Point(3, 3);
            this.realMemoryGridView.Name = "realMemoryGridView";
            this.realMemoryGridView.ReadOnly = true;
            this.realMemoryGridView.Size = new System.Drawing.Size(711, 473);
            this.realMemoryGridView.TabIndex = 0;
            // 
            // virtualMachinesTab
            // 
            this.virtualMachinesTab.BackColor = System.Drawing.SystemColors.Control;
            this.virtualMachinesTab.Controls.Add(this.virtualMachineTabControl);
            this.virtualMachinesTab.Location = new System.Drawing.Point(4, 22);
            this.virtualMachinesTab.Name = "virtualMachinesTab";
            this.virtualMachinesTab.Size = new System.Drawing.Size(717, 540);
            this.virtualMachinesTab.TabIndex = 1;
            this.virtualMachinesTab.Text = "Virtual Machines";
            // 
            // virtualMachineTabControl
            // 
            this.virtualMachineTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualMachineTabControl.Location = new System.Drawing.Point(3, 3);
            this.virtualMachineTabControl.Name = "virtualMachineTabControl";
            this.virtualMachineTabControl.SelectedIndex = 0;
            this.virtualMachineTabControl.Size = new System.Drawing.Size(711, 534);
            this.virtualMachineTabControl.TabIndex = 0;
            // 
            // processTab
            // 
            this.processTab.BackColor = System.Drawing.SystemColors.Control;
            this.processTab.Controls.Add(this.processGridView);
            this.processTab.Location = new System.Drawing.Point(4, 22);
            this.processTab.Name = "processTab";
            this.processTab.Size = new System.Drawing.Size(717, 540);
            this.processTab.TabIndex = 2;
            this.processTab.Text = "Processes";
            // 
            // processGridView
            // 
            this.processGridView.AllowUserToAddRows = false;
            this.processGridView.AllowUserToDeleteRows = false;
            this.processGridView.AllowUserToOrderColumns = true;
            this.processGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.stateColumn,
            this.parentColumn,
            this.priorityColumn,
            this.checkpointColumn});
            this.processGridView.Location = new System.Drawing.Point(-4, 0);
            this.processGridView.Name = "processGridView";
            this.processGridView.ReadOnly = true;
            this.processGridView.Size = new System.Drawing.Size(718, 540);
            this.processGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // stateColumn
            // 
            this.stateColumn.HeaderText = "State";
            this.stateColumn.Name = "stateColumn";
            this.stateColumn.ReadOnly = true;
            // 
            // parentColumn
            // 
            this.parentColumn.HeaderText = "Parent";
            this.parentColumn.Name = "parentColumn";
            this.parentColumn.ReadOnly = true;
            // 
            // priorityColumn
            // 
            this.priorityColumn.HeaderText = "Priority";
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.ReadOnly = true;
            // 
            // checkpointColumn
            // 
            this.checkpointColumn.HeaderText = "Checkpoint";
            this.checkpointColumn.Name = "checkpointColumn";
            this.checkpointColumn.ReadOnly = true;
            // 
            // resourceTab
            // 
            this.resourceTab.BackColor = System.Drawing.SystemColors.Control;
            this.resourceTab.Controls.Add(this.resourcesGridView);
            this.resourceTab.Location = new System.Drawing.Point(4, 22);
            this.resourceTab.Name = "resourceTab";
            this.resourceTab.Size = new System.Drawing.Size(717, 540);
            this.resourceTab.TabIndex = 3;
            this.resourceTab.Text = "Resources";
            // 
            // resourcesGridView
            // 
            this.resourcesGridView.AllowUserToAddRows = false;
            this.resourcesGridView.AllowUserToDeleteRows = false;
            this.resourcesGridView.AllowUserToOrderColumns = true;
            this.resourcesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourcesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resIdColumn,
            this.resParentColumn,
            this.resStateColumn});
            this.resourcesGridView.Location = new System.Drawing.Point(-4, 0);
            this.resourcesGridView.Name = "resourcesGridView";
            this.resourcesGridView.ReadOnly = true;
            this.resourcesGridView.Size = new System.Drawing.Size(718, 542);
            this.resourcesGridView.TabIndex = 1;
            // 
            // resIdColumn
            // 
            this.resIdColumn.HeaderText = "ID";
            this.resIdColumn.Name = "resIdColumn";
            this.resIdColumn.ReadOnly = true;
            // 
            // resParentColumn
            // 
            this.resParentColumn.HeaderText = "Creator";
            this.resParentColumn.Name = "resParentColumn";
            this.resParentColumn.ReadOnly = true;
            // 
            // resStateColumn
            // 
            this.resStateColumn.HeaderText = "State";
            this.resStateColumn.Name = "resStateColumn";
            this.resStateColumn.ReadOnly = true;
            // 
            // ioTab
            // 
            this.ioTab.BackColor = System.Drawing.SystemColors.Control;
            this.ioTab.Controls.Add(this.button3);
            this.ioTab.Controls.Add(this.textBox3);
            this.ioTab.Controls.Add(this.outputTextBox);
            this.ioTab.Location = new System.Drawing.Point(4, 22);
            this.ioTab.Name = "ioTab";
            this.ioTab.Size = new System.Drawing.Size(717, 540);
            this.ioTab.TabIndex = 4;
            this.ioTab.Text = "Input/Output";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 510);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(587, 20);
            this.textBox3.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(3, 3);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(711, 501);
            this.outputTextBox.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsGroupBox.Controls.Add(this.button4);
            this.controlsGroupBox.Controls.Add(this.button2);
            this.controlsGroupBox.Controls.Add(this.executeCountBox);
            this.controlsGroupBox.Controls.Add(this.button1);
            this.controlsGroupBox.Location = new System.Drawing.Point(743, 34);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(204, 544);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "New Task";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(6, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // executeCountBox
            // 
            this.executeCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeCountBox.Location = new System.Drawing.Point(87, 77);
            this.executeCountBox.Name = "executeCountBox";
            this.executeCountBox.Size = new System.Drawing.Size(111, 20);
            this.executeCountBox.TabIndex = 1;
            this.executeCountBox.Text = "1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start OS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartOSClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(596, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // coreBindingSource
            // 
            this.coreBindingSource.DataSource = typeof(OsModel.Core);
            // 
            // coreBindingSource1
            // 
            this.coreBindingSource1.DataSource = typeof(OsModel.Core);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 590);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.realMachineTab.ResumeLayout(false);
            this.registersGroupBox.ResumeLayout(false);
            this.registersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realMemoryGridView)).EndInit();
            this.virtualMachinesTab.ResumeLayout(false);
            this.processTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).EndInit();
            this.resourceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).EndInit();
            this.ioTab.ResumeLayout(false);
            this.ioTab.PerformLayout();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TabPage realMachineTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage virtualMachinesTab;
        private System.Windows.Forms.TabPage resourceTab;
        private System.Windows.Forms.TabPage ioTab;
        private System.Windows.Forms.TabPage processTab;
        private System.Windows.Forms.DataGridView realMemoryGridView;
        private System.Windows.Forms.GroupBox registersGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label axLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sfLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ptrLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cxLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pcLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl virtualMachineTabControl;
        private System.Windows.Forms.DataGridView processGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox executeCountBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkpointColumn;
        private System.Windows.Forms.DataGridView resourcesGridView;
        private System.Windows.Forms.BindingSource coreBindingSource;
        private System.Windows.Forms.BindingSource coreBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resParentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resStateColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;

    }
}