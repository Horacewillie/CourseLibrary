using CourseLibrary.API.Entities;
using CourseLibrary.API.Models;
using CourseLibrary.API.Services;
using CourseLibrary.API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;
        private readonly ILogger<AuthorsController> _logger;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository, ILogger<AuthorsController> logger)
        {
            _courseLibraryRepository = courseLibraryRepository ?? 
                throw new ArgumentNullException(nameof(courseLibraryRepository));
            _logger = logger ??
                throw new ArgumentNullException(nameof(logger));
        }
        //public IActionResult GetAuthors()
        //{
        //    var authorsFromRepo = _courseLibraryRepository.GetAuthors();
        //    return Ok(new JsonResult(authorsFromRepo));
        //}

        //With ActionResult, The [ProducesResponseType] attributes Type property
        //can be excluded, because we are returning a specific type
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Author>), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            var authors = _courseLibraryRepository.GetAuthors();
            //create a list based off on the AuthorDto
            var authorsDto = new List<AuthorDto>();
            foreach (var author in authors)
            {
                authorsDto.Add(new AuthorDto()
                {
                    Id = author.Id,
                    Name = $"{author.FirstName} {author.LastName}",
                    MainCategory = author.MainCategory,
                    Age = author.DateOfBirth.GetCurrentAge()
                });
            }
            return Ok(authorsDto);
        }

        [HttpGet("{authorId}")]
        [ProducesResponseType(typeof(Author), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult GetAuthor(Guid authorId)
        {
            try
            {
                var author = _courseLibraryRepository.GetAuthor(authorId);

                if (author  == null)
                {
                    _logger.LogError($"Author with authorId of {authorId} not found.");
                    return NotFound();
                }

                return Ok(author);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            
        }
    }

}
