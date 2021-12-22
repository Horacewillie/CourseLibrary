using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Entities
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

        public string MainCategory { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
