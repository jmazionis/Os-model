namespace OsModel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.realMachineTab = new System.Windows.Forms.TabPage();
            this.registersGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.realMemory = new System.Windows.Forms.DataGridView();
            this.virtualMachinesTab = new System.Windows.Forms.TabPage();
            this.processTab = new System.Windows.Forms.TabPage();
            this.resourceTab = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.realMachineTab.SuspendLayout();
            this.registersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realMemory)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.realMachineTab);
            this.tabControl1.Controls.Add(this.virtualMachinesTab);
            this.tabControl1.Controls.Add(this.processTab);
            this.tabControl1.Controls.Add(this.resourceTab);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // realMachineTab
            // 
            this.realMachineTab.BackColor = System.Drawing.SystemColors.Control;
            this.realMachineTab.Controls.Add(this.registersGroupBox);
            this.realMachineTab.Controls.Add(this.realMemory);
            this.realMachineTab.Location = new System.Drawing.Point(4, 22);
            this.realMachineTab.Name = "realMachineTab";
            this.realMachineTab.Size = new System.Drawing.Size(811, 480);
            this.realMachineTab.TabIndex = 0;
            this.realMachineTab.Text = "Real Machine";
            // 
            // registersGroupBox
            // 
            this.registersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registersGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.registersGroupBox.Controls.Add(this.label13);
            this.registersGroupBox.Controls.Add(this.label14);
            this.registersGroupBox.Controls.Add(this.label11);
            this.registersGroupBox.Controls.Add(this.label12);
            this.registersGroupBox.Controls.Add(this.label9);
            this.registersGroupBox.Controls.Add(this.label10);
            this.registersGroupBox.Controls.Add(this.label7);
            this.registersGroupBox.Controls.Add(this.label8);
            this.registersGroupBox.Controls.Add(this.label5);
            this.registersGroupBox.Controls.Add(this.label6);
            this.registersGroupBox.Controls.Add(this.label3);
            this.registersGroupBox.Controls.Add(this.label4);
            this.registersGroupBox.Controls.Add(this.label2);
            this.registersGroupBox.Controls.Add(this.label1);
            this.registersGroupBox.Location = new System.Drawing.Point(6, 422);
            this.registersGroupBox.Name = "registersGroupBox";
            this.registersGroupBox.Size = new System.Drawing.Size(801, 57);
            this.registersGroupBox.TabIndex = 1;
            this.registersGroupBox.TabStop = false;
            this.registersGroupBox.Text = "Registers";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Info;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "PC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(339, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "PC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(734, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "TIME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(681, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "TIME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "MODE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "MODE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "SF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "SF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PTR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "PTR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "CX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "AX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AX";
            // 
            // realMemory
            // 
            this.realMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realMemory.Enabled = false;
            this.realMemory.Location = new System.Drawing.Point(3, 3);
            this.realMemory.Name = "realMemory";
            this.realMemory.Size = new System.Drawing.Size(805, 413);
            this.realMemory.TabIndex = 0;
            // 
            // virtualMachinesTab
            // 
            this.virtualMachinesTab.BackColor = System.Drawing.SystemColors.Control;
            this.virtualMachinesTab.Location = new System.Drawing.Point(4, 22);
            this.virtualMachinesTab.Name = "virtualMachinesTab";
            this.virtualMachinesTab.Size = new System.Drawing.Size(811, 480);
            this.virtualMachinesTab.TabIndex = 1;
            this.virtualMachinesTab.Text = "Virtual Machines";
            // 
            // processTab
            // 
            this.processTab.BackColor = System.Drawing.SystemColors.Control;
            this.processTab.Location = new System.Drawing.Point(4, 22);
            this.processTab.Name = "processTab";
            this.processTab.Size = new System.Drawing.Size(811, 480);
            this.processTab.TabIndex = 2;
            this.processTab.Text = "Processes";
            // 
            // resourceTab
            // 
            this.resourceTab.BackColor = System.Drawing.SystemColors.Control;
            this.resourceTab.Location = new System.Drawing.Point(4, 22);
            this.resourceTab.Name = "resourceTab";
            this.resourceTab.Size = new System.Drawing.Size(811, 480);
            this.resourceTab.TabIndex = 3;
            this.resourceTab.Text = "Resources";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(811, 480);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsGroupBox.Controls.Add(this.button1);
            this.controlsGroupBox.Location = new System.Drawing.Point(837, 34);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(204, 484);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start OS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 530);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.realMachineTab.ResumeLayout(false);
            this.registersGroupBox.ResumeLayout(false);
            this.registersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realMemory)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TabPage realMachineTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage virtualMachinesTab;
        private System.Windows.Forms.TabPage resourceTab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage processTab;
        private System.Windows.Forms.DataGridView realMemory;
        private System.Windows.Forms.GroupBox registersGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

    }
}