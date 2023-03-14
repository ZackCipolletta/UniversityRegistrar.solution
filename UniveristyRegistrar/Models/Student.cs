using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public string Description { get; set; }
    public int StudentId { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public Boolean Completed { get; set; } = false;
    public List<StudentCourse> JoinEntities { get; }
  }
}
