namespace Task4
{
    using System.Collections;
    using System.Collections.Generic;

    using StudentBookClassLibrary;

    public class StudentList
    {
        public StudentList(IEnumerable<Student> students)
        {
            this.Students = students;
        }

        private IEnumerable<Student> Students { get; }

        public IEnumerator GetEnumerator()
        {
            return this.Students.GetEnumerator();
        }
    }
}