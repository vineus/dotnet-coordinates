namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the GRS75 reference ellipsoid.
  /// </summary>
  public sealed class GRS75Ellipsoid : Ellipsoid<GRS75Ellipsoid>
  {  
    /**
     * Create an object defining the GRS75 reference ellipsoid.
     * 
     * @since 1.1
     */
    public GRS75Ellipsoid() : base(6378140.0, 6356755.288)
    {
    }
  }
}