using prj_LTTQ_BTL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using Excel = Microsoft.Office.Interop.Excel;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_DashboardForm : Form
    {
        private readonly DashboardService _dashboardService;
        private ToolTip chartToolTip = new ToolTip();
        private void InitializeChartToolTip()
        {
            chartToolTip.AutoPopDelay = 5000;
            chartToolTip.InitialDelay = 500;
            chartToolTip.ReshowDelay = 200;
            chartToolTip.ShowAlways = true;
            GeneralAttendanceChart.MouseMove += GeneralAttendanceChart_MouseMove;
        }
        public Manager_DashboardForm()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            InitializeChartToolTip();
            ConfigureDateTimePickers();
        }
        private void ConfigureDateTimePickers()
        {
            dtpPayment.Format = DateTimePickerFormat.Custom;
            dtpPayment.CustomFormat = "yyyy";
            dtpPayment.Value = DateTime.Now;

            dtpEnrollment.Format = DateTimePickerFormat.Custom;
            dtpEnrollment.CustomFormat = "yyyy";
            dtpEnrollment.Value = DateTime.Now;

            dtpAttendance.Format = DateTimePickerFormat.Custom;
            dtpAttendance.CustomFormat = "yyyy";
            dtpAttendance.Value = DateTime.Now;

            dtpScore.Format = DateTimePickerFormat.Custom;
            dtpScore.CustomFormat = "yyyy";
            dtpScore.Value = DateTime.Now;
        }
        private void Manager_DashboardForm_Load(object sender, EventArgs e)
        {
            labelCountClass.Text = _dashboardService.GetTotalClassCount().ToString();
            labelCountCourse.Text = _dashboardService.GetTotalCourseCount().ToString();
            labelCountStudent.Text = _dashboardService.GetTotalStudentCount().ToString();
            labelCountTeacher.Text = _dashboardService.GetTotalStudentCount().ToString();
            InitializeClassComboBox();
        }
        private void InitializeClassComboBox()
        {
            try
            {
                DataTable classes = _dashboardService.GetAllClasses();

                cmbClass.DataSource = classes;
                cmbClass.DisplayMember = "ClassName";
                cmbClass.ValueMember = "ClassId";    
                cmbClass.SelectedIndex = 0;         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lớp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaymentByDate_Click(object sender, EventArgs e)
        {
            dtpPayment.Format = DateTimePickerFormat.Custom;
            dtpPayment.CustomFormat = "dd/MM/yyyy"; 
            dtpPayment.ShowUpDown = false;
        }
        private void btnPayementByMonth_Click(object sender, EventArgs e)
        {
            dtpPayment.Format = DateTimePickerFormat.Custom;
            dtpPayment.CustomFormat = "MM/yyyy"; 
            dtpPayment.ShowUpDown = true;
        }
        private void btnPaymentByYear_Click(object sender, EventArgs e)
        {
            dtpPayment.Format = DateTimePickerFormat.Custom;
            dtpPayment.CustomFormat = "yyyy"; 
            dtpPayment.ShowUpDown = true;
        }
        private void btnPaymentExport_Click(object sender, EventArgs e)
        {
            try
            {
                string currentFormat = dtpPayment.CustomFormat;
                DataTable paymentData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    paymentData = _dashboardService.GetPaymentDetailsByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    paymentData = _dashboardService.GetPaymentDetailsByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    int year = selectedDate.Year;
                    paymentData = _dashboardService.GetPaymentDetailsByYear(year);
                }

                if (paymentData == null || paymentData.Rows.Count == 0)
                {
                    //MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "PaymentReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(paymentData, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; 
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Exported Data";

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                worksheet.Columns.ColumnWidth = 30;
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadGeneralEnrollmentChart()
        {
            try
            {
                string currentFormat = dtpEnrollment.CustomFormat;
                DataTable enrollmentData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    enrollmentData = _dashboardService.GetEnrollmentByCourseAndDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    enrollmentData = _dashboardService.GetEnrollmentByCourseAndMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    int year = selectedDate.Year;
                    enrollmentData = _dashboardService.GetEnrollmentByCourseAndYear(year);
                }

                GeneralEnrollmentChart.Series.Clear();

                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Enrollments",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar,
                    XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                    YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32,
                    IsValueShownAsLabel = true
                };

                foreach (DataRow row in enrollmentData.Rows)
                {
                    string courseName = row["CourseName"].ToString(); 
                    int enrollmentCount = Convert.ToInt32(row["TotalEnrollments"]); 
                    series.Points.AddXY(courseName, enrollmentCount);
                }

                GeneralEnrollmentChart.Series.Add(series);

                var chartArea = GeneralEnrollmentChart.ChartAreas[0];
                chartArea.AxisX.Title = "Khóa học";
                chartArea.AxisY.Title = "Số lượng đăng ký";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.BackColor = System.Drawing.Color.White;
                GeneralEnrollmentChart.BackColor = System.Drawing.Color.White;
                GeneralEnrollmentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                GeneralEnrollmentChart.BorderlineColor = System.Drawing.Color.LightGray;


                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8); 
                GeneralEnrollmentChart.Legends.Clear();

                series.Color = System.Drawing.Color.SteelBlue; 
                chartArea.BackColor = System.Drawing.Color.White; 
                GeneralEnrollmentChart.BackColor = System.Drawing.Color.White; 
                GeneralEnrollmentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                GeneralEnrollmentChart.BorderlineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải biểu đồ số lượng đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpPayment_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string currentFormat = dtpPayment.CustomFormat;
                decimal revenue = 0;
                decimal revenuePaid = 0;
                decimal revenuePending = 0;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    revenue = _dashboardService.GetTotalRevenueByDate(selectedDate);
                    revenuePaid = _dashboardService.GetPaidRevenueByDate(selectedDate);
                    revenuePending = _dashboardService.GetPendingRevenueByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    revenue = _dashboardService.GetTotalRevenueByMonth(year, month);
                    revenuePaid = _dashboardService.GetPaidRevenueByMonth(year, month);
                    revenuePending = _dashboardService.GetPendingRevenueByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpPayment.Value;
                    int year = selectedDate.Year;
                    revenue = _dashboardService.GetTotalRevenueByYear(year);
                    revenuePaid = _dashboardService.GetPaidRevenueByYear(year);
                    revenuePending = _dashboardService.GetPendingRevenueByYear(year);
                }

                if (revenue > 0)
                {
                    int totalPercentage = 100;
                    int paidPercentage = (int)((revenuePaid / revenue) * totalPercentage);
                    int pendingPercentage = (int)((revenuePending / revenue) * totalPercentage);

                    circlePaymentTotal.Value = totalPercentage;
                    circlePaymentHavePaid.Value = paidPercentage;
                    circlePaymentNotPaid.Value = pendingPercentage;

                    labelTotalPayment.Text = $"{revenue:C}";
                    labelPaymentHavePaid.Text = $"{revenuePaid:C} ({paidPercentage}%)";
                    labelPaymentNotPaid.Text = $"{revenuePending:C} ({pendingPercentage}%)";
                }
                else
                {
                    circlePaymentTotal.Value = 100;
                    circlePaymentHavePaid.Value = 0;
                    circlePaymentNotPaid.Value = 0;

                    labelTotalPayment.Text = "0";
                    labelPaymentHavePaid.Text = "0 (0%)";
                    labelPaymentNotPaid.Text = "0 (0%)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpEnrollment_ValueChanged(object sender, EventArgs e)
        {
            LoadGeneralEnrollmentChart();
        }

        private void btnEnrollmentByDate_Click(object sender, EventArgs e)
        {
            dtpEnrollment.Format = DateTimePickerFormat.Custom;
            dtpEnrollment.CustomFormat = "dd/MM/yyyy";
            dtpEnrollment.ShowUpDown = false;
        }

        private void btnEnrollmentByMonth_Click(object sender, EventArgs e)
        {
            dtpEnrollment.Format = DateTimePickerFormat.Custom;
            dtpEnrollment.CustomFormat = "MM/yyyy";
            dtpEnrollment.ShowUpDown = true;
        }

        private void btnEnrollmentExport_Click(object sender, EventArgs e)
        {
            try
            {
                string currentFormat = dtpEnrollment.CustomFormat;
                DataTable enrollmentData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    enrollmentData = _dashboardService.GetEnrollmentDetailsByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    enrollmentData = _dashboardService.GetEnrollmentDetailsByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpEnrollment.Value;
                    int year = selectedDate.Year;
                    enrollmentData = _dashboardService.GetEnrollmentDetailsByYear(year);
                }

                if (enrollmentData == null || enrollmentData.Rows.Count == 0)
                {
                    //MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "EnrollmentReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(enrollmentData, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnrollmentByYear_Click(object sender, EventArgs e)
        {
            dtpEnrollment.Format = DateTimePickerFormat.Custom;
            dtpEnrollment.CustomFormat = "yyyy";
            dtpEnrollment.ShowUpDown = true;
        }
        private void LoadGeneralAttendanceChart()
        {
            try
            {
                string currentFormat = dtpAttendance.CustomFormat;
                DataTable attendanceData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    attendanceData = _dashboardService.GetAttendanceStatusByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    attendanceData = _dashboardService.GetAttendanceStatusByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    int year = selectedDate.Year;
                    attendanceData = _dashboardService.GetAttendanceStatusByYear(year);
                }

                if (attendanceData == null || attendanceData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GeneralAttendanceChart.Series.Clear();

                var presentSeries = new Series
                {
                    Name = "Present",
                    ChartType = SeriesChartType.StackedBar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    Color = System.Drawing.Color.FromArgb(39, 174, 96),
                    IsValueShownAsLabel = true,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    LabelForeColor = System.Drawing.Color.White
                    //Color = System.Drawing.Color.Green
                };

                var absentSeries = new Series
                {
                    Name = "Absent",
                    ChartType = SeriesChartType.StackedBar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    Color = System.Drawing.Color.FromArgb(192, 57, 43),
                    IsValueShownAsLabel = true,
                    //Color = System.Drawing.Color.Red
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    LabelForeColor = System.Drawing.Color.White
                };

                var lateSeries = new Series
                {
                    Name = "Late",
                    ChartType = SeriesChartType.StackedBar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    Color = System.Drawing.Color.FromArgb(243, 156, 18),
                    IsValueShownAsLabel = true,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    LabelForeColor = System.Drawing.Color.White
                    //Color = System.Drawing.Color.Orange
                };

                var excusedSeries = new Series
                {
                    Name = "Excused",
                    ChartType = SeriesChartType.StackedBar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    Color = System.Drawing.Color.FromArgb(41, 128, 185),
                    IsValueShownAsLabel = true,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    LabelForeColor = System.Drawing.Color.White
                    //Color = System.Drawing.Color.Blue
                };

                foreach (DataRow row in attendanceData.Rows)
                {
                    string className = row["ClassName"].ToString();
                    int present = Convert.ToInt32(row["Present"]);
                    int absent = Convert.ToInt32(row["Absent"]);
                    int late = Convert.ToInt32(row["Late"]);
                    int excused = Convert.ToInt32(row["Excused"]);
                    double presentPercentage, absentPercentage, latePercentage, excusedPercentage;
                    int total = present + absent + late + excused;
                    if (total == 0)
                    {
                        presentPercentage = 100;
                        absentPercentage = 0;
                        latePercentage = 0;
                        excusedPercentage = 0;
                    }
                    else
                    {
                        presentPercentage = Math.Round((double)present / total * 100, 2);
                        absentPercentage = Math.Round((double)absent / total * 100, 2);
                        latePercentage = Math.Round((double)late / total * 100, 2);
                        excusedPercentage = Math.Round((double)excused / total * 100, 2);
                    }

                    var presentPoint = presentSeries.Points.AddXY(className, presentPercentage);
                    presentSeries.Points[presentPoint].IsValueShownAsLabel = presentPercentage > 0;

                    var absentPoint = absentSeries.Points.AddXY(className, absentPercentage);
                    absentSeries.Points[absentPoint].IsValueShownAsLabel = absentPercentage > 0;

                    var latePoint = lateSeries.Points.AddXY(className, latePercentage);
                    lateSeries.Points[latePoint].IsValueShownAsLabel = latePercentage > 0;

                    var excusedPoint = excusedSeries.Points.AddXY(className, excusedPercentage);
                    excusedSeries.Points[excusedPoint].IsValueShownAsLabel = excusedPercentage > 0;

                }

                GeneralAttendanceChart.Series.Add(presentSeries);
                GeneralAttendanceChart.Series.Add(absentSeries);
                GeneralAttendanceChart.Series.Add(lateSeries);
                GeneralAttendanceChart.Series.Add(excusedSeries);

                var chartArea = GeneralAttendanceChart.ChartAreas[0];
                chartArea.AxisX.Title = "Lớp học";
                chartArea.AxisY.Title = "Tỷ lệ (%)";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.Maximum = 100;

                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
                GeneralAttendanceChart.Legends.Clear();

                chartArea.BackColor = System.Drawing.Color.White;
                GeneralAttendanceChart.BackColor = System.Drawing.Color.White;
                GeneralAttendanceChart.BorderlineDashStyle = ChartDashStyle.Solid;
                GeneralAttendanceChart.BorderlineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải biểu đồ trạng thái điểm danh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAttendanceByYear_Click(object sender, EventArgs e)
        {
            dtpAttendance.Format = DateTimePickerFormat.Custom;
            dtpAttendance.CustomFormat = "yyyy";
            dtpAttendance.ShowUpDown = true;
        }

        private void btnAttendanceByDate_Click(object sender, EventArgs e)
        {
            dtpAttendance.Format = DateTimePickerFormat.Custom;
            dtpAttendance.CustomFormat = "dd/MM/yyyy";
            dtpAttendance.ShowUpDown = false;
        }

        private void btnAttendanceByMonth_Click(object sender, EventArgs e)
        {
            dtpAttendance.Format = DateTimePickerFormat.Custom;
            dtpAttendance.CustomFormat = "MM/yyyy";
            dtpAttendance.ShowUpDown = true;
        }

        private void btnAttendanceExport_Click(object sender, EventArgs e)
        {
            try
            {
                string currentFormat = dtpAttendance.CustomFormat;
                DataTable attendanceData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    attendanceData = _dashboardService.GetAttendanceDetailsByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    attendanceData = _dashboardService.GetAttendanceDetailsByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpAttendance.Value;
                    int year = selectedDate.Year;
                    attendanceData = _dashboardService.GetAttendanceDetailsByYear(year);
                }

                if (attendanceData == null || attendanceData.Rows.Count == 0)
                {
                    //MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "AttendanceReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(attendanceData, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpAttendance_ValueChanged(object sender, EventArgs e)
        {
            LoadGeneralAttendanceChart();
        }

        private void GeneralAttendanceChart_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestResult = GeneralAttendanceChart.HitTest(e.X, e.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                var dataPoint = hitTestResult.Series.Points[hitTestResult.PointIndex];
                var seriesName = hitTestResult.Series.Name;

                string toolTipText = $"Lớp: {hitTestResult.Series.Points[hitTestResult.PointIndex].AxisLabel}\n" +
                                     $"Trạng thái: {seriesName}\n" +
                                     $"Tỷ lệ: {dataPoint.YValues[0]:0.##}%";
                chartToolTip.Show(toolTipText, GeneralAttendanceChart, e.X + 15, e.Y - 20);
            }
            else
            {
                chartToolTip.Hide(GeneralAttendanceChart);
            }
        }

        private void btnScoreByYear_Click(object sender, EventArgs e)
        {
            dtpScore.Format = DateTimePickerFormat.Custom;
            dtpScore.CustomFormat = "yyyy";
            dtpScore.ShowUpDown = true;
        }

        private void btnScorebyDate_Click(object sender, EventArgs e)
        {
            dtpScore.Format = DateTimePickerFormat.Custom;
            dtpScore.CustomFormat = "dd/MM/yyyy";
            dtpScore.ShowUpDown = false;
        }

        private void btnScoreByMonth_Click(object sender, EventArgs e)
        {
            dtpScore.Format = DateTimePickerFormat.Custom;
            dtpScore.CustomFormat = "MM/yyyy";
            dtpScore.ShowUpDown = true;
        }

        private void btnScoreExport_Click(object sender, EventArgs e)
        {
            try
            {
                string currentFormat = dtpScore.CustomFormat;
                DataTable scoreData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    scoreData = _dashboardService.GetScoreDetailsByDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    scoreData = _dashboardService.GetScoreDetailsByMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    scoreData = _dashboardService.GetScoreDetailsByYear(year);
                }

                if (scoreData == null || scoreData.Rows.Count == 0)
                {
                    //MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "ScoreReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(scoreData, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowDataTableInMessageBox(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append(column.ColumnName).Append("\t");
            }
            sb.AppendLine();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item.ToString()).Append("\t");
                }
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadAverageClassesScoreChart()
        {
            try
            {
                string currentFormat = dtpScore.CustomFormat;
                DataTable averageScoreData = null;

                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    averageScoreData = _dashboardService.GetAverageScoreByClassAndDate(selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    averageScoreData = _dashboardService.GetAverageScoreByClassAndMonth(year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    averageScoreData = _dashboardService.GetAverageScoreByClassAndYear(year);
                }

                if (averageScoreData == null || averageScoreData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                chartAverageClassesScore.Series.Clear();

                var series = new Series
                {
                    Name = "Average Score",
                    ChartType = SeriesChartType.Bar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.SteelBlue
                };

                foreach (DataRow row in averageScoreData.Rows)
                {
                    string className = row["ClassName"].ToString();
                    double averageScore = Convert.ToDouble(row["AverageScore"]);
                    series.Points.AddXY(className, averageScore);
                }

                chartAverageClassesScore.Series.Add(series);

                var chartArea = chartAverageClassesScore.ChartAreas[0];
                chartArea.AxisX.Title = "Lớp học";
                chartArea.AxisY.Title = "Điểm trung bình";
                chartArea.AxisY.Minimum = 0; 
                chartArea.AxisY.Maximum = 10;
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;

                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
                chartAverageClassesScore.Legends.Clear();

                chartArea.BackColor = System.Drawing.Color.White;
                chartAverageClassesScore.BackColor = System.Drawing.Color.White;
                chartAverageClassesScore.BorderlineDashStyle = ChartDashStyle.Solid;
                chartAverageClassesScore.BorderlineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải biểu đồ điểm trung bình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadClassScoreChart()
        {
            try
            {
                string currentFormat = dtpScore.CustomFormat;
                DataTable scoreData = null;
                if (cmbClass.SelectedValue == null || !Guid.TryParse(cmbClass.SelectedValue.ToString(), out Guid selectedClassId))
                {
                    MessageBox.Show("Lỗi: Giá trị lớp học không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (currentFormat == "dd/MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    scoreData = _dashboardService.GetScoreReportByDate(selectedClassId, selectedDate);
                }
                else if (currentFormat == "MM/yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    int month = selectedDate.Month;
                    scoreData = _dashboardService.GetScoreReportByMonth(selectedClassId, year, month);
                }
                else if (currentFormat == "yyyy")
                {
                    DateTime selectedDate = dtpScore.Value;
                    int year = selectedDate.Year;
                    scoreData = _dashboardService.GetScoreReportByYear(selectedClassId, year);
                }

                if (scoreData == null || scoreData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                chartClassScore.Series.Clear();

                var series = new Series
                {
                    Name = "Scores",
                    ChartType = SeriesChartType.Bar,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Int32,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.SteelBlue
                };

                foreach (DataRow row in scoreData.Rows)
                {
                    string scoreCategory = row.Table.Columns.Contains("ScoreCategory") ? row["ScoreCategory"].ToString() : "Unknown";
                    int scoreCount = Convert.ToInt32(row["ScoreCount"]);
                    series.Points.AddXY(scoreCategory, scoreCount);
                }

                chartClassScore.Series.Add(series);

                var chartArea = chartClassScore.ChartAreas[0];
                chartArea.AxisX.Title = "Loại điểm";
                chartArea.AxisY.Title = "Số lượng";
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;

                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
                chartClassScore.Legends.Clear();

                chartArea.BackColor = System.Drawing.Color.White;
                chartClassScore.BackColor = System.Drawing.Color.White;
                chartClassScore.BorderlineDashStyle = ChartDashStyle.Solid;
                chartClassScore.BorderlineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải biểu đồ điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpAverageScore_ValueChanged(object sender, EventArgs e)
        {
            LoadAverageClassesScoreChart();
            //LoadClassScoreChart();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadClassScoreChart();
        }

    }
}
