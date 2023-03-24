using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineers name cannot be empty")]
    public string Name { get; set; }
    public List<EngineerLicense> JoinEntities { get; }
  }
}