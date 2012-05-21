﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii;
using Ookii.Collections.Generic;
using OsModel.Comparers;
using OsModel.Resources;

namespace OsModel.Processes
{
    public enum State { Blocked, Ready, Active }

    public abstract class Process
    {
        public int Id { get; set; }   

        public State State { get; set; }
        public int Priority { get; set; }
        public Registers Registers { get; set; }
        public List<Resource> CreatedResources { get; set; }
        public List<Process> CreatedProcesses { get; set; }
        public Process ParentProcess { get; set; }

        public Process(int priority, State state, Process parentProcess, int id)
        {
            Id = id;
            Priority = priority;
            State = state;
            ParentProcess = parentProcess;
            CreatedProcesses = new List<Process>();
            CreatedResources = new List<Resource>();
        }

        public void Execute()
        {
            //TODO: complete implementation
        }

        public void CreateResource(Resource resource)
        {
            CreatedResources.Add(resource);
            Core.ResourcesList.Add(resource);
        }

        public void RequestResource(Resource resource)
        {
            State = Processes.State.Blocked;
        }

        public void Delete()
        {
            CreatedResources.Clear();
            foreach (Process proc in CreatedProcesses)
                proc.Delete();
            CreatedProcesses.Clear();
        }

    }
}
