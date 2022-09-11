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

        public async Task<GetStudentDto> GetStudentAsync(Guid studentId)
        {
            var student = await _context.Student
                .Include(s => s.Gender)
                .Include(s => s.Address)
                .FirstOrDefaultAsync(s => s.Id == studentId);

            var studetToReturn = _mapper.Map<GetStudentDto>(student);

            return studetToReturn;
        }

        public async Task<List<GetStudentDto>> GetStudentsAsync()
        {
            var students =  await _context.Student
                .Include(s => s.Gender)
                .Include(s => s.Address)
                .ToListAsync();

            var studentsFullInfo = students
                .Select(s => _mapper.Map<GetStudentDto>(s)).ToList();

               return studentsFullInfo;
        }

        public async Task<List<GetGenderDto>> GetGendersAsync()
        {
            return await _context.Gender
                .Select(g => _mapper.Map<GetGenderDto>(g))
                .ToListAsync();
        }
    }
}
