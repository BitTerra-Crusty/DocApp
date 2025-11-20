using DocApp.Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class DoctorDto : SharedDoctorDto
    {
        /// <summary>
        /// Unique identifier for the doctor.
        /// </summary>
        public int Id { get; set; }
    }
}
