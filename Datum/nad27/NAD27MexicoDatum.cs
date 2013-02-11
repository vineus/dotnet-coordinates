using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Mexico) datum.
  /// </summary>
  public sealed class NAD27MexicoDatum : Datum<NAD27MexicoDatum>
  {  
    /**
     * Create a new NAD27 (Mexico) datum object.
     * 
     * @since 1.1
     */
    public NAD27MexicoDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Mexico";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -12.0;
      dy = 130.0;
      dz = 190.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
