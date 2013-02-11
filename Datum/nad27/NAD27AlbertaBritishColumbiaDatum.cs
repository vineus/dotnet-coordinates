using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Alberta and British Columbia) datum.
  /// </summary>
  public sealed class NAD27AlbertaBritishColumbiaDatum : Datum<NAD27AlbertaBritishColumbiaDatum>
  {  
    /**
     * Create a new NAD27 (Alberta and British Columbia) datum object.
     * 
     */
    public NAD27AlbertaBritishColumbiaDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Alberta and British Columbia";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -7.0;
      dy = 162.0;
      dz = 188.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
