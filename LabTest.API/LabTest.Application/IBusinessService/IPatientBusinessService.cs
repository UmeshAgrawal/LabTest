using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LabTest.Application.DTO;

namespace LabTest.Application.IBusinessService
{
    public interface IPatientBusinessService
    {
        /// <summary>
        /// Declaration of Add/Update Patient method
        /// </summary>
        /// <param name="patient">Model to add/update</param>
        /// <returns>status</returns>
        Task<string> SavePatient(AddPatientDTO patient, string action);

        /// <summary>
        /// Declaration of  Delete record based on filter method
        /// </summary>
        /// <param name="Id">filter record to delete based on Id</param>
        /// <returns>status</returns>
        Task<string> DeletePatient(int Id);

        /// <summary>
        /// Declaration of  Get all the reports based on filters or all if all null method
        /// </summary>
        /// <param name="Id">Filter to fetch report based on patient Id</param>
        /// <returns>Colletion of GetPatientDTO</returns>
        Task<List<GetPatientDTO>> GetPatients(int Id = 0);

        /// <summary>
        /// Declaration of Get all the records based on the filters or all method
        /// </summary>
        /// <param name="patientId">Filter to fetch report based on patientId</param>
        /// <param name="startDate">Filter to fetch report based on startDate</param>
        /// <param name="endDate">Filter to fetch report based on endDate</param>
        /// <returns>Collection of PatientReportDTO</returns>
        Task<List<GetPatientReportDTO>> GetPatientWithReport(int? patientId, DateTime? startDate, DateTime? endDate);
    }
}
