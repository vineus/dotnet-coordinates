namespace DotNetCoords.Ellipsoid
{
  /// <summary>
  /// Class defining the Modified Airy reference ellipsoid.
  /// </summary>
  public sealed class ModifiedAiryEllipsoid : Ellipsoid<ModifiedAiryEllipsoid>
  { 
    /**
     * Create an object defining the Modified Airy reference ellipsoid.
     * 
     * @since 1.1
     */
    public ModifiedAiryEllipsoid() : base(6377340.189, double.NaN, 0.00667054015)
    {
    }
  }
}
