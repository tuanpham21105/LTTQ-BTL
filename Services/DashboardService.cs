using prj_LTTQ_BTL.Data.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class DashboardService
    {
        private readonly DashboardRepository _dashboardRepository;

        public DashboardService()
        {
            _dashboardRepository = new DashboardRepository();
        }
        public int GetTotalStudentCount()
        {
            return _dashboardRepository.GetTotalStudentCount();
        }
        public int GetTotalTeacherCount()
        {
            return _dashboardRepository.GetTotalTeacherCount();
        }
        public int GetTotalClassCount()
        {
            return _dashboardRepository.GetTotalClassCount();
        }
        public int GetTotalCourseCount()
        {
            return _dashboardRepository.GetTotalCourseCount();
        }
        public decimal GetTotalRevenueByDate(DateTime date)
        {
            return _dashboardRepository.GetTotalRevenueByDate(date);
        }
        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            return _dashboardRepository.GetTotalRevenueByMonth(year, month);
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            return _dashboardRepository.GetTotalRevenueByYear(year);
        }
        public int GetEnrollmentCountByDate(DateTime date)
        {
            return _dashboardRepository.GetEnrollmentCountByDate(date);
        }
        public int GetEnrollmentCountByMonth(int year, int month)
        {
            return _dashboardRepository.GetEnrollmentCountByMonth(year, month);
        }
        public int GetEnrollmentCountByYear(int year)
        {
            return _dashboardRepository.GetEnrollmentCountByYear(year);
        }
        //public DataTable GetAttendanceReportByDate(Guid classId, DateTime date)
        //{
        //    return _dashboardRepository.GetAttendanceReportOfClassByDate(classId, date);
        //}

        //public DataTable GetAttendanceReportByMonth(Guid classId, int year, int month)
        //{
        //    return _dashboardRepository.GetAttendanceReportOfClassByMonth(classId, year, month);
        //}

        //public DataTable GetAttendanceReportByYear(Guid classId, int year)
        //{
        //    return _dashboardRepository.GetAttendanceReportOfClassByYear(classId, year);
        //}
        public DataTable GetScoreReportByDate(Guid classId, DateTime date)
        {
            return _dashboardRepository.GetScoreReportByDate(classId, date);
        }
        public DataTable GetScoreReportByMonth(Guid classId, int year, int month)
        {
            return _dashboardRepository.GetScoreReportByMonth(classId, year, month);
        }
        public DataTable GetScoreReportByYear(Guid classId, int year)
        {
            return _dashboardRepository.GetScoreReportByYear(classId, year);
        }
        public DataTable GetEnrollmentByCourseAndDate(DateTime date)
        {
            return _dashboardRepository.GetEnrollmentByCourseAndDate(date);
        }
        public DataTable GetEnrollmentByCourseAndMonth(int year, int month)
        {
            return _dashboardRepository.GetEnrollmentByCourseAndMonth(year, month);
        }
        public DataTable GetEnrollmentByCourseAndYear(int year)
        {
            return _dashboardRepository.GetEnrollmentByCourseAndYear(year);
        }
        public decimal GetPaidRevenueByDate(DateTime date)
        {
            return _dashboardRepository.GetPaidRevenueByDate(date);
        }

        public decimal GetPaidRevenueByMonth(int year, int month)
        {
            return _dashboardRepository.GetPaidRevenueByMonth(year, month);
        }
        public decimal GetPaidRevenueByYear(int year)
        {
            return _dashboardRepository.GetPaidRevenueByYear(year);
        }
        public decimal GetPendingRevenueByDate(DateTime date)
        {
            return _dashboardRepository.GetPendingRevenueByDate(date);
        }
        public decimal GetPendingRevenueByMonth(int year, int month)
        {
            return _dashboardRepository.GetPendingRevenueByMonth(year, month);
        }
        public decimal GetPendingRevenueByYear(int year)
        {
            return _dashboardRepository.GetPendingRevenueByYear(year);
        }
        public DataTable GetAttendanceStatusByDate(DateTime date)
        {
            return _dashboardRepository.GetAttendanceStatusByDate(date);
        }

        public DataTable GetAttendanceStatusByMonth(int year, int month)
        {
            return _dashboardRepository.GetAttendanceStatusByMonth(year, month);
        }

        public DataTable GetAttendanceStatusByYear(int year)
        {
            return _dashboardRepository.GetAttendanceStatusByYear(year);
        }
        public DataTable GetAverageScoreByClassAndDate(DateTime date)
        {
            return _dashboardRepository.GetAverageScoreByClassAndDate(date);
        }
        public DataTable GetAverageScoreByClassAndMonth(int year, int month)
        {
            return _dashboardRepository.GetAverageScoreByClassAndMonth(year, month);
        }
        public DataTable GetAverageScoreByClassAndYear(int year)
        {
            return _dashboardRepository.GetAverageScoreByClassAndYear(year);
        }
        public DataTable GetAllClasses()
        {
            return _dashboardRepository.GetAllClasses();
        }
        public DataTable GetPaymentDetailsByDate(DateTime date)
        {
            return _dashboardRepository.GetPaymentDetailsByDate(date);
        }

        public DataTable GetPaymentDetailsByMonth(int year, int month)
        {
            return _dashboardRepository.GetPaymentDetailsByMonth(year, month);
        }

        public DataTable GetPaymentDetailsByYear(int year)
        {
            return _dashboardRepository.GetPaymentDetailsByYear(year);
        }
        public DataTable GetEnrollmentDetailsByDate(DateTime date)
        {
            return _dashboardRepository.GetEnrollmentDetailsByDate(date);
        }

        public DataTable GetEnrollmentDetailsByMonth(int year, int month)
        {
            return _dashboardRepository.GetEnrollmentDetailsByMonth(year, month);
        }

        public DataTable GetEnrollmentDetailsByYear(int year)
        {
            return _dashboardRepository.GetEnrollmentDetailsByYear(year);
        }
        public DataTable GetAttendanceDetailsByDate(DateTime date)
        {
            return _dashboardRepository.GetAttendanceDetailsByDate(date);
        }
        public DataTable GetAttendanceDetailsByMonth(int year, int month)
        {
            return _dashboardRepository.GetAttendanceDetailsByMonth(year, month);
        }
        public DataTable GetAttendanceDetailsByYear(int year)
        {
            return _dashboardRepository.GetAttendanceDetailsByYear(year);
        }
        public DataTable GetScoreDetailsByDate(DateTime date)
        {
            return _dashboardRepository.GetScoreDetailsByDate(date);
        }
        public DataTable GetScoreDetailsByMonth(int year, int month)
        {
            return _dashboardRepository.GetScoreDetailsByMonth(year, month);
        }
        public DataTable GetScoreDetailsByYear(int year)
        {
            return _dashboardRepository.GetScoreDetailsByYear(year);
        }
    }
}
