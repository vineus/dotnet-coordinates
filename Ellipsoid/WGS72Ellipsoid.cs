namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the WGS72 reference ellipsoid.
  /// </summary>
  public sealed class WGS72Ellipsoid : Ellipsoid<WGS72Ellipsoid>
  {  
    /**
     * Create an object defining the WGS72 reference ellipsoid.
     * 
     * @since 1.1
     */
    public WGS72Ellipsoid() : base(6378135, 6356750.5) 
    {
    }
  }
}