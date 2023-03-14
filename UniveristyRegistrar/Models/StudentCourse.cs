namespace UniversityRegistrar.Models
{
  public class StudentCourse
  {
    public int StudentCourseId { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public Boolean Completed { get; set; } = false;
    public int CourseId { get; set; }
    public Course Course { get; set; }
  }
}