namespace StudentBookClassLibrary
{
    using System;

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

        [ToStringName("Имя")]
        public string FirstName { get; set; }

        [ToStringName("Фамилия")]
        public string LastName { get; set; }

        [ToStringName("Отчество")]
        public string MiddleName { get; set; }

        [ToStringName("Дата рождения")]
        public DateTime Birthday { get; set; }

        [ToStringName("Адрес")]
        public string Address { get; set; }

        [ToStringName("Телефон")]
        public string Phone { get; set; }

        [ToStringName("Факультет")]
        public string Faculty { get; set; }

        [ToStringName("Курс")]
        public int StudyYearsCount { get; set; }

        [ToStringName("Группа")]
        public string Group { get; set; }

        public override string ToString()
        {
            return ToStringHelper<Student>.ToString(this);
        }
    }
}
