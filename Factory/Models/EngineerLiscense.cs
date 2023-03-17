using System.Collections.Generic;

namespace Factory.Models
{
  public class EngineerLiscence
  {
    public int EngineerLiscenceId { get; set; }
    public int EngineerId { get; set; }
    public int LiscenceId { get; set; }
    public Engineer Engineer { get; set; }
    public Liscence Liscence { get; set; } 
  }
}