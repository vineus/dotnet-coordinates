using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Canada) datum.
  /// </summary>
  public sealed class NAD27CanadaDatum : Datum<NAD27CanadaDatum>
  {  
    /**
     * Create a new NAD27 (Canada) datum object.
     * 
     * @since 1.1
     */
    public NAD27CanadaDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Canada";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -10.0;
      dy = 158.0;
      dz = 187.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
