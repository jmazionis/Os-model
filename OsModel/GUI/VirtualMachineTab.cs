using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OsModel.GUI
{
    public partial class VirtualMachineTab : TabPage
    {
        public VirtualMachineEmulator.VirtualMachine VM { get; private set; }
        private TextBox outputBox;

        public VirtualMachineTab(VirtualMachineEmulator.VirtualMachine vm, int index, TextBox outputBox)
        {
            this.outputBox = outputBox;
            this.VM = vm;
            InitializeComponent();
            this.Text = "VM " + (index+1);
            FillMemoryGridView();
            VM.Cpu.CommandExecuted += new VirtualMachineEmulator.VMEventHandler(UpdateVmMemoryGridViewGrid);
            VM.Cpu.CommandExecuted += new VirtualMachineEmulator.VMEventHandler(UpdateNextCommand);
            VM.Io.OutputRequested += new VirtualMachineEmulator.VMEventHandler(PrintBuffer);
            vm.VMTaskFinished += new VirtualMachineEmulator.VMEventHandler(this.Dispose);
            UpdateNextCommand();
            //VM.ExecuteAll();
        }

        private void FillMemoryGridView()
        {
            vmMemoryGridView.Rows.Clear();
            vmMemoryGridView.Columns.Clear();
            for (int i = 0; i < VM.Memory.WordCount; i++)
            {
                vmMemoryGridView.Columns.Add(i.ToString("X"), i.ToString("X"));
                vmMemoryGridView.Columns[i].DisplayIndex = i;
            }
            for (int i = 0; i < VM.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[VM.Memory.WordCount];
                for (int j = 0; j < VM.Memory.WordCount; j++)
                {
                    if (!(VM.Memory[i, j].ToString() == "----"))
                        rowValues[j] = VM.Memory[i, j].ToString();
                }
                vmMemoryGridView.Rows.Add(rowValues);
                vmMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void UpdateVmMemoryGridViewGrid()
        {
            for (int i = 0; i < VM.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[VM.Memory.WordCount];
                for (int j = 0; j < VM.Memory.WordCount; j++)
                {
                    if (!(VM.Memory[i, j].ToString() == "----"))
                        rowValues[j] = VM.Memory[i, j].ToString();
                }
                vmMemoryGridView.Rows[i].SetValues(rowValues);
                vmMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void UpdateNextCommand()
        {
            nextCommandLabel.Text = VM.Cpu.NextCommand();
        }

        private void PrintBuffer()
        {
            outputBox.Text += VM.Io.Buffer;
            outputBox.Text += "\r\n";
        }

        private void executeAsProcButton_Click(object sender, EventArgs e)
        {
            this.VM.ExecuteAsProcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.VM.ExecuteNext();
        }
        
        
    }
}
