using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        List<GetStudentDto> GetStudents();
    }
}
