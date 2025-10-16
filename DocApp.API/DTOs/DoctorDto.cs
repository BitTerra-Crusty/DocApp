using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class DoctorDto
    {
        /// <summary>
        /// Unique identifier for the doctor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Doctor's first name.
        /// </summary>
        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Doctor's last name.
        /// </summary>
        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// The main specialization or field of practice (e.g., General Practitioner, Dentist, Surgeon).
        /// </summary>
        [Required, StringLength(100)]
        public string Specialization { get; set; } = string.Empty;

        /// <summary>
        /// Contact email address.
        /// </summary>
        [EmailAddress]
        public string? Email { get; set; }

        /// <summary>
        /// Contact phone number for the doctor or clinic.
        /// </summary>
        [Phone]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Optional notes or description (e.g., “Available for morning appointments only”).
        /// </summary>
        [StringLength(250)]
        public string? Notes { get; set; }

    }
}
