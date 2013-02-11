namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Fischer 1968 reference ellipsoid.
  /// </summary>
  public sealed class Fischer1968Ellipsoid : Ellipsoid<Fischer1968Ellipsoid>
  {  
    /**
     * Create an object defining the Fischer 1968 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Fischer1968Ellipsoid() : base(6378150.0, 6356768.337)
    {
    }
  }
}