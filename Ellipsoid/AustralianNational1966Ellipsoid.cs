namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Australian National 1966 reference ellipsoid.
  /// </summary>
  public sealed class AustralianNational1966Ellipsoid : Ellipsoid<AustralianNational1966Ellipsoid>
  {
    /**
     * Create an object defining the Australian National 1966 reference ellipsoid.
     * 
     * @since 1.1
     */
    public AustralianNational1966Ellipsoid()
      : base(6378160.0, 6356774.719) 
    {
    }
  }
}