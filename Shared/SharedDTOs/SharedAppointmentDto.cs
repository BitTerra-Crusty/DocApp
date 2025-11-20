using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Application.DTOs
{
    public enum Status
    {
        Pending,
        Declined,
        Approved
    }

    public class SharedAppointmentDto
    {
        /// <summary>
        /// Represents an appointment between a doctor and a patient in the clinic system.
        /// </summary>

        ///<summary>
        ///Patient Name
        /// </summary>
        public string PatientName { get; set; }

        ///<summary>
        /// Optional description or reason for the appointment.
        /// Example: "Routine check-up", "Follow-up consultation", etc.
        /// </summary>
        [StringLength(500)]
        public string PatientDescription { get; set; }

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

        ///<summary>
        ///Appointment Start Date
        /// </summary>
        public DateTime StartDate { get; set; }

        ///<summary>
        ///Appointment End Date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Current status of the appointment.
        /// Possible values: "Pending", "Confirmed", "Cancelled".
        /// </summary>
        public Status Status { get; set; } = Status.Pending;

    }
}
