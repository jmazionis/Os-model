﻿using System;
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
        public VirtualMachineTab(VirtualMachineEmulator.VirtualMachine vm, int index)
        {
            this.VM = vm;
            InitializeComponent();
            this.Text = "VM " + (index+1);
            FillMemoryGridView();
            VM.VMTaskFinished += new VirtualMachineEmulator.VMEventHandler(UpdateVmMemoryGridViewGrid);
            VM.VMTaskFinished += new VirtualMachineEmulator.VMEventHandler(UpdateNextCommand);
        }

        private void FillMemoryGridView()
        {
            vmMemoryGridView.Rows.Clear();
            vmMemoryGridView.Columns.Clear();
            for (int i = 0; i < VM.Memory.BlockCount; i++)
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
            for (int i = 0; i < VM.Memory.WordCount; i++)
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
        
        public VirtualMachineEmulator.VirtualMachine VM { get; private set; }
    }
}
