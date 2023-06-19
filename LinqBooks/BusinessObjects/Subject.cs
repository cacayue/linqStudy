namespace LinqBooks.BusinessObjects
{
  public class Subject
  {
    public String Description {get; set;}
    public String Name {get; set;}

    public override string ToString()
    {
      return Name;
    }
  }
}