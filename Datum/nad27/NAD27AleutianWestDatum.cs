using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Aleutian West) datum.
  /// </summary>
  public sealed class NAD27AleutianWestDatum : Datum<NAD27AleutianWestDatum>
  {   
    /**
     * Create a new NAD27 (Aleutian West) datum object.
     * 
     * @since 1.1
     */
    public NAD27AleutianWestDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Aleutian West";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = 2.0;
      dy = 204.0;
      dz = 105.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
