namespace OsModel.GUI
{
    partial class VirtualMachineTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vmMemoryGridView = new System.Windows.Forms.DataGridView();
            this.nextCommand = new System.Windows.Forms.Label();
            this.nextCommandLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.vmMemoryGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vmMemoryGridView
            // 
            this.vmMemoryGridView.AllowUserToAddRows = false;
            this.vmMemoryGridView.AllowUserToDeleteRows = false;
            this.vmMemoryGridView.AllowUserToOrderColumns = true;
            this.vmMemoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmMemoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vmMemoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vmMemoryGridView.Location = new System.Drawing.Point(0, 0);
            this.vmMemoryGridView.Name = "vmMemoryGridView";
            this.vmMemoryGridView.ReadOnly = true;
            this.vmMemoryGridView.Size = new System.Drawing.Size(674, 355);
            this.vmMemoryGridView.TabIndex = 0;
            // 
            // nextCommand
            // 
            this.nextCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextCommand.AutoSize = true;
            this.nextCommand.Location = new System.Drawing.Point(6, 16);
            this.nextCommand.Name = "nextCommand";
            this.nextCommand.Size = new System.Drawing.Size(85, 13);
            this.nextCommand.TabIndex = 1;
            this.nextCommand.Text = "Next Command: ";
            // 
            // nextCommandLabel
            // 
            this.nextCommandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextCommandLabel.AutoSize = true;
            this.nextCommandLabel.Location = new System.Drawing.Point(97, 16);
            this.nextCommandLabel.Name = "nextCommandLabel";
            this.nextCommandLabel.Size = new System.Drawing.Size(10, 13);
            this.nextCommandLabel.TabIndex = 2;
            this.nextCommandLabel.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nextCommand);
            this.groupBox1.Controls.Add(this.nextCommandLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 38);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // VirtualMachineTab
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vmMemoryGridView);
            this.Size = new System.Drawing.Size(674, 397);
            ((System.ComponentModel.ISupportInitialize)(this.vmMemoryGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vmMemoryGridView;
        private System.Windows.Forms.Label nextCommand;
        private System.Windows.Forms.Label nextCommandLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
