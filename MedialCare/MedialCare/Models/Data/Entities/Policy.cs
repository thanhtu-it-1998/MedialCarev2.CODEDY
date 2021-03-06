﻿using MedialCare.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Entities
{
    public class Policy
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Company")]
        [Display(Name ="Name Company")]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 9999999999999999999, ErrorMessage = "correlativo no valido")]
        [RegularExpression(@"^(((\d{1})*))$", ErrorMessage = "correlativo no valido")]
        //[Column(TypeName = "decimal(8,2)")]
        public long Amount { get; set; }

        [Range(1, 9999999999999999999, ErrorMessage = "correlativo no valido")]
        [RegularExpression(@"^(((\d{1})*))$", ErrorMessage = "correlativo no valido")]
        //[Column(TypeName = "decimal(8,2)")]
        public long Emi { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public string Version { get; set; }

        public bool Deleted { get; set; }

        public List<PolicyOnEmployee> PolicyOnEmployee { get; set; }
        public List<EmailFormModel> EmailFormModels { get; set; }
        public Company Company { get; set; }

    }
}
