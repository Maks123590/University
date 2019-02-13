namespace StudentBookClassLibrary
{
    using System;
    using System.Text;

    public class Student
    {
        public Student(int id, string firstName, string lastName, string middleName, DateTime birthday, string address, string phone, string faculty, int studyYearsCount, string group)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Birthday = birthday;
            this.Address = address;
            this.Phone = phone;
            this.Faculty = faculty;
            this.StudyYearsCount = studyYearsCount;
            this.Group = group;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Faculty { get; set; }

        public int StudyYearsCount { get; set; }

        public string Group { get; set; }

        public override string ToString()
        {
            var properties = this.GetType().GetProperties();

            var strBuilder = new StringBuilder();
            
            foreach (var property in properties)
            {
                strBuilder.Append($"{property.Name}: {property.GetValue(this)}\n");
            }

            return strBuilder.ToString();
        }
    }
}
