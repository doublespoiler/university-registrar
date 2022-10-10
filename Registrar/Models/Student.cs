using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }
    [DataType(DataType.Date)]
    public DateTime EnrollDate { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department department { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get;}
  }
}