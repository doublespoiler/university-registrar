namespace Registrar.Models
{
  public class CourseStudent
  {
    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public virtual Course course { get; set; }
    public virtual Student student { get; set; }
  }
}