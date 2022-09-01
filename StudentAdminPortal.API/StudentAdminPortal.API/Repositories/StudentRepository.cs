using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<GetStudentDto>> GetStudents()
        {
            var students =  await _context.Student
                .Select(s => _mapper.Map<GetStudentDto>(s)).ToListAsync();

               return students;
        }
    }
}
