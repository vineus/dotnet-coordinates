namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the IERS 1989 reference ellipsoid.
  /// </summary>
  public sealed class IERS1989Ellipsoid : Ellipsoid<IERS1989Ellipsoid>
  {  
    /**
     * Create an object defining the IERS 1989 reference ellipsoid.
     * 
     * @since 1.1
     */
    public IERS1989Ellipsoid() : base(6378136.0, 6356751.302)
    {
    }
  }
}