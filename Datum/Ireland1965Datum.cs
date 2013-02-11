using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum
{
  /// <summary>
  /// Class representing the Ireland 1965 datum.
  /// </summary>
  public sealed class Ireland1965Datum : Datum<Ireland1965Datum>
  {  
    /**
     * Create a new Ireland 1965 Datum object.
     * 
     * @since 1.1
     */
    public Ireland1965Datum()
    {
      name = "Ireland 1965";
      ellipsoid = ModifiedAiryEllipsoid.Instance;
      dx = 482.53;
      dy = -130.596;
      dz = 564.557;
      ds = 8.15;
      rx = -1.042;
      ry = -0.214;
      rz = -0.631;
    }
  }
}
