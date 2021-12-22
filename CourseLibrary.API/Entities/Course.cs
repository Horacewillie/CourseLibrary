using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Entities
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        public string  Title { get; set; }

        public string Description { get; set; }
        public string Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
