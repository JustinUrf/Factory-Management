using System.Collections.Generic;
namespace Factory.Models
{
  public class License
  {
    public int LicenseId { get; set; }
    public string licenseDetail { get; set; }
    public List<EngineerLicense> JoinEntities { get; }
  }
}