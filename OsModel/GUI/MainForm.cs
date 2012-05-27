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

namespace OsModel
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Planner.ProcessExecuted += new OSEventHandler(UpdateProcesses);
            Planner.ProcessExecuted += new OSEventHandler(UpdateResources);
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

        private void StartOSClick(object sender, EventArgs e)
        {
            Core.StartOS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Int32.Parse(executeCountBox.Text); i++)
                Core.ExecuteNext();
        }

    }
}
