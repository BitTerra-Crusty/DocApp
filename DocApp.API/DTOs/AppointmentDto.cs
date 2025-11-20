using DocApp.Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class AppointmentDto : SharedAppointmentDto
    {
        /// <summary>
        /// Unique identifier for the appointment.
        /// </summary>
        public int Id { get; set; }

    }
}
