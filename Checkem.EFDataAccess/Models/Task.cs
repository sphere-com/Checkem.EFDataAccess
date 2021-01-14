using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public bool IsComplteted { get; set; }
        public bool IsStarred { get; set; }
        public bool IsInMyDay { get; set; }
        public DateTime BeginDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
