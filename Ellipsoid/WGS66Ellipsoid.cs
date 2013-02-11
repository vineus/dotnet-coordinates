namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the WGS66 reference ellipsoid.
  /// </summary>
  public sealed class WGS66Ellipsoid : Ellipsoid<WGS66Ellipsoid>
  {     
    /**
     * Create an object defining the WGS66 reference ellipsoid.
     * 
     * @since 1.1
     */
    public WGS66Ellipsoid() : base(6378145.0, 6356759.770)
    {
    }
  }
}