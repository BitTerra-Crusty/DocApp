using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Application.DTOs
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public class SharedPatientDto
    {
        /// <summary>
        /// Patient's first name.
        /// </summary>
        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Patient's last name.
        /// </summary>
        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Date of birth (used for calculating patient age).
        /// </summary>
        [Required]
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Gender of the patient (Male, Female, or Other).
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        /// <summary>
        /// Patient’s residential or contact address.
        /// </summary>
        [StringLength(200)]
        public string? Address { get; set; }

        /// <summary>
        /// South African ID number or passport number.
        /// </summary>
        [Required, StringLength(20, MinimumLength = 6)]
        public string IdNumber { get; set; } = string.Empty;

        /// <summary>
        /// Patient’s email address (optional).
        /// </summary>
        [EmailAddress]
        public string? Email { get; set; }
    }
}
