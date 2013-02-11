using DotNetCoords.Datum;
using DotNetCoords.Ellipsoid;
using System;

namespace DotNetCoords
{
  /// <summary>
  /// Enumerated type defining whether a latitude is North or South of the equator
  /// </summary>
  public enum NorthSouth
  {
    /// <summary>
    /// Latitude is north of the equator.
    /// </summary>
    North=1,
    /// <summary>
    /// Latitude is south of the equator.
    /// </summary>
    South=-1
  }

  /// <summary>
  /// Enumerated type defining whether a longitude is east or west of the prime meridian
  /// </summary>
  public enum EastWest
  {
    /// <summary>
    /// Longitude is east of the prime meridian
    /// </summary>
    East = 1,
    /// <summary>
    /// Longitude is west of the prime meridian
    /// </summary>
    West = -1
  }

  /// <summary>
  /// Class to represent a latitude/longitude pair based on a particular datum.
  /// </summary>
  public class LatLng 
  {
    /**
     * Latitude in degrees.
     */
    private double latitude;

    /**
     * Longitude in degrees.
     */
    private double longitude;

    /**
     * Height.
     */
    private double height;

    /**
     * Datum of this reference.
     */
    private DotNetCoords.Datum.Datum datum = WGS84Datum.Instance;

    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// WGS84 datum.
    /// </summary>
    /// <param name="latitude">The latitude in degrees. Must be between -90.0 and 90.0 inclusive.
    /// -90.0 and 90.0 are effectively equivalent.</param>
    /// <param name="longitude">The longitude in degrees. Must be between -180.0 and 180.0
    /// inclusive. -180.0 and 180.0 are effectively equivalent.</param>
    /// <exception cref="ArgumentException">If either the given latitude or the given longitude are invalid.</exception>
    public LatLng(double latitude, double longitude) : this(latitude, longitude, 0, WGS84Datum.Instance)
    {
    }

    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// WGS84 datum.
    /// </summary>
    /// <param name="latitude">The latitude in degrees. Must be between -90.0 and 90.0 inclusive.
    /// -90.0 and 90.0 are effectively equivalent.</param>
    /// <param name="longitude">The longitude in degrees. Must be between -180.0 and 180.0
    /// inclusive. -180.0 and 180.0 are effectively equivalent.</param>
    /// <param name="height">The perpendicular height above the reference ellipsoid.</param>
    /// <exception cref="ArgumentException">If either the given latitude or the given longitude are invalid.</exception>
    public LatLng(double latitude, double longitude, double height) : 
      this(latitude, longitude, height, WGS84Datum.Instance)
    {
    }

    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// WGS84 datum.
    /// </summary>
    /// <param name="latitudeDegrees">The degrees part of the latitude. Must be 0 &lt;= latitudeDegrees &lt;=
    /// 90.0.</param>
    /// <param name="latitudeMinutes">The minutes part of the latitude. Must be 0 &lt;= latitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="latitudeSeconds">The seconds part of the latitude. Must be 0 &lt;= latitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="northSouth">Whether the latitude is north or south of the equator.</param>
    /// <param name="longitudeDegrees">The degrees part of the longitude. Must be 0 &lt;= longitudeDegrees &lt;=
    /// 180.0.</param>
    /// <param name="longitudeMinutes">The minutes part of the longitude. Must be 0 &lt;= longitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="longitudeSeconds">The seconds part of the longitude. Must be 0 &lt;= longitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="eastWest">Whether the longitude is east or west of the prime meridian.</param>
    /// <exception cref="ArgumentException">If any of the parameters are invalid.</exception>
    public LatLng(int latitudeDegrees, int latitudeMinutes,
        double latitudeSeconds, NorthSouth northSouth, int longitudeDegrees,
        int longitudeMinutes, double longitudeSeconds, EastWest eastWest) :
      this(latitudeDegrees, latitudeMinutes, latitudeSeconds, northSouth,
          longitudeDegrees, longitudeMinutes, longitudeSeconds, eastWest, 0.0,
          WGS84Datum.Instance)
    {
    }

    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// WGS84 datum.
    /// </summary>
    /// <param name="latitudeDegrees">The degrees part of the latitude. Must be 0 &lt;= latitudeDegrees &lt;=
    /// 90.0.</param>
    /// <param name="latitudeMinutes">The minutes part of the latitude. Must be 0 &lt;= latitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="latitudeSeconds">The seconds part of the latitude. Must be 0 &lt;= latitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="northSouth">Whether the latitude is north or south of the equator.</param>
    /// <param name="longitudeDegrees">The degrees part of the longitude. Must be 0 &lt;= longitudeDegrees &lt;=
    /// 180.0.</param>
    /// <param name="longitudeMinutes">The minutes part of the longitude. Must be 0 &lt;= longitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="longitudeSeconds">The seconds part of the longitude. Must be 0 &lt;= longitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="eastWest">Whether the longitude is east or west of the prime meridian.</param>
    /// <param name="height">The perpendicular height above the reference ellipsoid.</param>
    /// <exception cref="ArgumentException">if any of the parameters are invalid.</exception>
    public LatLng(int latitudeDegrees, int latitudeMinutes,
        double latitudeSeconds, NorthSouth northSouth, int longitudeDegrees,
        int longitudeMinutes, double longitudeSeconds, EastWest eastWest, double height) :
      this(latitudeDegrees, latitudeMinutes, latitudeSeconds, northSouth,
          longitudeDegrees, longitudeMinutes, longitudeSeconds, eastWest, height,
          WGS84Datum.Instance)
    {
    }


    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// specified datum.
    /// </summary>
    /// <param name="latitudeDegrees">The degrees part of the latitude. Must be 0 &lt;= latitudeDegrees &lt;=
    /// 90.0.</param>
    /// <param name="latitudeMinutes">The minutes part of the latitude. Must be 0 &lt;= latitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="latitudeSeconds">The seconds part of the latitude. Must be 0 &lt;= latitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="northSouth">Whether the latitude is north or south of the equator.</param>
    /// <param name="longitudeDegrees">The degrees part of the longitude. Must be 0 &lt;= longitudeDegrees &lt;=
    /// 180.0.</param>
    /// <param name="longitudeMinutes">The minutes part of the longitude. Must be 0 &lt;= longitudeMinutes &lt;
    /// 60.0.</param>
    /// <param name="longitudeSeconds">The seconds part of the longitude. Must be 0 &lt;= longitudeSeconds &lt;
    /// 60.0.</param>
    /// <param name="eastWest">Whether the longitude is east or west of the prime meridian.</param>
    /// <param name="height">The perpendicular height above the reference ellipsoid.</param>
    /// <param name="datum">The datum that this reference is based on.</param>
    /// <exception cref="ArgumentException">if any of the parameters are invalid.</exception>
    public LatLng(int latitudeDegrees, int latitudeMinutes,
        double latitudeSeconds, NorthSouth northSouth, int longitudeDegrees,
        int longitudeMinutes, double longitudeSeconds, EastWest eastWest,
        double height, DotNetCoords.Datum.Datum datum)
    {

      if (latitudeDegrees < 0.0 || latitudeDegrees > 90.0
          || latitudeMinutes < 0.0 || latitudeMinutes >= 60.0
          || latitudeSeconds < 0.0 || latitudeSeconds >= 60.0)
      {
        throw new ArgumentException("Invalid latitude");
      }

      if (longitudeDegrees < 0.0 || longitudeDegrees > 180.0
          || longitudeMinutes < 0.0 || longitudeMinutes >= 60.0
          || longitudeSeconds < 0.0 || longitudeSeconds >= 60.0)
      {
        throw new ArgumentException("Invalid longitude");
      }

      this.latitude = (int)northSouth
          * (latitudeDegrees + (latitudeMinutes / 60.0) + (latitudeSeconds / 3600.0));
      this.longitude = (int)eastWest
          * (longitudeDegrees + (longitudeMinutes / 60.0) + (longitudeSeconds / 3600.0));
      this.height = height;
      this.datum = datum;
    }

    /// <summary>
    /// Create a new LatLng object to represent a latitude/longitude pair using the
    /// specified datum.
    /// </summary>
    /// <param name="latitude">The latitude in degrees. Must be between -90.0 and 90.0 inclusive.
    /// -90.0 and 90.0 are effectively equivalent.</param>
    /// <param name="longitude">The longitude in degrees. Must be between -180.0 and 180.0
    /// inclusive. -180.0 and 180.0 are effectively equivalent.</param>
    /// <param name="height">The perpendicular height above the reference ellipsoid.</param>
    /// <param name="datum">The datum that this reference is based on.</param>
    /// <exception cref="ArgumentException">If either the given latitude or the given longitude are invalid.</exception>
    public LatLng(double latitude, double longitude, double height, DotNetCoords.Datum.Datum datum)
    {
      if (!IsValidLatitude(latitude))
      {
        throw new ArgumentException("Latitude (" + latitude
            + ") is invalid. Must be between -90.0 and 90.0 inclusive.");
      }

      if (!IsValidLongitude(longitude))
      {
        throw new ArgumentException("Longitude (" + longitude
            + ") is invalid. Must be between -180.0 and 180.0 inclusive.");
      }

      this.latitude = latitude;
      this.longitude = longitude;
      this.height = height;
      this.datum = datum;
    }

    /// <summary>
    /// Determines whether the specified latitude is valid.
    /// </summary>
    /// <param name="latitude">The latitude.</param>
    /// <returns>
    /// 	<c>true</c> if the latitude is valid; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsValidLatitude(double latitude)
    {
      return (latitude >= -90.0 && latitude <= 90.0);
    }

    /// <summary>
    /// Determines whether the specified longitude is valid longitude.
    /// </summary>
    /// <param name="longitude">The longitude.</param>
    /// <returns>
    /// 	<c>true</c> if the longitude is valid; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsValidLongitude(double longitude)
    {
      return (longitude >= -180.0 && longitude <= 180.0);
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current LatLng object.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current LatLng object.
    /// </returns>
    public override string ToString() 
    {
      return "(" + this.latitude + ", " + this.longitude + ")";
    }

    /// <summary>
    /// Return a String representation of this LatLng object in
    /// degrees-minutes-seconds format. The returned format will be like this: DD
    /// MM SS.SSS N DD MM SS.SSS E where DD is the number of degrees, MM is the
    /// number of minutes, SS.SSS is the number of seconds, N is either N or S to
    /// indicate north or south of the equator and E is either E or W to indicate
    /// east or west of the prime meridian.
    /// </summary>
    /// <returns>A string representation of this LatLng object in DMS format.</returns>
    public string ToDMSString() 
    {
      string ret = formatLatitude() + " " + formatLongitude();

      return ret;
    }

    private string formatLatitude() 
    {
      string ns = Latitude >= 0 ? "N" : "S";
      return Math.Abs(LatitudeDegrees) + " " + LatitudeMinutes + " "
          + LatitudeSeconds + " " + ns;
    }

    private string formatLongitude() 
    {
      string ew = Longitude >= 0 ? "E" : "W";
      return Math.Abs(LongitudeDegrees) + " " + LongitudeMinutes + " "
          + LongitudeSeconds + " " + ew;
    }

    /// <summary>
    /// Convert this latitude and longitude into an OSGB (Ordnance Survey of Great
    /// Britain) grid reference.
    /// </summary>
    /// <returns>The converted OSGB grid reference.</returns>
    public OSRef ToOSRef() 
    {
      Airy1830Ellipsoid airy1830 = Airy1830Ellipsoid.Instance;
      double OSGB_F0 = 0.9996012717;
      double N0 = -100000.0;
      double E0 = 400000.0;
      double phi0 = Util.ToRadians(49.0);
      double lambda0 = Util.ToRadians(-2.0);
      double a = airy1830.SemiMajorAxis;
      double b = airy1830.SemiMinorAxis;
      double eSquared = airy1830.EccentricitySquared;
      double phi = Util.ToRadians(Latitude);
      double lambda = Util.ToRadians(Longitude);
      double E = 0.0;
      double N = 0.0;
      double n = (a - b) / (a + b);
      double v = a * OSGB_F0
          * Math.Pow(1.0 - eSquared * Util.sinSquared(phi), -0.5);
      double rho = a * OSGB_F0 * (1.0 - eSquared)
          * Math.Pow(1.0 - eSquared * Util.sinSquared(phi), -1.5);
      double etaSquared = (v / rho) - 1.0;
      double M = (b * OSGB_F0)
          * (((1 + n + ((5.0 / 4.0) * n * n) + ((5.0 / 4.0) * n * n * n)) * (phi - phi0))
              - (((3 * n) + (3 * n * n) + ((21.0 / 8.0) * n * n * n))
                  * Math.Sin(phi - phi0) * Math.Cos(phi + phi0))
              + ((((15.0 / 8.0) * n * n) + ((15.0 / 8.0) * n * n * n))
                  * Math.Sin(2.0 * (phi - phi0)) * Math.Cos(2.0 * (phi + phi0))) - (((35.0 / 24.0)
              * n * n * n)
              * Math.Sin(3.0 * (phi - phi0)) * Math.Cos(3.0 * (phi + phi0))));
      double I = M + N0;
      double II = (v / 2.0) * Math.Sin(phi) * Math.Cos(phi);
      double III = (v / 24.0) * Math.Sin(phi) * Math.Pow(Math.Cos(phi), 3.0)
          * (5.0 - Util.tanSquared(phi) + (9.0 * etaSquared));
      double IIIA = (v / 720.0) * Math.Sin(phi) * Math.Pow(Math.Cos(phi), 5.0)
          * (61.0 - (58.0 * Util.tanSquared(phi)) + Math.Pow(Math.Tan(phi), 4.0));
      double IV = v * Math.Cos(phi);
      double V = (v / 6.0) * Math.Pow(Math.Cos(phi), 3.0)
          * ((v / rho) - Util.tanSquared(phi));
      double VI = (v / 120.0)
          * Math.Pow(Math.Cos(phi), 5.0)
          * (5.0 - (18.0 * Util.tanSquared(phi)) + (Math.Pow(Math.Tan(phi), 4.0))
              + (14 * etaSquared) - (58 * Util.tanSquared(phi) * etaSquared));

      N = I + (II * Math.Pow(lambda - lambda0, 2.0))
          + (III * Math.Pow(lambda - lambda0, 4.0))
          + (IIIA * Math.Pow(lambda - lambda0, 6.0));
      E = E0 + (IV * (lambda - lambda0)) + (V * Math.Pow(lambda - lambda0, 3.0))
          + (VI * Math.Pow(lambda - lambda0, 5.0));

      return new OSRef(E, N);
    }

    /// <summary>
    /// Convert this latitude and longitude to a UTM reference.
    /// </summary>
    /// <returns>The converted UTM reference.</returns>
    /// <exception cref="NotDefinedOnUtmGridException">
    /// If an attempt is made to convert a LatLng that falls outside the
    /// area covered by the UTM grid. The UTM grid is only defined for
    /// latitudes south of 84°N and north of 80°S.</exception>
    public UTMRef ToUtmRef() 
    {
      if (Latitude < -80 || Latitude > 84) {
        throw new NotDefinedOnUtmGridException("Latitude (" + Latitude
            + ") falls outside the UTM grid.");
      }

      if (this.longitude == 180.0) {
        this.longitude = -180.0;
      }

      double UTM_F0 = 0.9996;
      double a = WGS84Ellipsoid.Instance.SemiMajorAxis;
      double eSquared = WGS84Ellipsoid.Instance.EccentricitySquared;
      double longitude = this.longitude;
      double latitude = this.latitude;

      double latitudeRad = latitude * (Math.PI / 180.0);
      double longitudeRad = longitude * (Math.PI / 180.0);
      int longitudeZone = (int) Math.Floor((longitude + 180.0) / 6.0) + 1;

      // Special zone for Norway
      if (latitude >= 56.0 && latitude < 64.0 && longitude >= 3.0
          && longitude < 12.0) {
        longitudeZone = 32;
      }

      // Special zones for Svalbard
      if (latitude >= 72.0 && latitude < 84.0) {
        if (longitude >= 0.0 && longitude < 9.0) {
          longitudeZone = 31;
        } else if (longitude >= 9.0 && longitude < 21.0) {
          longitudeZone = 33;
        } else if (longitude >= 21.0 && longitude < 33.0) {
          longitudeZone = 35;
        } else if (longitude >= 33.0 && longitude < 42.0) {
          longitudeZone = 37;
        }
      }

      double longitudeOrigin = (longitudeZone - 1) * 6 - 180 + 3;
      double longitudeOriginRad = longitudeOrigin * (Math.PI / 180.0);

      char UTMZone = UTMRef.GetUTMLatitudeZoneLetter(latitude);

      double ePrimeSquared = (eSquared) / (1 - eSquared);

      double n = a
          / Math.Sqrt(1 - eSquared * Math.Sin(latitudeRad)
              * Math.Sin(latitudeRad));
      double t = Math.Tan(latitudeRad) * Math.Tan(latitudeRad);
      double c = ePrimeSquared * Math.Cos(latitudeRad) * Math.Cos(latitudeRad);
      double A = Math.Cos(latitudeRad) * (longitudeRad - longitudeOriginRad);

      double M = a
          * ((1 - eSquared / 4 - 3 * eSquared * eSquared / 64 - 5 * eSquared
              * eSquared * eSquared / 256)
              * latitudeRad
              - (3 * eSquared / 8 + 3 * eSquared * eSquared / 32 + 45 * eSquared
                  * eSquared * eSquared / 1024)
              * Math.Sin(2 * latitudeRad)
              + (15 * eSquared * eSquared / 256 + 45 * eSquared * eSquared
                  * eSquared / 1024) * Math.Sin(4 * latitudeRad) - (35 * eSquared
              * eSquared * eSquared / 3072)
              * Math.Sin(6 * latitudeRad));

      double UTMEasting = (UTM_F0
          * n
          * (A + (1 - t + c) * Math.Pow(A, 3.0) / 6 + (5 - 18 * t + t * t + 72
              * c - 58 * ePrimeSquared)
              * Math.Pow(A, 5.0) / 120) + 500000.0);

      double UTMNorthing = (UTM_F0 * (M + n
          * Math.Tan(latitudeRad)
          * (A * A / 2 + (5 - t + (9 * c) + (4 * c * c)) * Math.Pow(A, 4.0) / 24 + (61
              - (58 * t) + (t * t) + (600 * c) - (330 * ePrimeSquared))
              * Math.Pow(A, 6.0) / 720)));

      // Adjust for the southern hemisphere
      if (latitude < 0) {
        UTMNorthing += 10000000.0;
      }

      return new UTMRef(longitudeZone, UTMZone, UTMEasting, UTMNorthing);
    }

    /// <summary>
    /// Convert this latitude and longitude to an MGRS reference.
    /// </summary>
    /// <returns>The converted MGRS reference</returns>
    public MGRSRef ToMGRSRef() 
    {
      UTMRef utm = ToUtmRef();
      return new MGRSRef(utm);
    }

    /// <summary>
    /// Convert this LatLng from the OSGB36 datum to the WGS84 datum using an
    /// approximate Helmert transformation.
    /// </summary>   
    public void ToWGS84() 
    {
      double a = Airy1830Ellipsoid.Instance.SemiMajorAxis;
      double eSquared = Airy1830Ellipsoid.Instance.EccentricitySquared;
      double phi = Util.ToRadians(latitude);
      double lambda = Util.ToRadians(longitude);
      double v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phi)));
      double H = 0; // height
      double x = (v + H) * Math.Cos(phi) * Math.Cos(lambda);
      double y = (v + H) * Math.Cos(phi) * Math.Sin(lambda);
      double z = ((1 - eSquared) * v + H) * Math.Sin(phi);

      double tx = 446.448;
      // ty : Incorrect value in v1.0 (-124.157). Corrected in v1.1.
      double ty = -125.157;
      double tz = 542.060;
      double s = -0.0000204894;
      double rx = Util.ToRadians(0.00004172222);
      double ry = Util.ToRadians(0.00006861111);
      double rz = Util.ToRadians(0.00023391666);

      double xB = tx + (x * (1 + s)) + (-rx * y) + (ry * z);
      double yB = ty + (rz * x) + (y * (1 + s)) + (-rx * z);
      double zB = tz + (-ry * x) + (rx * y) + (z * (1 + s));

      a = WGS84Ellipsoid.Instance.SemiMajorAxis;
      eSquared = WGS84Ellipsoid.Instance.EccentricitySquared;

      double lambdaB = Util.ToDegrees(Math.Atan(yB / xB));
      double p = Math.Sqrt((xB * xB) + (yB * yB));
      double phiN = Math.Atan(zB / (p * (1 - eSquared)));
      for (int i = 1; i < 10; i++) {
        v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phiN)));
        double phiN1 = Math.Atan((zB + (eSquared * v * Math.Sin(phiN))) / p);
        phiN = phiN1;
      }

      double phiB = Util.ToDegrees(phiN);

      latitude = phiB;
      longitude = lambdaB;

      datum = WGS84Datum.Instance;
    }

    /// <summary>
    /// Converts this LatLng to another datum.
    /// </summary>
    /// <param name="d">The datum.</param>
    public void ToDatum(DotNetCoords.Datum.Datum d) 
    {
      double invert = 1;

      if (!(datum is WGS84Datum) && !(d is WGS84Datum)) 
      {
        ToDatum(WGS84Datum.Instance);
      } 
      else 
      {
        if (d is WGS84Datum) 
        {
          // Don't do anything if datum and d are both WGS84.
          return;
        }
        invert = -1;
      }

      double a = datum.ReferenceEllipsoid.SemiMajorAxis;
      double eSquared = datum.ReferenceEllipsoid.EccentricitySquared;
      double phi = Util.ToRadians(latitude);
      double lambda = Util.ToRadians(longitude);
      double v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phi)));
      double H = height; // height
      double x = (v + H) * Math.Cos(phi) * Math.Cos(lambda);
      double y = (v + H) * Math.Cos(phi) * Math.Sin(lambda);
      double z = ((1 - eSquared) * v + H) * Math.Sin(phi);

      double dx = invert * d.DX;// 446.448;
      double dy = invert * d.DY;// -125.157;
      double dz = invert * d.DZ;// 542.060;
      double ds = invert * d.DS / 1000000.0;// -0.0000204894;
      double rx = invert * Util.ToRadians(d.RX / 3600.0);
      double ry = invert * Util.ToRadians(d.RY / 3600.0);
      double rz = invert * Util.ToRadians(d.RZ / 3600.0);

      double sc = 1 + ds;
      double xB = dx + (x * sc) + ((-rx * y) * sc) + ((ry * z) * sc);
      double yB = dy + ((rz * x) * sc) + (y * sc) + ((-rx * z) * sc);
      double zB = dz + ((-ry * x) * sc) + ((rx * y) * sc) + (z * sc);

      a = d.ReferenceEllipsoid.SemiMajorAxis;
      eSquared = d.ReferenceEllipsoid.EccentricitySquared;

      double lambdaB = Util.ToDegrees(Math.Atan(yB / xB));
      double p = Math.Sqrt((xB * xB) + (yB * yB));
      double phiN = Math.Atan(zB / (p * (1 - eSquared)));
      for (int i = 1; i < 10; i++) {
        v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phiN)));
        double phiN1 = Math.Atan((zB + (eSquared * v * Math.Sin(phiN))) / p);
        phiN = phiN1;
      }

      double phiB = Util.ToDegrees(phiN);

      latitude = phiB;
      longitude = lambdaB;
    }


    /// <summary>
    /// Convert this LatLng from the WGS84 datum to the OSGB36 datum using an
    /// approximate Helmert transformation.
    /// </summary>
    public void ToOSGB36() 
    {
      WGS84Ellipsoid wgs84 = WGS84Ellipsoid.Instance;
      double a = wgs84.SemiMajorAxis;
      double eSquared = wgs84.EccentricitySquared;
      double phi = Util.ToRadians(this.latitude);
      double lambda = Util.ToRadians(this.longitude);
      double v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phi)));
      double H = 0; // height
      double x = (v + H) * Math.Cos(phi) * Math.Cos(lambda);
      double y = (v + H) * Math.Cos(phi) * Math.Sin(lambda);
      double z = ((1 - eSquared) * v + H) * Math.Sin(phi);

      double tx = -446.448;
      // ty : Incorrect value in v1.0 (124.157). Corrected in v1.1.
      double ty = 125.157;
      double tz = -542.060;
      double s = 0.0000204894;
      double rx = Util.ToRadians(-0.00004172222);
      double ry = Util.ToRadians(-0.00006861111);
      double rz = Util.ToRadians(-0.00023391666);

      double xB = tx + (x * (1 + s)) + (-rx * y) + (ry * z);
      double yB = ty + (rz * x) + (y * (1 + s)) + (-rx * z);
      double zB = tz + (-ry * x) + (rx * y) + (z * (1 + s));

      a = Airy1830Ellipsoid.Instance.SemiMajorAxis;
      eSquared = Airy1830Ellipsoid.Instance.EccentricitySquared;

      double lambdaB = Util.ToDegrees(Math.Atan(yB / xB));
      double p = Math.Sqrt((xB * xB) + (yB * yB));
      double phiN = Math.Atan(zB / (p * (1 - eSquared)));
      for (int i = 1; i < 10; i++) {
        v = a / (Math.Sqrt(1 - eSquared * Util.sinSquared(phiN)));
        double phiN1 = Math.Atan((zB + (eSquared * v * Math.Sin(phiN))) / p);
        phiN = phiN1;
      }

      double phiB = Util.ToDegrees(phiN);

      latitude = phiB;
      longitude = lambdaB;

      datum = OSGB36Datum.Instance;
    }

    /// <summary>
    /// Calculate the surface distance in kilometres from this LatLng to the given
    /// LatLng.
    /// </summary>
    /// <param name="ll">The LatLng object to measure the distance to..</param>
    /// <returns>The surface distance in kilometres.</returns>
    public double Distance(LatLng ll) 
    {
      double er = 6366.707;

      double latFrom = Util.ToRadians(Latitude);
      double latTo = Util.ToRadians(ll.Latitude);
      double lngFrom = Util.ToRadians(Longitude);
      double lngTo = Util.ToRadians(ll.Longitude);

      double d = Math.Acos(Math.Sin(latFrom) * Math.Sin(latTo)
          + Math.Cos(latFrom) * Math.Cos(latTo) * Math.Cos(lngTo - lngFrom))
          * er;

      return d;
    }

    /// <summary>
    /// Calculate the surface distance in miles from this LatLng to the given
    /// LatLng.
    /// </summary>
    /// <param name="ll">The LatLng object to measure the distance to.</param>
    /// <returns>The surface distance in miles.</returns>
    public double DistanceMiles(LatLng ll) 
    {
      return Distance(ll) / 1.609344;
    }

    /// <summary>
    /// Gets the latitude in degrees.
    /// </summary>
    /// <value>The latitude in degrees.</value>
    public double Latitude
    {
      get
      {
        return latitude;
      }
    }

    /// <summary>
    /// Gets the latitude degrees.
    /// </summary>
    /// <value>The latitude degrees.</value>
    public int LatitudeDegrees 
    {
      get
      {
        double ll = Latitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          deg++;
        }
        return deg;
      }
    }

    /// <summary>
    /// Gets the latitude minutes.
    /// </summary>
    /// <value>The latitude minutes.</value>
    public int LatitudeMinutes 
    {
      get
      {
        double ll = Latitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          minx = 1 - minx;
        }
        int min = (int)Math.Floor(minx * 60);
        return min;
      }
    }

    /// <summary>
    /// Gets the latitude seconds.
    /// </summary>
    /// <value>The latitude seconds.</value>
    public double LatitudeSeconds 
    {
      get
      {
        double ll = Latitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          minx = 1 - minx;
        }
        int min = (int)Math.Floor(minx * 60);
        double sec = ((minx * 60) - min) * 60;
        return sec;
      }
    }

    /// <summary>
    /// Gets the longitude in degrees.
    /// </summary>
    /// <value>The longitude in degrees.</value>
    public double Longitude
    {
      get
      {
        return longitude;
      }
    }

    /// <summary>
    /// Gets the longitude degrees.
    /// </summary>
    /// <value>The longitude degrees.</value>
    public int LongitudeDegrees 
    {
      get
      {
        double ll = Longitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          deg++;
        }
        return deg;
      }
    }

    /// <summary>
    /// Gets the longitude minutes.
    /// </summary>
    /// <value>The longitude minutes.</value>
    public int LongitudeMinutes 
    {
      get
      {
        double ll = Longitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          minx = 1 - minx;
        }
        int min = (int)Math.Floor(minx * 60);
        return min;
      }
    }

    /// <summary>
    /// Gets the longitude seconds.
    /// </summary>
    /// <value>The longitude seconds.</value>
    public double LongitudeSeconds 
    {
      get
      {
        double ll = Longitude;
        int deg = (int)Math.Floor(ll);
        double minx = ll - deg;
        if (ll < 0 && minx != 0.0)
        {
          minx = 1 - minx;
        }
        int min = (int)Math.Floor(minx * 60);
        double sec = ((minx * 60) - min) * 60;
        return sec;
      }
    }

    /// <summary>
    /// Gets the height.
    /// </summary>
    /// <value>The height.</value>
    public double Height 
    {
      get
      {
        return height;
      }
    }

    /// <summary>
    /// Gets the datum.
    /// </summary>
    /// <value>The datum.</value>
    public DotNetCoords.Datum.Datum Datum
    {
      get
      {
        return datum;
      }
    }
  }
}