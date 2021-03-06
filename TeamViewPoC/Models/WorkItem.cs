﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamViewPoC.Models
{

    public class WorkItem:IWorkItem
    {
        public int WorkItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public bool Complete { get; set; }
        public string AssignedTo { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
        public virtual IEnumerable<Note>Notes { get; set; }
        public Project Project { get; set; }




    }
}
