namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the International reference ellipsoid.
  /// </summary>
  public sealed class InternationalEllipsoid : Ellipsoid<InternationalEllipsoid>
  {  
    /**
     * Create an object defining the International reference ellipsoid.
     * 
     * @since 1.1
     */
    public InternationalEllipsoid() : base(6378388, 6356911.9462)
    {
    }
  }
}