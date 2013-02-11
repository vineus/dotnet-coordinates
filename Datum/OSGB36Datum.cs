using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum
{
  /// <summary>
  /// Class representing the Ordnance Survey of Great Britain 1936 (OSGB36) datum.
  /// </summary>
  public sealed class OSGB36Datum : Datum<OSGB36Datum>
  {
    /**
     * Create a new OSGB36 object.
     * 
     * @since 1.1
     */
    public OSGB36Datum()
    {
      name = "Ordnance Survey of Great Britain 1936 (OSGB36)";
      ellipsoid = Airy1830Ellipsoid.Instance;
      dx = 446.448;
      dy = -125.157;
      dz = 542.06;
      ds = -20.4894;
      rx = 0.1502;
      ry = 0.2470;
      rz = 0.8421;
    }
  }
}
