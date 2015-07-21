namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        //[Key]
        //[ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}