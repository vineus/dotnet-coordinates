namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the WGS60 reference ellipsoid.
  /// </summary>
  public sealed class WGS60Ellipsoid : Ellipsoid<WGS60Ellipsoid>
  {  
    /**
     * Create an object defining the WGS60 reference ellipsoid.
     * 
     * @since 1.1
     */
    public WGS60Ellipsoid() : base(6378165.0, 6356783.287)
    {
    }
  }
}