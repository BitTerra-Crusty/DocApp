using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Application.DTOs
{
    public class SharedUserDto
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

        [EmailAddress]
        public string? Email { get; set; }

        /// <summary>
        /// Contact phone number for the doctor or clinic.
        /// </summary>
        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
