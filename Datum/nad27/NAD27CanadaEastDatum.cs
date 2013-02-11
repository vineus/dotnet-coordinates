using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Canada East) datum.
  /// </summary>
  public sealed class NAD27CanadaEastDatum : Datum<NAD27CanadaEastDatum>
  {
    /**
     * Create a new NAD27 (Canada East) datum object.
     * 
     */
    public NAD27CanadaEastDatum()
    {
      name = "North American Datum 1927 (NAD27) - Canada East";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -22.0;
      dy = 160.0;
      dz = 190.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
