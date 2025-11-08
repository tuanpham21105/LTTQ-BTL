using prj_LTTQ_BTL.Data;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace prj_LTTQ_BTL.Forms.Teacher
{
    public partial class Teacher_ClassDetailForm : Form
    {
        private readonly DataProcessor dtBase = new DataProcessor();
        private readonly string classId;
        private readonly string className;

        public Teacher_ClassDetailForm(string _classId, string _className)
        {
            InitializeComponent();
            classId = _classId;
            className = _className;
        }

        private void Teacher_ClassDetailForm_Load(object sender, EventArgs e)
        {
            LoadClassInfoFromDB();
            SetupDataGridView();
            LoadStudents();
        }


        private void LoadClassInfoFromDB()
        {
            string query = $@"
            SELECT 
            C.name AS ClassName,
            CR.name AS CourseName,
            T.full_name AS TeacherName,
            CONVERT(VARCHAR(10), C.start_date, 103) AS StartDate,
            COUNT(CA.student_id) AS StudentCount,
            CASE 
            WHEN C.start_date <= GETDATE() THEN N'Đang học'
            ELSE N'Chưa bắt đầu'
            END AS TrangThai
            FROM Class C
            JOIN Course CR ON C.course_id = CR.id
            LEFT JOIN Teacher T ON T.id = C.teacher_id
            LEFT JOIN ClassAssignment CA ON C.id = CA.class_id
            WHERE C.id = '{classId}'
            GROUP BY C.name, CR.name, T.full_name, C.start_date;";

            DataTable dt = dtBase.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                lblClassTitle.Text = $" LỚP HỌC: {row["ClassName"]}";
                lblSubject.Text = $" Môn học: {row["CourseName"]}";
                lblTeacher.Text = $" Giáo viên: {row["TeacherName"]}";
                lblStartDate.Text = $" Ngày bắt đầu: {row["StartDate"]}";
                lblStudentCount.Text = $" Số HV: {row["StudentCount"]}";

                string status = row["TrangThai"].ToString();
                lblStatus.Text = (status == "Đang học") ? " Đang học" : " Chưa bắt đầu";
            }
        }


        private void SetupDataGridView()
        {
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ThemeStyle.HeaderStyle.Height = 45;

            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvStudents.EnableHeadersVisualStyles = false;

            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStudents.RowTemplate.Height = 45;         
            dgvStudents.RowTemplate.MinimumHeight = 40;  
            dgvStudents.DefaultCellStyle.Padding = new Padding(5, 8, 5, 8);
            dgvStudents.RowHeadersVisible = false;

            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            dgvStudents.GridColor = Color.FromArgb(220, 220, 220);
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void LoadStudents()
        {
            string query = $@"
            SELECT 
            S.full_name AS [Họ tên],
            CONVERT(VARCHAR(10), S.birth_date, 103) AS [Ngày sinh],
            S.gender AS [Giới tính],
            S.phone_number AS [Số điện thoại],
            S.email AS [Email],
            S.address AS [Địa chỉ]
            FROM ClassAssignment CA
            JOIN Student S ON CA.student_id = S.id
            WHERE CA.class_id = '{classId}'
            ORDER BY S.full_name;";

            DataTable dt = dtBase.GetDataTable(query);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = dt;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchStudent_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearchStudent.Text.Trim();

            string query = string.IsNullOrEmpty(keyword)
            ? $@"
            SELECT 
            S.full_name AS [Họ tên],
            CONVERT(VARCHAR(10), S.birth_date, 103) AS [Ngày sinh],
            S.gender AS [Giới tính],
            S.phone_number AS [Số điện thoại],
            S.email AS [Email],
            S.address AS [Địa chỉ]
            FROM ClassAssignment CA
            JOIN Student S ON CA.student_id = S.id
            WHERE CA.class_id = '{classId}'
            ORDER BY S.full_name;"
            : $@"
            SELECT 
            S.full_name AS [Họ tên],
            CONVERT(VARCHAR(10), S.birth_date, 103) AS [Ngày sinh],
            S.gender AS [Giới tính],
            S.phone_number AS [Số điện thoại],
            S.email AS [Email],
            S.address AS [Địa chỉ]
            FROM ClassAssignment CA
            JOIN Student S ON CA.student_id = S.id
            WHERE CA.class_id = '{classId}'
            AND S.full_name LIKE N'%{keyword}%'
            ORDER BY S.full_name;";

            DataTable dt = dtBase.GetDataTable(query);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = dt;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadScheduleGridVisual()
        {
            for (int row = 1; row < tblSchedule.RowCount; row++)
            {
                for (int col = 1; col < tblSchedule.ColumnCount; col++)
                {
                    var control = tblSchedule.GetControlFromPosition(col, row);
                    if (control != null && control is Guna.UI2.WinForms.Guna2Panel)
                        tblSchedule.Controls.Remove(control);
                }
            }

            
            string query = $@"
            SELECT session_date, start_time, room
            FROM Schedule
            WHERE class_id = '{classId}'";
            DataTable dt = dtBase.GetDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["session_date"]);
                int weekday = (int)date.DayOfWeek;
                if (weekday == 0) weekday = 7;  
                TimeSpan start = TimeSpan.Parse(row["start_time"].ToString());
                int rowIndex = start.Hours - 6;  

                 
                var card = new Guna.UI2.WinForms.Guna2Panel
                {
                    BorderRadius = 8,
                    FillColor = GetColorByDay(weekday),
                    Margin = new Padding(5),
                    Dock = DockStyle.Fill
                };

                var lbl = new Label
                {
                    Text = $"Giao tiếp 1\n🕐 {start:hh\\:mm}\n🏫 {row["room"]}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.White
                };

                card.Controls.Add(lbl);
                tblSchedule.Controls.Add(card, weekday, rowIndex);
            }
        }

         
        private Color GetColorByDay(int weekday)
        {
            switch (weekday)
            {
                case 2: return Color.FromArgb(33, 150, 243);  
                case 3: return Color.FromArgb(76, 175, 80);   
                case 4: return Color.FromArgb(156, 39, 176);  
                case 5: return Color.FromArgb(244, 67, 54);   
                case 6: return Color.FromArgb(255, 152, 0);   
                case 7: return Color.FromArgb(0, 188, 212);   
                default: return Color.FromArgb(96, 125, 139);  
            }
        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedIndex == 1)
            {
                LoadScheduleGridVisual();
            }
            else if (guna2TabControl1.SelectedIndex == 2)
            {
                LoadAttendanceDates();
            }
            else if (guna2TabControl1.SelectedIndex == 3)
            {
                LoadScores();
            }

        }

        private void LoadAttendanceDates()
        {
             
            string query = $@"
            SELECT 
            CONVERT(VARCHAR(10), session_date, 103) AS NgayHoc,
            session_date
            FROM Schedule
            WHERE class_id = '{classId}'
            GROUP BY session_date
            ORDER BY session_date";

            DataTable dt = dtBase.GetDataTable(query);

            cboSessionDate.DataSource = dt;
            cboSessionDate.DisplayMember = "NgayHoc";
            cboSessionDate.ValueMember = "session_date";

             
            if (cboSessionDate.Items.Count > 0)
                cboSessionDate.SelectedIndex = 0;
        }
        private void LoadSessionTimes()
        {
             
            string query = $@"
            SELECT 
            CONVERT(VARCHAR(5), start_time, 108) AS BuoiHoc,
            start_time
            FROM Schedule
            WHERE class_id = '{classId}'
            GROUP BY start_time
            ORDER BY start_time";

            DataTable dt = dtBase.GetDataTable(query);

            cboSessionTime.DataSource = dt;
            cboSessionTime.DisplayMember = "BuoiHoc";
            cboSessionTime.ValueMember = "BuoiHoc";

            if (cboSessionTime.Items.Count > 0)
                cboSessionTime.SelectedIndex = 0;
        }


        private void LoadAttendanceTable()
        {
            if (cboSessionDate.SelectedItem == null || cboSessionTime.SelectedItem == null)
                return;

             
            DataRowView drvDate = cboSessionDate.SelectedItem as DataRowView;
            DataRowView drvTime = cboSessionTime.SelectedItem as DataRowView;
            if (drvDate == null || drvTime == null)
                return;

            DateTime selectedDate = Convert.ToDateTime(drvDate["session_date"]);
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            string selectedTime = drvTime["BuoiHoc"].ToString();

             
            string query = $@"
            SELECT 
            S.id AS [Mã HV],
            S.full_name AS [Họ và tên],
            ISNULL(A.note, N'') AS [Ghi chú],
            A.status
            FROM ClassAssignment CA
            JOIN Student S ON S.id = CA.student_id
            LEFT JOIN Schedule SCH ON SCH.class_id = CA.class_id
            LEFT JOIN Attendance A ON A.student_id = S.id AND A.schedule_id = SCH.id
            WHERE CA.class_id = '{classId}' 
            AND CONVERT(date, SCH.session_date) = '{formattedDate}'
            AND CONVERT(VARCHAR(5), SCH.start_time, 108) = '{selectedTime}'
            ORDER BY S.full_name;";

            DataTable dt = dtBase.GetDataTable(query);
            dgvAttendance.DataSource = dt;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.ThemeStyle.HeaderStyle.Height = 45;

             
            string[] colNames = { "ColPresent", "ColAbsent", "ColLate", "ColExcused" };
            foreach (var name in colNames)
                if (dgvAttendance.Columns.Contains(name))
                    dgvAttendance.Columns.Remove(name);

             
            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ColPresent", HeaderText = "Có mặt", Width = 90 });
            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ColAbsent", HeaderText = "Vắng", Width = 90 });
            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ColLate", HeaderText = "Đi trễ", Width = 90 });
            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "ColExcused", HeaderText = "Có phép", Width = 90 });

             
            if (dgvAttendance.Columns.Contains("Ghi chú"))
            {
                dgvAttendance.Columns["Ghi chú"].Width = 200;
                dgvAttendance.Columns["Ghi chú"].DisplayIndex = dgvAttendance.Columns.Count - 1;

            }
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.GridColor = Color.LightGray;
             
            dgvAttendance.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                if (col.Name != "Ghi chú" && !col.Name.StartsWith("Col"))
                    col.ReadOnly = true;
            }

             
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["status"]?.Value?.ToString()?.Trim().ToLower() ?? "";
                row.Cells["ColPresent"].Value = (status == "present");
                row.Cells["ColAbsent"].Value = (status == "absent");
                row.Cells["ColLate"].Value = (status == "late");
                row.Cells["ColExcused"].Value = (status == "excused");
            }

             
            dgvAttendance.Columns["status"].Visible = false;
            dgvAttendance.AllowUserToAddRows = false;  


             
            dgvAttendance.CellContentClick -= dgvAttendance_CellContentClick;  
            dgvAttendance.CellContentClick += dgvAttendance_CellContentClick;
        }
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  
            string[] cols = { "ColPresent", "ColAbsent", "ColLate", "ColExcused" };

            if (cols.Contains(dgvAttendance.Columns[e.ColumnIndex].Name))
            {
                 
                foreach (string colName in cols)
                {
                    if (colName != dgvAttendance.Columns[e.ColumnIndex].Name)
                        dgvAttendance.Rows[e.RowIndex].Cells[colName].Value = false;
                }
            }
        }

        private void cboSessionDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionTimes();

        }

        private void cboSessionTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceTable();
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSessionDate.SelectedValue == null)
                {
                    MessageBox.Show(" Vui lòng chọn ngày học!", "Thông báo");
                    return;
                }

                 
                DateTime selectedDate = Convert.ToDateTime(cboSessionDate.SelectedValue);
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                 
                string querySchedule = $@"
                SELECT TOP 1 id FROM Schedule
                WHERE class_id = '{classId}' AND session_date = '{formattedDate}'";
                DataTable dtSchedule = dtBase.GetDataTable(querySchedule);
                if (dtSchedule.Rows.Count == 0)
                {
                    MessageBox.Show(" Không tìm thấy buổi học cho ngày này!", "Thông báo");
                    return;
                }
                string scheduleId = dtSchedule.Rows[0]["id"].ToString();

                 
                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {

                    if (row.IsNewRow) continue;
                    if (row.Cells["Mã HV"].Value == null) continue;

                    string studentId = row.Cells["Mã HV"].Value.ToString();
                    string note = row.Cells["Ghi chú"].Value?.ToString() ?? "";

                    bool present = Convert.ToBoolean(row.Cells["ColPresent"].Value ?? false);
                    bool absent = Convert.ToBoolean(row.Cells["ColAbsent"].Value ?? false);
                    bool late = Convert.ToBoolean(row.Cells["ColLate"].Value ?? false);
                    bool excused = Convert.ToBoolean(row.Cells["ColExcused"].Value ?? false);
                    bool hasAnyChecked = present || absent || late || excused;
                    if (!hasAnyChecked)
                    {
                        MessageBox.Show($" Học viên '{row.Cells["Họ và tên"].Value}' chưa được chọn trạng thái điểm danh!", "Thông báo");
                        return;  
                    }
                    string status = "absent";  
                    if (present) status = "present";
                    else if (absent) status = "absent";
                    else if (late) status = "late";
                    else if (excused) status = "excused";

                    string cmd = $@"
                    IF EXISTS (SELECT * FROM Attendance WHERE student_id='{studentId}' AND schedule_id='{scheduleId}')
                    UPDATE Attendance 
                    SET status='{status}', note=N'{note}'
                    WHERE student_id='{studentId}' AND schedule_id='{scheduleId}'
                    ELSE
                    INSERT INTO Attendance (student_id, schedule_id, status, note)
                    VALUES ('{studentId}', '{scheduleId}', '{status}', N'{note}')";

                    dtBase.UpdateData(cmd);
                }

                MessageBox.Show(" Lưu điểm danh thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi khi lưu điểm danh:\n" + ex.Message, "Lỗi");
            }
        }
        private void LoadScores()
        {
            string query = $@"
            SELECT 
            S.id AS [Mã HV],
            S.full_name AS [Họ và tên],
            ISNULL(Sc.score, 0) AS [Điểm]
            FROM ClassAssignment CA
            JOIN Student S ON S.id = CA.student_id
            LEFT JOIN Score Sc ON Sc.student_id = S.id AND Sc.class_id = CA.class_id
            WHERE CA.class_id = '{classId}'
            ORDER BY S.full_name;";

            DataTable dt = dtBase.GetDataTable(query);
            dgvScores.DataSource = dt;

             
            dgvScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScores.ThemeStyle.HeaderStyle.Height = 45;

            dgvScores.Columns["Mã HV"].ReadOnly = true;
            dgvScores.Columns["Họ và tên"].ReadOnly = true;

             
            dgvScores.Columns["Điểm"].ReadOnly = false;
            dgvScores.AllowUserToAddRows = false;  

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvScores.Rows)
            {
                if (row.IsNewRow) continue;

                string studentId = row.Cells["Mã HV"].Value.ToString();
                string scoreValue = row.Cells["Điểm"].Value?.ToString().Trim();

                 
                if (string.IsNullOrEmpty(scoreValue))
                    continue;

                 
                scoreValue = scoreValue.Replace(",", ".");

                 
                if (!decimal.TryParse(scoreValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal score))
                {
                    MessageBox.Show($" Điểm của học viên {row.Cells["Họ và tên"].Value} không hợp lệ!", "Lỗi");
                    return;
                }

                if (score < 0 || score > 10)
                {
                    MessageBox.Show($" Điểm của học viên {row.Cells["Họ và tên"].Value} phải nằm trong khoảng 0–10!", "Lỗi");
                    return;
                }

                 
                    string cmd = $@"
                    IF EXISTS (SELECT * FROM Score WHERE student_id='{studentId}' AND class_id='{classId}')
                    UPDATE Score 
                    SET score = {score.ToString(System.Globalization.CultureInfo.InvariantCulture)}, created_date = GETDATE()
                    WHERE student_id='{studentId}' AND class_id='{classId}'
                    ELSE
                    INSERT INTO Score (student_id, class_id, score, created_date)
                    VALUES ('{studentId}', '{classId}', {score.ToString(System.Globalization.CultureInfo.InvariantCulture)}, GETDATE())";

                dtBase.UpdateData(cmd);
            }

            MessageBox.Show(" Lưu điểm thành công!", "Thông báo");
        }
        private void ExportDataGridViewToExcel(DataGridView dgv, string title)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show(" Không có dữ liệu để xuất!", "Thông báo");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook workbook = excelApp.Workbooks.Add(Missing.Value);
                Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet;
                sheet.Name = "Export";

                sheet.Cells[1, 1] = title;
                Excel.Range titleRange = sheet.get_Range("A1", "A1");
                titleRange.Font.Bold = true;
                titleRange.Font.Size = 16;
                titleRange.Font.Color = Color.Blue;
                titleRange.EntireRow.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sheet.Cells[3, i + 1] = dgv.Columns[i].HeaderText;
                    Excel.Range headerCell = sheet.Cells[3, i + 1];
                    headerCell.Font.Bold = true;
                    headerCell.Interior.Color = ColorTranslator.ToOle(Color.LightBlue);
                    headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        var cellValue = dgv.Rows[i].Cells[j].Value;
                        string output = "";

                        if (dgv.Columns[j] is DataGridViewCheckBoxColumn)
                        {
                            bool isChecked = Convert.ToBoolean(cellValue ?? false);
                            output = isChecked ? "X" : "";
                        }
                        else
                        {
                            output = cellValue?.ToString() ?? "";
                        }

                        sheet.Cells[i + 4, j + 1] = output;
                        var dataCell = sheet.Cells[i + 4, j + 1];
                        dataCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        dataCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }

                Excel.Range usedRange = sheet.UsedRange;
                usedRange.Columns.AutoFit();
                usedRange.Rows.AutoFit();

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"{title}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    workbook.Close();
                    excelApp.Quit();
                    MessageBox.Show(" Xuất dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    workbook.Close(false);
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi khi xuất Excel:\n" + ex.Message, "Lỗi");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dgvAttendance, $"DiemDanh_{className}");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dgvScores, $"Diem_{className}");
        }
    }
}
