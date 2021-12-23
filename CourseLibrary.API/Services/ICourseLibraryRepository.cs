using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Services
{
    public interface ICourseLibraryRepository
    {
        //Get list of courses based off an author
        IEnumerable<Course> GetCourses(Guid authorId);

        //Get a course based off an author and a course
        Course GetCourse(Guid authorId, Guid courseId);

        //Add a course that belongs to an author
        void AddCourse(Guid authorId, Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(Guid authorId);

        //Get list of authors based off an authorId.
        IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        bool AuthorExists(Guid authorId);
        bool Save();

    }
}
