using System.Collections.Generic;
namespace Factory.Models
{
  public class Liscence
  {
    public int LiscenceId { get; set; }
    public string LiscenceDetail { get; set; }
    public List<EngineerLiscence> JoinEntities { get; }
  }
}