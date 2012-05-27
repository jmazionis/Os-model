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
                    process.ParentProcess != null ? process.ParentProcess.GetType().Name + " {" + process.ParentProcess.Id + "}" : "none",
                    process.Priority,
                    process.Checkpoint
                };
                row.SetValues(values);
                processGridView.Rows.Add(row);
            }
            processGridView.Sort(processGridView.Columns[1], ListSortDirection.Ascending);
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
                    resource.Creator.GetType().Name + " {" + resource.Creator.Id + "}",
                    resource.State
                };
                row.SetValues(values);
                resourcesGridView.Rows.Add(row);
            }
        }

        private void StartOSClick(object sender, EventArgs e)
        {
            Core.StartOperatingSystem();
        }

    }
}
