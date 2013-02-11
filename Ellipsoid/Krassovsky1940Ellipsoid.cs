namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Krassovsky 1940 reference ellipsoid.
  /// </summary>
  public sealed class Krassovsky1940Ellipsoid : Ellipsoid<Krassovsky1940Ellipsoid>
  {
    /**
     * Create an object defining the Krassovsky 1940 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Krassovsky1940Ellipsoid() : base(6378245.0, 6356863.019)
    {
    }
  }
}