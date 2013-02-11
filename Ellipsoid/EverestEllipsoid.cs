namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Everest 1830 reference ellipsoid.
  /// </summary>
  public sealed class EverestEllipsoid : Ellipsoid<EverestEllipsoid>
  {  
    /**
     * Create an object defining the Everest 1830 reference ellipsoid.
     * 
     * @since 1.1
     */
    public EverestEllipsoid() : base(6377276.34518, 6356075.41511) 
    {
    }
  }
}