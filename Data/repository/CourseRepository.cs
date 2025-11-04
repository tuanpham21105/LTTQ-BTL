using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class CourseRepository : BaseRepository
    {
        public void CreateCourse(Guid id, string name, string description, int numberOfLessons, decimal fee)
        {
            string query = $@"
                INSERT INTO Course (id, name, description, number_of_lessons, fee)
                VALUES ('{id}', N'{name}', N'{description}', {numberOfLessons}, {fee})
            ";
            UpdateData(query);
        }

        public DataRow GetCourseById(Guid id)
        {
            string query = $"SELECT * FROM Course WHERE id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }

        public DataTable GetCourses(int page, int pageSize)
        {
            string query;

            if (page == -1)
            {
                query = "SELECT * FROM Course ORDER BY name";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                query = $@"
                    SELECT * 
                    FROM Course
                    ORDER BY name
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY
                ";
            }
            return GetDataTable(query);
        }

        public void UpdateCourse(Guid id, string name, string description, int numberOfLessons, decimal fee)
        {
            string query = $@"
                UPDATE Course
                SET name = N'{name}',
                    description = N'{description}',
                    number_of_lessons = {numberOfLessons},
                    fee = {fee}
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }

        public void DeleteCourse(Guid id)
        {
            string query = $"DELETE FROM Course WHERE id = '{id}'";
            UpdateData(query);
        }

        public DataTable SearchCourses(string keyword)
        {
            string query = $@"
                SELECT * 
                FROM Course
                WHERE name LIKE N'%{keyword}%' OR description LIKE N'%{keyword}%'
                ORDER BY name
            ";
            return GetDataTable(query);
        }
    }
}
