using MediatR;
using School.Application.DTOs;

namespace School.Application.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<StudentDto>
    {
        public int Id { get; set; }
    }
}
