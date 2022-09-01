using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(StudentAdminContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetStudentDto> GetStudents()
        {
            var students =  _context.Student
                .Select(s => _mapper.Map<GetStudentDto>(s)).ToList();
               return students;
        }
    }
}
