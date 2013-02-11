namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the WGS84 reference ellipsoid.
  /// </summary>
  public sealed class WGS84Ellipsoid : Ellipsoid<WGS84Ellipsoid>
  {  
    /**
     * Create an object defining a WGS84 reference ellipsoid.
     * 
     * @since 1.1
     */
    public WGS84Ellipsoid() : base(6378137, 6356752.3142)
    {
    }
  }
}