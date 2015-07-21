using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Instructor: Person
    {
        public DateTime HireDate { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }

    public class CourseInstructor
    {
        public virtual int CourseId { get; set; }
        public virtual int InstructorId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}