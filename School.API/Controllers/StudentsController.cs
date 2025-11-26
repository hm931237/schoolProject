using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Application.Queries.GetStudentById;

namespace School.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<School.Application.DTOs.StudentDto>> GetStudent(int id)
        {
            var query = new GetStudentByIdQuery { Id = id };
            var student = await _mediator.Send(query);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
    }
}
