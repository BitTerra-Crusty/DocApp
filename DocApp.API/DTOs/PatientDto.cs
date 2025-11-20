using DocApp.Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace DocApp.API.DTOs
{
    public class PatientDto : SharedPatientDto
    {
        /// <summary>
        /// Unique identifier of the patient.
        /// </summary>
        public int Id { get; set; }

    }
}
