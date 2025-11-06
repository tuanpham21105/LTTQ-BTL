using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class DashboardRepository : BaseRepository
    {
        public int GetTotalStudentCount()
        {
            string query = "SELECT COUNT(*) AS TotalStudents FROM Student";
            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalStudents"]);
            }
            return 0;
        }
        public int GetTotalTeacherCount()
        {
            string query = "SELECT COUNT(*) AS TotalTeachers FROM Teacher";
            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalTeachers"]);
            }
            return 0;
        }
        public int GetTotalClassCount()
        {
            string query = "SELECT COUNT(*) AS TotalClass FROM Class";
            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalClass"]);
            }
            return 0;
        }
        public int GetTotalCourseCount()
        {
            string query = "SELECT COUNT(*) AS TotalCourses FROM Course";
            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalCourses"]);
            }
            return 0;
        }
        public decimal GetTotalRevenueByDate(DateTime date)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE CAST(P.payment_date AS DATE) = '{date:yyyy-MM-dd}'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year} AND MONTH(P.payment_date) = {month}";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year}";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public decimal GetPaidRevenueByDate(DateTime date)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE CAST(P.payment_date AS DATE) = '{date:yyyy-MM-dd}' AND P.status = 'Paid'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }

        public decimal GetPaidRevenueByMonth(int year, int month)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year} AND MONTH(P.payment_date) = {month} AND P.status = 'Paid'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }

        public decimal GetPaidRevenueByYear(int year)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year} AND P.status = 'Paid'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public decimal GetPendingRevenueByDate(DateTime date)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE CAST(P.payment_date AS DATE) = '{date:yyyy-MM-dd}' AND P.status = 'Pending'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }

        public decimal GetPendingRevenueByMonth(int year, int month)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year} AND MONTH(P.payment_date) = {month} AND P.status = 'Pending'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public decimal GetPendingRevenueByYear(int year)
        {
            string query = $@"
                SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
                FROM Payment P
                WHERE YEAR(P.payment_date) = {year} AND P.status = 'Pending'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalRevenue"]);
            }

            return 0;
        }
        public int GetEnrollmentCountByDate(DateTime date)
        {
            string query = $@"
                SELECT COUNT(*) AS TotalEnrollments
                FROM Enrollment
                WHERE CAST(enrollment_date AS DATE) = '{date:yyyy-MM-dd}'";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalEnrollments"]);
            }

            return 0;
        }

        public int GetEnrollmentCountByMonth(int year, int month)
        {
            string query = $@"
                SELECT COUNT(*) AS TotalEnrollments
                FROM Enrollment
                WHERE YEAR(enrollment_date) = {year} AND MONTH(enrollment_date) = {month}";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalEnrollments"]);
            }

            return 0;
        }

        public int GetEnrollmentCountByYear(int year)
        {
            string query = $@"
                SELECT COUNT(*) AS TotalEnrollments
                FROM Enrollment
                WHERE YEAR(enrollment_date) = {year}";

            DataTable result = GetDataTable(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TotalEnrollments"]);
            }

            return 0;
        }
        public DataTable GetEnrollmentByCourseAndDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    C.name AS CourseName,
                    COUNT(E.id) AS TotalEnrollments
                FROM Course C
                LEFT JOIN Enrollment E ON C.id = E.course_id AND CAST(E.enrollment_date AS DATE) = '{date:yyyy-MM-dd}'
                GROUP BY C.name
                ORDER BY TotalEnrollments DESC";

            return GetDataTable(query);
        }
        public DataTable GetEnrollmentByCourseAndMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    C.name AS CourseName,
                    COUNT(E.id) AS TotalEnrollments
                FROM Course C
                LEFT JOIN Enrollment E ON C.id = E.course_id AND YEAR(E.enrollment_date) = {year} AND MONTH(E.enrollment_date) = {month}
                GROUP BY C.name
                ORDER BY TotalEnrollments DESC";

            return GetDataTable(query);
        }
        public DataTable GetEnrollmentByCourseAndYear(int year)
        {
            string query = $@"
                SELECT 
                    C.name AS CourseName,
                    COUNT(E.id) AS TotalEnrollments
                FROM Course C
                LEFT JOIN Enrollment E ON C.id = E.course_id AND YEAR(E.enrollment_date) = {year}
                GROUP BY C.name
                ORDER BY TotalEnrollments DESC";
            return GetDataTable(query);
        }
        //public DataTable GetAttendanceReportOfClassByDate(Guid classId, DateTime date)
        //{
        //    string query = $@"
        //        SELECT 
        //            S.session_date AS SessionDate,
        //            COUNT(A.student_id) AS TotalStudents,
        //            SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
        //            SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
        //            SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
        //            SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
        //        FROM Schedule S
        //        LEFT JOIN Attendance A ON S.id = A.schedule_id
        //        WHERE S.class_id = '{classId}' AND CAST(S.session_date AS DATE) = '{date:yyyy-MM-dd}'
        //        GROUP BY S.session_date";

        //    return GetDataTable(query);
        //}

        //public DataTable GetAttendanceReportOfClassByMonth(Guid classId, int year, int month)
        //{
        //    string query = $@"
        //        SELECT 
        //            FORMAT(S.session_date, 'yyyy-MM') AS Month,
        //            COUNT(A.student_id) AS TotalStudents,
        //            SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
        //            SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
        //            SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
        //            SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
        //        FROM Schedule S
        //        LEFT JOIN Attendance A ON S.id = A.schedule_id
        //        WHERE S.class_id = '{classId}' AND YEAR(S.session_date) = {year} AND MONTH(S.session_date) = {month}
        //        GROUP BY FORMAT(S.session_date, 'yyyy-MM')";

        //    return GetDataTable(query);
        //}

        //public DataTable GetAttendanceReportOfClassByYear(Guid classId, int year)
        //{
        //    string query = $@"
        //        SELECT 
        //            YEAR(S.session_date) AS Year,
        //            COUNT(A.student_id) AS TotalStudents,
        //            SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
        //            SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
        //            SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
        //            SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
        //        FROM Schedule S
        //        LEFT JOIN Attendance A ON S.id = A.schedule_id
        //        WHERE S.class_id = '{classId}' AND YEAR(S.session_date) = {year}
        //        GROUP BY YEAR(S.session_date)";

        //    return GetDataTable(query);
        //}
        public DataTable GetAttendanceStatusByDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    COUNT(A.student_id) AS TotalStudents,
                    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
                    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
                    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
                    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
                FROM Class C
                LEFT JOIN Schedule S ON C.id = S.class_id AND CAST(S.session_date AS DATE) = '{date:yyyy-MM-dd}'
                LEFT JOIN Attendance A ON S.id = A.schedule_id
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }
        public DataTable GetAttendanceStatusByMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    COUNT(A.student_id) AS TotalStudents,
                    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
                    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
                    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
                    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
                FROM Class C
                LEFT JOIN Schedule S ON C.id = S.class_id AND YEAR(S.session_date) = {year} AND MONTH(S.session_date) = {month}
                LEFT JOIN Attendance A ON S.id = A.schedule_id
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }

        public DataTable GetAttendanceStatusByYear(int year)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    COUNT(A.student_id) AS TotalStudents,
                    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
                    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
                    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
                    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
                FROM Class C
                LEFT JOIN Schedule S ON C.id = S.class_id AND YEAR(S.session_date) = {year}
                LEFT JOIN Attendance A ON S.id = A.schedule_id
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }
        public DataTable GetScoreReportByDate(Guid classId, DateTime date)
        {
            string query = $@"
                SELECT 
                    ISNULL(COUNT(*), 0) AS TotalScores,
                    ISNULL(SUM(CASE WHEN score >= 9 THEN 1 ELSE 0 END), 0) AS N'Xuất sắc',
                    ISNULL(SUM(CASE WHEN score >= 7 AND score < 9 THEN 1 ELSE 0 END), 0) AS N'Tốt',
                    ISNULL(SUM(CASE WHEN score >= 5 AND score < 7 THEN 1 ELSE 0 END), 0) AS N'Trung bình',
                    ISNULL(SUM(CASE WHEN score < 5 THEN 1 ELSE 0 END), 0) AS N'Yếu'
                FROM Score
                WHERE class_id = '{classId}' AND CAST(created_date AS DATE) = '{date:yyyy-MM-dd}'";

            return GetDataTable(query);
        }

        public DataTable GetScoreReportByMonth(Guid classId, int year, int month)
        {
            string query = $@"
                SELECT 
                    ISNULL(COUNT(*), 0) AS TotalScores,
                    ISNULL(SUM(CASE WHEN score >= 9 THEN 1 ELSE 0 END), 0) AS N'Xuất sắc',
                    ISNULL(SUM(CASE WHEN score >= 7 AND score < 9 THEN 1 ELSE 0 END), 0) AS N'Tốt',
                    ISNULL(SUM(CASE WHEN score >= 5 AND score < 7 THEN 1 ELSE 0 END), 0) AS N'Trung bình',
                    ISNULL(SUM(CASE WHEN score < 5 THEN 1 ELSE 0 END), 0) AS N'Yếu'
                FROM Score
                WHERE class_id = '{classId}' AND YEAR(created_date) = {year} AND MONTH(created_date) = {month}";

            return GetDataTable(query);
        }
        public DataTable GetScoreReportByYear(Guid classId, int year)
        {
            string query = $@"
                SELECT 
                    ISNULL(COUNT(*), 0) AS TotalScores,
                    ISNULL(SUM(CASE WHEN score >= 9 THEN 1 ELSE 0 END), 0) AS N'Xuất sắc',
                    ISNULL(SUM(CASE WHEN score >= 7 AND score < 9 THEN 1 ELSE 0 END), 0) AS N'Tốt',
                    ISNULL(SUM(CASE WHEN score >= 5 AND score < 7 THEN 1 ELSE 0 END), 0) AS N'Trung bình',
                    ISNULL(SUM(CASE WHEN score < 5 THEN 1 ELSE 0 END), 0) AS N'Yếu'
                FROM Score
                WHERE class_id = '{classId}' AND YEAR(created_date) = {year}";

            return GetDataTable(query);
        }

        public DataTable GetAverageScoreByClassAndDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    ISNULL(AVG(S.score), 0) AS AverageScore
                FROM Class C
                LEFT JOIN Score S ON C.id = S.class_id AND CAST(S.created_date AS DATE) = '{date:yyyy-MM-dd}'
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }

        public DataTable GetAverageScoreByClassAndMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    ISNULL(AVG(S.score), 0) AS AverageScore
                FROM Class C
                LEFT JOIN Score S ON C.id = S.class_id AND YEAR(S.created_date) = {year} AND MONTH(S.created_date) = {month}
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }

        public DataTable GetAverageScoreByClassAndYear(int year)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    ISNULL(AVG(S.score), 0) AS AverageScore
                FROM Class C
                LEFT JOIN Score S ON C.id = S.class_id AND YEAR(S.created_date) = {year}
                GROUP BY C.name
                ORDER BY C.name";

            return GetDataTable(query);
        }
        public DataTable GetAllClasses()
        {
            string query = @"
            SELECT 
                id AS ClassId,
                name AS ClassName
            FROM Class
            ORDER BY name";

            return GetDataTable(query);
        }
        public DataTable GetPaymentDetailsByDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    P.payment_date AS PaymentDate,
                    P.amount AS Amount,
                    P.status AS Status
                FROM Payment P
                JOIN Enrollment E ON P.enrollment_id = E.id
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE CAST(P.payment_date AS DATE) = '{date:yyyy-MM-dd}'
                ORDER BY P.payment_date DESC";

            return GetDataTable(query);
        }

        public DataTable GetPaymentDetailsByMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    P.payment_date AS PaymentDate,
                    P.amount AS Amount,
                    P.status AS Status
                FROM Payment P
                JOIN Enrollment E ON P.enrollment_id = E.id
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE YEAR(P.payment_date) = {year} AND MONTH(P.payment_date) = {month}
                ORDER BY P.payment_date DESC";

            return GetDataTable(query);
        }

        public DataTable GetPaymentDetailsByYear(int year)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    P.payment_date AS PaymentDate,
                    P.amount AS Amount,
                    P.status AS Status
                FROM Payment P
                JOIN Enrollment E ON P.enrollment_id = E.id
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE YEAR(P.payment_date) = {year}
                ORDER BY P.payment_date DESC";
            return GetDataTable(query);
        }
        public DataTable GetEnrollmentDetailsByDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    E.enrollment_date AS EnrollmentDate
                FROM Enrollment E
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE CAST(E.enrollment_date AS DATE) = '{date:yyyy-MM-dd}'
                ORDER BY E.enrollment_date DESC";
            return GetDataTable(query);
        }
        public DataTable GetEnrollmentDetailsByMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    E.enrollment_date AS EnrollmentDate
                FROM Enrollment E
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE YEAR(E.enrollment_date) = {year} AND MONTH(E.enrollment_date) = {month}
                ORDER BY E.enrollment_date DESC";
            return GetDataTable(query);
        }
        public DataTable GetEnrollmentDetailsByYear(int year)
        {
            string query = $@"
                SELECT 
                    S.full_name AS StudentName,
                    C.name AS CourseName,
                    E.enrollment_date AS EnrollmentDate
                FROM Enrollment E
                JOIN Student S ON E.student_id = S.id
                JOIN Course C ON E.course_id = C.id
                WHERE YEAR(E.enrollment_date) = {year}
                ORDER BY E.enrollment_date DESC";
            return GetDataTable(query);
        }
        public DataTable GetAttendanceDetailsByDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    S.session_date AS ScheduleDate,
                    St.full_name AS StudentName,
                    A.status AS AttendanceStatus,
                    A.note AS Note
                FROM Attendance A
                JOIN Schedule S ON A.schedule_id = S.id
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON A.student_id = St.id
                WHERE CAST(S.session_date AS DATE) = '{date:yyyy-MM-dd}'
                ORDER BY C.name, S.session_date, St.full_name";
            return GetDataTable(query);
        }
        public DataTable GetAttendanceDetailsByMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    S.session_date AS ScheduleDate,
                    St.full_name AS StudentName,
                    A.status AS AttendanceStatus,
                    A.note AS Note
                FROM Attendance A
                JOIN Schedule S ON A.schedule_id = S.id
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON A.student_id = St.id
                WHERE YEAR(S.session_date) = {year} AND MONTH(S.session_date) = {month}
                ORDER BY C.name, S.session_date, St.full_name";
            return GetDataTable(query);
        }
        public DataTable GetAttendanceDetailsByYear(int year)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    S.session_date AS ScheduleDate,
                    St.full_name AS StudentName,
                    A.status AS AttendanceStatus,
                    A.note AS Note
                FROM Attendance A
                JOIN Schedule S ON A.schedule_id = S.id
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON A.student_id = St.id
                WHERE YEAR(S.session_date) = {year}
                ORDER BY C.name, S.session_date, St.full_name";
            return GetDataTable(query);
        }
        public DataTable GetScoreDetailsByDate(DateTime date)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    St.full_name AS StudentName,
                    S.score AS ScoreValue,
                    S.created_date AS ScoreDate
                FROM Score S
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON S.student_id = St.id
                WHERE CAST(S.created_date AS DATE) = '{date:yyyy-MM-dd}'
                ORDER BY C.name, St.full_name, S.created_date";
            return GetDataTable(query);
        }
        public DataTable GetScoreDetailsByMonth(int year, int month)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    St.full_name AS StudentName,
                    S.score AS ScoreValue,
                    S.created_date AS ScoreDate
                FROM Score S
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON S.student_id = St.id
                WHERE YEAR(S.created_date) = {year} AND MONTH(S.created_date) = {month}
                ORDER BY C.name, St.full_name, S.created_date";
            return GetDataTable(query);
        }
        public DataTable GetScoreDetailsByYear(int year)
        {
            string query = $@"
                SELECT 
                    C.name AS ClassName,
                    St.full_name AS StudentName,
                    S.score AS ScoreValue,
                    S.created_date AS ScoreDate
                FROM Score S
                JOIN Class C ON S.class_id = C.id
                JOIN Student St ON S.student_id = St.id
                WHERE YEAR(S.created_date) = {year}
                ORDER BY C.name, St.full_name, S.created_date";
            return GetDataTable(query);
        }
    }
}
