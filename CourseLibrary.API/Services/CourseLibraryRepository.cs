﻿using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Services
{
    public class CourseLibraryRepository : ICourseLibraryRepository
    {
        void ICourseLibraryRepository.AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        void ICourseLibraryRepository.AddCourse(Guid authorId, Course course)
        {
            throw new NotImplementedException();
        }

        bool ICourseLibraryRepository.AuthorExists(Guid authorId)
        {
            throw new NotImplementedException();
        }

        void ICourseLibraryRepository.DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        void ICourseLibraryRepository.DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        Author ICourseLibraryRepository.GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Author> ICourseLibraryRepository.GetAuthors()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Author> ICourseLibraryRepository.GetAuthors(IEnumerable<Guid> authorIds)
        {
            throw new NotImplementedException();
        }

        Course ICourseLibraryRepository.GetCourse(Guid authorId, Guid courseId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Course> ICourseLibraryRepository.GetCourses(Guid authorId)
        {
            throw new NotImplementedException();
        }

        bool ICourseLibraryRepository.Save()
        {
            throw new NotImplementedException();
        }

        void ICourseLibraryRepository.UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        void ICourseLibraryRepository.UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
