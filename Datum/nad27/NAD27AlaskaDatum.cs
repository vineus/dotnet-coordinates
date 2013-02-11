using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Alaska) datum.
  /// </summary>
  public sealed class NAD27AlaskaDatum : Datum<NAD27AlaskaDatum>
  {
    /**
     * Create a new NAD27 (Alaska) datum object.
     * 
     */
    public NAD27AlaskaDatum()
    {
      name = "North American Datum 1927 (NAD27) - Alaska";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -5.0;
      dy = 135.0;
      dz = 172.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
