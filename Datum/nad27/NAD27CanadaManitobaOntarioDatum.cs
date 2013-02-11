using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Canada Manitoba/Ontario) datum.
  /// </summary>
  public sealed class NAD27CanadaManitobaOntarioDatum : Datum<NAD27CanadaManitobaOntarioDatum>
  {
    /**
     * Create a new NAD27 (Canada Manitoba/Ontario) datum object.
     * 
     */
    public NAD27CanadaManitobaOntarioDatum()
    {
      name = "North American Datum 1927 (NAD27) - Canada Manitoba/Ontario";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -9.0;
      dy = 157.0;
      dz = 184.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}
