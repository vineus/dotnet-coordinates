namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the South American 1969 reference ellipsoid.
  /// </summary>
  public sealed class SouthAmerican1969Ellipsoid : Ellipsoid<SouthAmerican1969Ellipsoid>
  {
    /**
     * Create an object defining the South American 1969 reference ellipsoid.
     * 
     * @since 1.1
     */
    public SouthAmerican1969Ellipsoid()
      : base(6378160.0, 6356774.7192)
    {
    }
  }
}