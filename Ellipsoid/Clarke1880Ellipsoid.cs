namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Clarke 1880 reference ellipsoid.
  /// </summary>
  public sealed class Clarke1880Ellipsoid : Ellipsoid<Clarke1880Ellipsoid>
  {  
    /**
     * Create an object defining the Clarke 1880 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Clarke1880Ellipsoid() : base(6378249.145, 6356514.8696)
    {
    }
  }
}