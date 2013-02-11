using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;
using System;

namespace DotNetCoords
{
  /// <summary>
  /// ECEF (earth-centred, earth-fixed) Cartesian co-ordinates are used to define a
  /// point in three-dimensional space. ECEF co-ordinates are defined relative to
  /// an x-axis (the intersection of the equatorial plane and the plane defined by
  /// the prime meridian), a y-axis (at 90° to the x-axis and its intersection
  /// with the equator) and a z-axis (intersecting the North Pole). All the axes
  /// intersect at the point defined by the centre of mass of the Earth.
  /// </summary>
  public class ECEFRef : CoordinateSystem 
  {
    /**
     * x co-ordinate in metres.
     */
    private double x;

    /**
     * y co-ordinate in metres.
     */
    private double y;

    /**
     * z co-ordinate in metres.
     */
    private double z;

    /// <summary>
    /// Create a new earth-centred, earth-fixed (ECEF) reference from the given
    /// parameters using the WGS84 reference ellipsoid.
    /// </summary>
    /// <param name="x">The x co-ordinate.</param>
    /// <param name="y">The y co-ordinate.</param>
    /// <param name="z">The z co-ordinate.</param>
    public ECEFRef(double x, double y, double z) : this(x, y, z, WGS84Datum.Instance)
    { 
    }

    /// <summary>
    /// Create a new earth-centred, earth-fixed (ECEF) reference from the given
    /// parameters and the given reference ellipsoid.
    /// </summary>
    /// <param name="x">The x co-ordinate.</param>
    /// <param name="y">The y co-ordinate.</param>
    /// <param name="z">The z co-ordinate.</param>
    /// <param name="datum">The datum.</param>
    public ECEFRef(double x, double y, double z, DotNetCoords.Datum.Datum datum) : base(datum)
    {
      X = x;
      Y = y;
      Z = z; 
    }


    /// <summary>
    /// Create a new earth-centred, earth-fixed reference from the given latitude
    /// and longitude.
    /// </summary>
    /// <param name="ll">The latitude and longitude.</param>
    public ECEFRef(LatLng ll) : base(ll.Datum)
    {
      DotNetCoords.Ellipsoid.Ellipsoid ellipsoid = Datum.ReferenceEllipsoid;

      double phi = Util.ToRadians(ll.Latitude);
      double lambda = Util.ToRadians(ll.Longitude);
      double h = ll.Height;
      double a = ellipsoid.SemiMajorAxis;
      double f = ellipsoid.Flattening;
      double eSquared = (2 * f) - (f * f);
      double nphi = a / Math.Sqrt(1 - eSquared * Util.sinSquared(phi));

      X = (nphi + h) * Math.Cos(phi) * Math.Cos(lambda);
      Y = (nphi + h) * Math.Cos(phi) * Math.Sin(lambda);
      Z = (nphi * (1 - eSquared) + h) * Math.Sin(phi);
    }

    /// <summary>
    /// Convert this ECEFRef object to a point represented
    /// by a latitude and longitude and a perpendicular height above (or below) a
    /// reference ellipsoid.
    /// </summary>
    /// <returns>
    /// The equivalent latitude and longitude.
    /// </returns>
    public override LatLng ToLatLng() 
    {
      DotNetCoords.Ellipsoid.Ellipsoid ellipsoid = Datum.ReferenceEllipsoid;
      
      double a = ellipsoid.SemiMajorAxis;
      double b = ellipsoid.SemiMinorAxis;
      double e2Squared = ((a * a) - (b * b)) / (b * b);
      double f = ellipsoid.Flattening;
      double eSquared = (2 * f) - (f * f);
      double p = Math.Sqrt((x * x) + (y * y));
      double theta = Math.Atan((z * a) / (p * b));

      double phi = Math.Atan((z + (e2Squared * b * Util.sinCubed(theta)))
          / (p - eSquared * a * Util.cosCubed(theta)));
      double lambda = Math.Atan2(y, x);

      double nphi = a / Math.Sqrt(1 - eSquared * Util.sinSquared(phi));
      double h = (p / Math.Cos(phi)) - nphi;

      return new LatLng(Util.ToDegrees(phi), Util.ToDegrees(lambda), h,
          WGS84Datum.Instance);
    }

    /// <summary>
    /// Gets or sets the x co-ordinate.
    /// </summary>
    /// <value>The x co-ordinate.</value>
    public double X 
    {
      get
      {
        return x;
      }
      set
      {
        x = value;
      }
    }

    /// <summary>
    /// Gets or sets the y co-ordinate.
    /// </summary>
    /// <value>The y co-ordinate.</value>
    public double Y 
    {
      get
      {
        return y;
      }
      set
      {
        y = value;
      }
    }


    /// <summary>
    /// Gets or sets the the z co-ordinate.
    /// </summary>
    /// <value>The the z co-ordinate.</value>
    public double Z 
    {
      get
      {
        return z;
      }
      set
      {
        z = value;
      }
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current ECEF reference.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current ECEF reference.
    /// </returns>
    public override string ToString() 
    {
      return "(" + x + "," + y + "," + z + ")";
    }
  }
}
