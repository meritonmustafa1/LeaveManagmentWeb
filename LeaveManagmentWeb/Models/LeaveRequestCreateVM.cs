﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagmentWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name ="Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes{ get; set; }
        [Display(Name="Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The start date must be before End Date", new[] {nameof(StartDate), nameof(EndDate)});
            }
            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long ", new[] { nameof(RequestComments)}); ;
            }
        }
    }
}
