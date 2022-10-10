using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string CourseNum { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
  }
}
