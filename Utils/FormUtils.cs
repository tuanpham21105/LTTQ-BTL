using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.IO;

namespace prj_LTTQ_BTL.Utils
{
    internal class FormUtils
    {
        public static void OpenChildForm(Guna2Panel parentPanel, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(childForm);
            parentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void FillGunaDgv(Guna2DataGridView dgv, DataTable data)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = data;
        }

        public static void ClearChartPoint(Chart chart)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        public static string UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                string fileName = Path.GetFileName(sourceFilePath);

                string destFolder = Path.Combine(Application.StartupPath, "Images");

                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                string destFilePath = Path.Combine(destFolder, fileName);

                File.Copy(sourceFilePath, destFilePath, true);

                return Path.Combine("Images", fileName);
            }

            return "";
        }

        public static void LoadImage(PictureBox pictureBox, string path)
        {
            pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, path));
        }
    }
}
