using prj_LTTQ_BTL.Data.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService()
        {
            _courseRepository = new CourseRepository();
        }
        public void CreateCourse(Guid id, string name, string description, int numberOfLessons, decimal fee)
        {
            _courseRepository.CreateCourse(id, name, description, numberOfLessons, fee);
        }

        public DataRow GetCourseById(Guid id)
        {
            return _courseRepository.GetCourseById(id);
        }
        public DataTable GetCourses(int page, int pageSize)
        {
            return _courseRepository.GetCourses(page, pageSize);
        }
        public void UpdateCourse(Guid id, string name, string description, int numberOfLessons, decimal fee, string status)
        {
            _courseRepository.UpdateCourse(id, name, description, numberOfLessons, fee, status);
        }
        public void DeleteCourse(Guid id)
        {
            _courseRepository.DeleteCourse(id);
        }
        public DataTable SearchCourses(string keyword)
        {
            return _courseRepository.SearchCourses(keyword);
        }
    }
}
