using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Canada NW Territory) datum.
  /// </summary>
  public sealed class NAD27CanadaNWTerritoryDatum : Datum<NAD27CanadaNWTerritoryDatum> 
  {
    /**
     * Create a new NAD27 (Canada NW Territory) datum object.
     * 
     * @since 1.1
     */
    public NAD27CanadaNWTerritoryDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Canada NW Territory";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = 4.0;
      dy = 159.0;
      dz = 188.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
