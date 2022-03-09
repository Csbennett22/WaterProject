using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WaterProject.Models
{
    public partial class Project
    {
        [Key]
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectRegionalProgram { get; set; } //this question mark means that this can be a nullible field
        public int ProjectImpact { get; set; }
        public string ProjectPhase { get; set; }
        public string ProjectFunctionalityStatus { get; set; }
    }
}
