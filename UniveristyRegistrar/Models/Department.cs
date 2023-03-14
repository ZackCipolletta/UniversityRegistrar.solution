using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    [Required(ErrorMessage = "Department name cannot be empty. Please enter a name.")]
    public string Name { get; set; }
    public int DepartmentID { get; set; }
    public List<StudentDepartment> JoinEntitiesStudentDepartments { get; }
    public List<CourseDepartment> JoinEntitiesCourseDepartments { get; }
  }
}
