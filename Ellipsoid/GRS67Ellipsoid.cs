namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the GRS67 reference ellipsoid.
  /// </summary>
  public sealed class GRS67Ellipsoid : Ellipsoid<GRS67Ellipsoid>
  {  
    /**
     * Create an object defining the GRS67 reference ellipsoid.
     * 
     * @since 1.1
     */
    public GRS67Ellipsoid() : base(6378160.0, 6356774.51609) 
    {
    }
  }
}