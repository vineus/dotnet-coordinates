namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Airy 1830 reference ellipsoid.
  /// </summary>
  public sealed class Airy1830Ellipsoid : Ellipsoid<Airy1830Ellipsoid>
  {  
    /**
     * Create an object defining the Airy 1830 reference ellipsoid.
     * 
     * @since 1.1
     */
    public Airy1830Ellipsoid() : base(6377563.396, 6356256.909)
    {
    }
  }
}