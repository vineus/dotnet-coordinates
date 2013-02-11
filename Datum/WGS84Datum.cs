using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum
{
  /// <summary>
  /// Class representing the World Geodetic System 1984 (WGS84) datum.
  /// </summary>
  public class WGS84Datum : Datum<WGS84Datum>
  {  
    /**
     * Create a new WGS84 object.
     * 
     * @since 1.1
     */
    public WGS84Datum() 
    {
      name = "World Geodetic System 1984 (WGS84)";
      ellipsoid = WGS84Ellipsoid.Instance;
      dx = 0.0;
      dy = 0.0;
      dz = 0.0;
      ds = 1.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
