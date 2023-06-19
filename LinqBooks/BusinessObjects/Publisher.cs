using System.Drawing;

namespace LinqBooks.BusinessObjects
{
  public class Publisher
  {
    public String Name {get; set;}
    public Bitmap Logo {get; set;}
    public String WebSite {get; set;}

    public override string ToString()
    {
      return Name;
    }
  }
}
