using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School.Application.DTOs;
using School.Persistence.Data;

namespace School.Application.Queries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, StudentDto>
    {
        private readonly StudentDbContext _context;
        private readonly IMapper _mapper;

        public GetStudentByIdQueryHandler(StudentDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<StudentDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _context.Students.FindAsync(request.Id);
            return _mapper.Map<StudentDto>(student);
        }
    }
}
