using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Western US) datum.
  /// </summary>
  public sealed class NAD27WesternUSDatum : Datum<NAD27WesternUSDatum>
  {  
    /**
     * Create a new NAD27 (Western US) datum object.
     * 
     * @since 1.1
     */
    public NAD27WesternUSDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Western US";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -8.0;
      dy = 159.0;
      dz = 175.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
