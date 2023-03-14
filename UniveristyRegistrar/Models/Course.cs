namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string Title { get; set; }
    public List<StudentCourse> JoinEntitiesStudentCourses { get; }
    public List<CourseDepartment> JoinEntitiesCourseDepartments { get; }
  }
}