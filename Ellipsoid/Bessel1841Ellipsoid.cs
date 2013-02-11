namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Bessel 1841 reference ellipsoid.
  /// </summary>
  public sealed class Bessel1841Ellipsoid : Ellipsoid<Bessel1841Ellipsoid>
  {  
    /**
     * Create an object defining the Bessel 1841 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Bessel1841Ellipsoid() : base(6377397.155, 6356078.9629)
    {
    }
  }
}