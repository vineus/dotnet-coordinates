namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the New International 1967 reference ellipsoid.
  /// </summary>
  public sealed class NewInternational1967Ellipsoid : Ellipsoid<NewInternational1967Ellipsoid>
  {  
    /**
     * Create an object defining the Ne wInternational 1967 reference ellipsoid.
     * 
     * @since 1.1
     */
    public NewInternational1967Ellipsoid() : base(6378157.5, 6356772.2)
    {
    }
  }
}