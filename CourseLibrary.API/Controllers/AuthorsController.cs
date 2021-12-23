using CourseLibrary.API.Entities;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepositroy;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            _courseLibraryRepositroy = courseLibraryRepository ?? 
                throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        //public IActionResult GetAuthors()
        //{
        //    var authorsFromRepo = _courseLibraryRepository.GetAuthors();
        //    return Ok(new JsonResult(authorsFromRepo));
        //}
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Author>),(int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            var authors = _courseLibraryRepositroy.GetAuthors();
            return Ok(new JsonResult(authors));
        }
    }

}
