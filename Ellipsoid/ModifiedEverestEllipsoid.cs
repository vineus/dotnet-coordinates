namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Modified Everest reference ellipsoid.
  /// </summary>
  public sealed class ModifiedEverestEllipsoid : Ellipsoid<ModifiedEverestEllipsoid>
  {  
    /**
     * Create an object defining the Modified Everest reference ellipsoid.
     * 
     * @since 1.1
     */
    public ModifiedEverestEllipsoid() : base(6377304.063, 6356103.039)
    {
    }
  }
}