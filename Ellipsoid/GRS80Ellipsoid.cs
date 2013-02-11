namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the GRS80 reference ellipsoid.
  /// </summary>
  public sealed class GRS80Ellipsoid : Ellipsoid<GRS80Ellipsoid>
  {  
    /**
     * Create an object defining the GRS80 reference ellipsoid.
     * 
     * @since 1.1
     */
    public GRS80Ellipsoid() : base(6378137, 6356752.3141)
    {
    }
  }
}