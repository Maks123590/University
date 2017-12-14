using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;


namespace WordInteractionLab5
{
    public partial class Form1 : Form
    {
        private Word.Application wordApplication;

        private User[] Users;

        public Form1()
        {
            InitializeComponent();

            simpleRadioButton.Checked = true;
        }

        private void generateDataBtn_Click(object sender, EventArgs e)
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
        }

        private void runWordBtn_Click(object sender, EventArgs e)
        {
            wordApplication = new Word.Application {Visible = false};

            LoadData();
        }

        private void visibleWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wordApplication != null)
            {
                wordApplication.Visible = visibleWordCheckBox.Checked;
            }
        }

        private void newDocBtn_Click(object sender, EventArgs e)
        {
            wordApplication?.Documents.Add();
        }

        private void toDocBtn_Click(object sender, EventArgs e)
        {
            if (simpleRadioButton.Checked)
            {
                WriteSimpleFormToDoc();
            }
            else if (tableRadioButton.Checked)
            {
                WriteTableFormInDoc();
            }
            else
            {
                WriteToTemplate();
            }            
        }

        private void WriteSimpleFormToDoc()
        {
            try
            {
                wordApplication?.ActiveDocument.Range().InsertAfter(
                    "Список сотрудников\t" + "\nкафедры технологий программирования" +
                    "\n\n");

                foreach (var user in Users)
                {
                    wordApplication?.ActiveDocument.Range().InsertAfter(user.FirstName + "\t\t" +
                                                                        user.MiddleName + "\t\t" +
                                                                        user.LastName + "\t\t" +
                                                                        user.Rate + "\n");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void WriteTableFormInDoc()
        {
            try
            {
                wordApplication?.ActiveDocument.Range().InsertAfter(
                    "Список сотрудников\t" + "\nкафедры технологий программирования" +
                    "\n\n");

                if (wordApplication == null)
                {
                    return;
                }

                wordApplication.Selection.Start = wordApplication.ActiveDocument.Characters.Count;

                wordApplication.Selection.End = wordApplication.ActiveDocument.Characters.Count;

                var tempRange =
                    wordApplication.ActiveDocument.Range(wordApplication.Selection.Start,
                        wordApplication.Selection.End);

                var table = wordApplication.ActiveDocument.Tables.Add(Range: tempRange, NumRows: Users.Length, NumColumns: typeof(User).GetProperties().Length);

                var userPropertiesCount = typeof(User).GetProperties().Length;

                var userProperties = typeof(User).GetProperties();

                for (var i = 0; i < userPropertiesCount; i++)
                {
                    table.Cell(1, i + 1).Range.Text = userProperties[i].Name;
                }

                for (var i = 0; i < Users.Length; i++)
                {
                    for (var j = 0; j < userPropertiesCount; j++)
                    {
                        table.Cell(i + 1, j + 1).Range.Text = userProperties[j].GetValue(Users[i]).ToString();
                    }
                }

                MessageBox.Show("Done!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void WriteToTemplate()
        {
            var fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var document = wordApplication.Documents.Add(fileDialog.FileName);

                var table = document.Tables[1];

                //var table1 = document.Tables.Add()

                for (var i = 0; i < Users.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(i + 2, 1).Range.Text = Users[i].FirstName;
                    table.Cell(i + 2, 2).Range.Text = Users[i].MiddleName;
                    table.Cell(i + 2, 3).Range.Text = Users[i].LastName;
                    table.Cell(i + 2, 4).Range.Text = Users[i].Rate;
                }
            }

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
                throw;
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
    }
}
