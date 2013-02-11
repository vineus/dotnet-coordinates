using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Contiguous United States) datum.
  /// </summary>
  public sealed class NAD27ContiguousUSDatum : Datum<NAD27ContiguousUSDatum>
  { 
    /**
     * Create a new NAD27 (Contiguous United States) datum object.
     * 
     * @since 1.1
     */
    public NAD27ContiguousUSDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Contiguous United States";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -8.0;
      dy = 160.0;
      dz = 176.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
