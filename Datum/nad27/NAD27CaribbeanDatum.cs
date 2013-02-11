using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Caribbean) datum.
  /// </summary>
  public sealed class NAD27CaribbeanDatum : Datum<NAD27CaribbeanDatum>
  {  
    /**
     * Create a new NAD27 (Caribbean) datum object.
     * 
     * @since 1.1
     */
    public NAD27CaribbeanDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Caribbean";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -3.0;
      dy = 142.0;
      dz = 183.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
