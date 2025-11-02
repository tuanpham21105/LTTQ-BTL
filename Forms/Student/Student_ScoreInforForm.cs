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
using AntdUI;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;
using Label = AntdUI.Label;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_ScoreInforForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();
        public Student_ScoreInforForm()
        {
            InitializeComponent();
            comboboxClasses.DataSource = dataProcessor.GetDataTable($"select Class.* from Class inner join ClassAssignment on Class.id = ClassAssignment.class_id where ClassAssignment.student_id = '{GlobalData.Id}'");
            comboboxClasses.DisplayMember = "id";
            comboboxClasses.ValueMember = "id";
            comboboxClasses.SelectedIndex = -1;
        }

        private void Student_ScoreInforForm_Load(object sender, EventArgs e)
        {
            FormUtils.ClearChartPoint(chartScore);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxClasses.SelectedIndex == -1)
            {
                return;
            }

            if (comboboxClasses.SelectedValue.ToString() != null && !Guid.TryParse(comboboxClasses.SelectedValue.ToString(), out Guid guidValue))
            {
                return;
            }

            DataTable bangdiem = dataProcessor.GetDataTable($"select * from Score where student_id = '{GlobalData.Id}' and class_id = CONVERT(uniqueidentifier,'{comboboxClasses.SelectedValue.ToString()}')");

            if (bangdiem.Rows.Count == 0 )
            {
                FormUtils.ClearChartPoint(chartScore);
                labelAverage.Text = "0";
                labelNumbers.Text = "0";
            }
            else
            {
                double avgScore = (double)bangdiem.AsEnumerable().Average(row => row.Field<decimal>("score"));
                labelAverage.Text = avgScore.ToString();
                labelNumbers.Text = bangdiem.Rows.Count.ToString();
                foreach (DataRow row in bangdiem.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(row["created_date"]);
                    double diem = Convert.ToDouble(row["score"]);
                    chartScore.Series["Score"].Points.AddXY(ngay, diem);
                }

                chartScore.Update();
                chartScore.Refresh();
            }
        }
    }
}
