namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Hayford 1910 reference ellipsoid.
  /// </summary>
  public sealed class Hayford1910Ellipsoid : Ellipsoid<Hayford1910Ellipsoid>
  {  
    /**
     * Create an object defining the Hayford 1910 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Hayford1910Ellipsoid() : base(6378388.0, 6356911.946)
    {
    }
  }
}