namespace DotNetCoords.Ellipsoid
{

  /// <summary>
  /// Class defining the Fischer 1960 reference ellipsoid.
  /// </summary>
  public sealed class Fischer1960Ellipsoid : Ellipsoid<Fischer1960Ellipsoid>
  {  
    /**
     * Create an object defining the Fischer 1960 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Fischer1960Ellipsoid() : base(6378166.0, 6356784.284)
    {
    }
  }
}