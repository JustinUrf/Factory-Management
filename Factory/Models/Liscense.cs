using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class License
  {
    public int LicenseId { get; set; }
    [Required(ErrorMessage = "This field cannot be empty")]
    public string LicenseDetail { get; set; }
    public List<EngineerLicense> JoinEntities { get; }
  }
}