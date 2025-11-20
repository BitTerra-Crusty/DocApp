using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class SharedClinicDto
    {

        /// <summary>
        /// Unique identifier of the Clinic.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// clinic name
        /// </summary>
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Clinic’s email address
        /// </summary>
        [EmailAddress]
        public string? Email { get; set; }

        /// <summary?
        ///Clinic's physical address
        ///

        [Required, StringLength(100)]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// What time does the clinic opens
        /// </summary>
        [StringLength(100)]
        public string? OpeningHours { get; set; } // Example: "Mon-Fri 08:00 - 17:00"

        /// <summary>
        /// About the clinic
        /// </summary>
        public string? Description { get; set; }
    }
}
