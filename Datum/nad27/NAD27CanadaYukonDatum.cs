using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Canada Yukon) datum.
  /// </summary>
  public sealed class NAD27CanadaYukonDatum : Datum<NAD27CanadaYukonDatum>
  {  
    /**
     * Create a new NAD27 (Canada Yukon) datum object.
     * 
     * @since 1.1
     */
    public NAD27CanadaYukonDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Canada Yukon";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -7.0;
      dy = 139.0;
      dz = 181.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
