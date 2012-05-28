using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OsModel;
using OsModel.Processes;
using OsModel.Resources;

namespace OsModel.GUI
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void UpdateProcesses()
        {
            processGridView.Rows.Clear();
            foreach (Process process in Core.ProcessList)
            {
                DataGridViewRow row = new DataGridViewRow();
                object[] values = new object[5]
                {
                    process.Id,
                    process.State,
                    process.ParentProcess != null ? process.ParentProcess.Id : "none",
                    process.Priority,
                    process.Checkpoint
                };
                processGridView.Rows.Add(row);
                processGridView.Rows[processGridView.Rows.Count - 1].SetValues(values);
            }
        }

        void UpdateResources()
        {
            resourcesGridView.Rows.Clear();
            foreach (Resource resource in Core.ResourcesList)
            {
                DataGridViewRow row = new DataGridViewRow();
                object[] values = new object[3]
                {
                    resource.Id,
                    resource.Creator.Id,
                    resource.State
                };
                resourcesGridView.Rows.Add(row);
                resourcesGridView.Rows[resourcesGridView.Rows.Count - 1].SetValues(values);
            }
        }

        private void FillRealMemoryGrid()
        {
            realMemoryGridView.Rows.Clear();
            realMemoryGridView.Columns.Clear();
            for (int i = 0; i < RealMachine.Memory.WordCount; i++)
            {
                realMemoryGridView.Columns.Add(i.ToString("X"), i.ToString("X"));
                realMemoryGridView.Columns[i].DisplayIndex = i;
            }
            for (int i = 0; i < RealMachine.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[RealMachine.Memory.WordCount];
                for (int j = 0; j < RealMachine.Memory.WordCount; j++)
                {
                    if (!(RealMachine.Memory[i, j].ToString() == "----"))
                        rowValues[j] = RealMachine.Memory[i, j].ToString();
                }
                realMemoryGridView.Rows.Add(rowValues);
                realMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void UpdateRealMemoryGrid()
        {
            for (int i = 0; i < RealMachine.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[RealMachine.Memory.WordCount];
                for (int j = 0; j < RealMachine.Memory.WordCount; j++)
                {
                    if (!(RealMachine.Memory[i, j].ToString() == "----"))
                        rowValues[j] = RealMachine.Memory[i, j].ToString();
                }
                realMemoryGridView.Rows[i].SetValues(rowValues);
                realMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void UpdateRegisters()
        {
            axLabel.Text = Cpu.Registers.AX.Value;
            cxLabel.Text = Cpu.Registers.CX.Value;
            pcLabel.Text = Cpu.Registers.PC.ToString("X");
            ptrLabel.Text = Cpu.PTR.ToString("X");
            modeLabel.Text = Cpu.Registers.MODE.ToString();
            sfLabel.Text = Cpu.Registers.SF.ToString("X");


        }

        private void AddVirtualMachine(VirtualMachineEmulator.VirtualMachine vm)
        {
            virtualMachineTabControl.Controls.Add(new VirtualMachineTab(vm, virtualMachineTabControl.Controls.Count, this.outputTextBox));
        }

        private void StartOSClick(object sender, EventArgs e)
        {
            Core.StartOS();
            Planner.ProcessExecuted += new OSEventHandler(UpdateProcesses);
            Planner.ProcessExecuted += new OSEventHandler(UpdateResources);
            Planner.ProcessExecuted += new OSEventHandler(UpdateRealMemoryGrid);
            Planner.ProcessExecuted += new OSEventHandler(UpdateRegisters);
            AddVirtualMachine(new VirtualMachineEmulator.VirtualMachine(@"Tasks\Loop10.txt"));
            AddVirtualMachine(new VirtualMachineEmulator.VirtualMachine(@"Tasks\Loop5.txt"));
            AddVirtualMachine(new VirtualMachineEmulator.VirtualMachine(@"Tasks\Loop3.txt"));
            FillRealMemoryGrid();
            UpdateRegisters();
            UpdateProcesses();
            UpdateResources();
            tabControl.Visible = true;
            tabControl.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Int32.Parse(executeCountBox.Text); i++)
                Core.ExecuteNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (this.virtualMachineTabControl.Controls.Count < 3)
                    ;//TODO: Add VM to OS
            }
        }

    }
}
