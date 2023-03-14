using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    [Required(ErrorMessage = "Student name cannot be empty. Please enter a name.")]
    public string Description { get; set; }
    public int StudentId { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public Boolean Completed { get; set; } = false;
    public List<StudentCourse> JoinEntitiesStudentCourses { get; }
    public List<StudentDepartment> JoinEntitiesStudentDepartments { get; }
  }
}
