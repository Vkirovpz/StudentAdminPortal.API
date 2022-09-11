using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<GetStudentDto>> GetStudentsAsync();
        Task<GetStudentDto> GetStudentAsync(Guid studentId);
        Task<List<GetGenderDto>> GetGendersAsync();
        Task<bool> Exist(Guid studentId);
    }
}
