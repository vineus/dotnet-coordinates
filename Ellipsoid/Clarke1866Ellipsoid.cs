namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Clarke 1866 reference ellipsoid.
  /// </summary>
  public sealed class Clarke1866Ellipsoid : Ellipsoid<Clarke1866Ellipsoid>
  {  
    /**
     * Create an object defining the Clarke 1866 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Clarke1866Ellipsoid() : base(6378206.4, 6356583.8)
    {
    }
  }
}