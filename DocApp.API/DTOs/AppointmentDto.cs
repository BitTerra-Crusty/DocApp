using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class AppointmentDto
    {
        /// <summary>
        /// Represents an appointment between a doctor and a patient in the clinic system.
        /// </summary>
     
        /// <summary>
        /// Unique identifier for the appointment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifier for the doctor associated with the appointment.
        /// Links to the Doctor entity.
        /// </summary>
        [Required]
        public int DoctorId { get; set; }

        /// <summary>
        /// Identifier for the patient who booked the appointment.
        /// Links to the Patient entity.
        /// </summary>
        [Required]
        public int PatientId { get; set; }

        /// <summary>
        /// Date and time when the appointment is scheduled to occur.
        /// </summary>
        [Required]
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// Optional description or reason for the appointment.
        /// Example: "Routine check-up", "Follow-up consultation", etc.
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// Current status of the appointment.
        /// Possible values: "Pending", "Confirmed", "Cancelled".
        /// </summary>
        public string Status { get; set; } = "Pending";
        
}
