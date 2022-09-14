﻿namespace LMS20.Core.Entities
{
    public class ModuleActivity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        //public string Type { get; set; } = string.Empty; //Antingen Lecture eller Task OBS Ny
         
        public ICollection<Document> Documents { get; set; } = new List<Document>();

        public Module Module { get; set; }

        public int ModuleId { get; set; }
    }
}
