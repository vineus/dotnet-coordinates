namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Helmert 1906 reference ellipsoid.
  /// </summary>
  public sealed class Helmert1906Ellipsoid : Ellipsoid<Helmert1906Ellipsoid>
  {  
    /**
     * Create an object defining the Helmert 1906 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Helmert1906Ellipsoid() : base(6378200.0, 6356818.17)
    {
    }
  }
}