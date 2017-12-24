using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;



namespace WordInteractionLab5
{
    using System.Globalization;

    public partial class Form1 : Form
    {
        private Excel.Application excelApplication;

        private User[] Users;

        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        private void GenerateDataBtnClick(object sender, EventArgs e)
        {
            var userList = new List<User>
            {
                new User
                {
                    FirstName = "Иван",
                    MiddleName = "Иванович",
                    LastName = "Иванов",
                    Rate = "0.5"
                },
                new User
                {
                    FirstName = "Степан",
                    MiddleName = "Николаевич",
                    LastName = "Николаев",
                    Rate = "0.7"
                },
                new User
                {
                    FirstName = "Илья",
                    MiddleName = "Васильевич",
                    LastName = "Васильев",
                    Rate = "(почасовая)"
                },
                new User
                {
                    FirstName = "Степан",
                    MiddleName = "Николаевич",
                    LastName = "Николаев",
                    Rate = "0.7"
                },
                new User
                {
                    FirstName = "Илья",
                    MiddleName = "Васильевич",
                    LastName = "Васильев",
                    Rate = "(почасовая)"
                }
            };

            try
            {
                WriteData(userList);

                MessageBox.Show("Done!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            this.LoadData();
        }

        private void VisibleWordCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (this.visibleWordCheckBox.Checked)
            {
                this.excelApplication.Visible = true;
            }
            else
            {
                this.excelApplication.Visible = false;
            }
        }

        private void NewBookBtnClick(object sender, EventArgs e)
        {
            this.excelApplication.Workbooks.Add();
        }

        private void ToBookBtnClick(object sender, EventArgs e)
        {
            var workbook = this.excelApplication.ActiveWorkbook;

            var workSheet = (Worksheet)workbook.Worksheets.Item[1];

            workSheet.Cells[1, 1] = "Фамилия";
            workSheet.Cells[1, 2] = "Имя";
            workSheet.Cells[1, 3] = "Отчество";
            workSheet.Cells[1, 4] = "Ставка";

            this.excelApplication.Range["A1", "D1"].Select();

            ((Range)this.excelApplication.Selection).Borders.Weight = 4;

            for (int i = 2; i <= this.Users.Length + 1; i++)
            {
                workSheet.Cells[i, 1] = Users[i-2].LastName;
                workSheet.Cells[i, 2] = Users[i-2].FirstName;
                workSheet.Cells[i, 3] = Users[i-2].MiddleName;
                workSheet.Cells[i, 4] = Users[i-2].Rate;
            }


            workSheet.Cells[this.Users.Length + 2, 1] = "Ставка";

            var rateSumm = 0.0;

            foreach (var user in this.Users)
            {
                var rateBool = double.TryParse(user.Rate, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out var rate);

                if (rateBool)
                {
                    rateSumm += rate;
                }
            }

            workSheet.Cells[this.Users.Length + 2, 4] = rateSumm;
        }

        private void LoadData()
        {
            try
            {

                var jsonFormatter = new DataContractJsonSerializer(typeof(User[]));

                using (var fs = new FileStream("Users.json", FileMode.OpenOrCreate))
                {
                    Users = (User[]) jsonFormatter.ReadObject(fs);
                }

                AddToGrid(Users);
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        private void WriteData(IEnumerable<User> userList)
        {
            try
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(User[]));

                using (var fs = new FileStream("Users.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, userList.ToArray());
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void AddToGrid(IEnumerable<User> userList)
        {
            userBindingSource.Clear();

            foreach (var user in userList)
            {
                userBindingSource.Add(user);
            }
        }

        private void RunExelBtnClick(object sender, EventArgs e)
        {
            this.excelApplication = new Excel.Application();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
