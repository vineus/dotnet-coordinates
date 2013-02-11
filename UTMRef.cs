using DotNetCoords.Datum;
using System;

namespace DotNetCoords
{
  /// <summary>
  /// Class to represent a Universal Transverse Mercator (UTM) reference.
  /// </summary>
  public class UTMRef : CoordinateSystem 
  {
    /**
     * Easting
     */
    private double easting;

    /**
     * Northing
     */
    private double northing;

    /**
     * Latitude zone character
     */
    private char latZone;

    /**
     * Longitude zone number
     */
    private int lngZone;

    /// <summary>
    /// Create a new UTM reference object. Checks are made to make sure that the
    /// given parameters are roughly valid, but the checks are not exhaustive with
    /// regards to the easting value. Catching a NotDefinedOnUTMGridException does
    /// not necessarily mean that the UTM reference is well-formed. This is because
    /// that valid values for the easting vary depending on the latitude.
    /// </summary>
    /// <param name="lngZone">The longitude zone number.</param>
    /// <param name="latZone">The latitude zone character.</param>
    /// <param name="easting">The easting in metres.</param>
    /// <param name="northing">The northing in metres.</param>
    /// <exception cref="NotDefinedOnUtmGridException">
    /// If any of the parameters are invalid. Be careful that a valid
    /// value for the easting does not necessarily mean that the UTM
    /// reference is well-formed. The current checks do not take into
    /// account the varying range of valid values for the easting for
    /// different latitudes.</exception>
    public UTMRef(int lngZone, char latZone, double easting, double northing) : 
      base(WGS84Datum.Instance)
    {
      if (lngZone < 1 || lngZone > 60) {
        throw new NotDefinedOnUtmGridException("Longitude zone (" + lngZone
            + ") is not defined on the UTM grid.");
      }

      if (latZone < 'C' || latZone > 'X') {
        throw new NotDefinedOnUtmGridException("Latitude zone (" + latZone
            + ") is not defined on the UTM grid.");
      }

      if (easting < 0.0 || easting > 1000000.0) {
        throw new NotDefinedOnUtmGridException("Easting (" + easting
            + ") is not defined on the UTM grid.");
      }

      if (northing < 0.0 || northing > 10000000.0) {
        throw new NotDefinedOnUtmGridException("Northing (" + northing
            + ") is not defined on the UTM grid.");
      }

      this.easting = easting;
      this.northing = northing;
      this.latZone = latZone;
      this.lngZone = lngZone;
    }

    /// <summary>
    /// Convert this UTM reference to a latitude and longitude.
    /// </summary>
    /// <returns>
    /// The converted latitude and longitude.
    /// </returns>
    public override LatLng ToLatLng() 
    {
      double UTM_F0 = 0.9996;
      double a = Datum.ReferenceEllipsoid.SemiMajorAxis;
      double eSquared = Datum.ReferenceEllipsoid.EccentricitySquared;
      double ePrimeSquared = eSquared / (1.0 - eSquared);
      double e1 = (1 - Math.Sqrt(1 - eSquared)) / (1 + Math.Sqrt(1 - eSquared));
      double x = easting - 500000.0;
      ;
      double y = northing;
      int zoneNumber = lngZone;
      char zoneLetter = latZone;

      double longitudeOrigin = (zoneNumber - 1.0) * 6.0 - 180.0 + 3.0;

      // Correct y for southern hemisphere
      if ((zoneLetter - 'N') < 0) {
        y -= 10000000.0;
      }

      double m = y / UTM_F0;
      double mu = m
          / (a * (1.0 - eSquared / 4.0 - 3.0 * eSquared * eSquared / 64.0 - 5.0 * Math
              .Pow(eSquared, 3.0) / 256.0));

      double phi1Rad = mu + (3.0 * e1 / 2.0 - 27.0 * Math.Pow(e1, 3.0) / 32.0)
          * Math.Sin(2.0 * mu)
          + (21.0 * e1 * e1 / 16.0 - 55.0 * Math.Pow(e1, 4.0) / 32.0)
          * Math.Sin(4.0 * mu) + (151.0 * Math.Pow(e1, 3.0) / 96.0)
          * Math.Sin(6.0 * mu);

      double n = a
          / Math.Sqrt(1.0 - eSquared * Math.Sin(phi1Rad) * Math.Sin(phi1Rad));
      double t = Math.Tan(phi1Rad) * Math.Tan(phi1Rad);
      double c = ePrimeSquared * Math.Cos(phi1Rad) * Math.Cos(phi1Rad);
      double r = a * (1.0 - eSquared)
          / Math.Pow(1.0 - eSquared * Math.Sin(phi1Rad) * Math.Sin(phi1Rad), 1.5);
      double d = x / (n * UTM_F0);

      double latitude = (phi1Rad - (n * Math.Tan(phi1Rad) / r)
          * (d
              * d
              / 2.0
              - (5.0 + (3.0 * t) + (10.0 * c) - (4.0 * c * c) - (9.0 * ePrimeSquared))
              * Math.Pow(d, 4.0) / 24.0 + (61.0 + (90.0 * t) + (298.0 * c)
              + (45.0 * t * t) - (252.0 * ePrimeSquared) - (3.0 * c * c))
              * Math.Pow(d, 6.0) / 720.0))
          * (180.0 / Math.PI);

      double longitude = longitudeOrigin
          + ((d - (1.0 + 2.0 * t + c) * Math.Pow(d, 3.0) / 6.0 + (5.0 - (2.0 * c)
              + (28.0 * t) - (3.0 * c * c) + (8.0 * ePrimeSquared) + (24.0 * t * t))
              * Math.Pow(d, 5.0) / 120.0) / Math.Cos(phi1Rad))
          * (180.0 / Math.PI);

      return new LatLng(latitude, longitude);
    }

    /// <summary>
    /// Work out the UTM latitude zone from the latitude.
    /// </summary>
    /// <param name="latitude">The latitude to find the UTM latitude zone for.</param>
    /// <returns>The UTM latitude zone for the given latitude.</returns>
    public static char GetUTMLatitudeZoneLetter(double latitude) 
    {
      if ((84 >= latitude) && (latitude >= 72))
        return 'X';
      else if ((72 > latitude) && (latitude >= 64))
        return 'W';
      else if ((64 > latitude) && (latitude >= 56))
        return 'V';
      else if ((56 > latitude) && (latitude >= 48))
        return 'U';
      else if ((48 > latitude) && (latitude >= 40))
        return 'T';
      else if ((40 > latitude) && (latitude >= 32))
        return 'S';
      else if ((32 > latitude) && (latitude >= 24))
        return 'R';
      else if ((24 > latitude) && (latitude >= 16))
        return 'Q';
      else if ((16 > latitude) && (latitude >= 8))
        return 'P';
      else if ((8 > latitude) && (latitude >= 0))
        return 'N';
      else if ((0 > latitude) && (latitude >= -8))
        return 'M';
      else if ((-8 > latitude) && (latitude >= -16))
        return 'L';
      else if ((-16 > latitude) && (latitude >= -24))
        return 'K';
      else if ((-24 > latitude) && (latitude >= -32))
        return 'J';
      else if ((-32 > latitude) && (latitude >= -40))
        return 'H';
      else if ((-40 > latitude) && (latitude >= -48))
        return 'G';
      else if ((-48 > latitude) && (latitude >= -56))
        return 'F';
      else if ((-56 > latitude) && (latitude >= -64))
        return 'E';
      else if ((-64 > latitude) && (latitude >= -72))
        return 'D';
      else if ((-72 > latitude) && (latitude >= -80))
        return 'C';
      else
        return 'Z';
    }

    /// <summary>
    /// Convert this UTM reference to a String representation for printing out.
    /// </summary>
    /// <returns>A string representation of this UTM reference.</returns>
    public override string ToString() 
    {
      return lngZone.ToString() + latZone.ToString() + " " + (int)easting + " " + (int)northing;
    }

    /// <summary>
    /// Gets the easting.
    /// </summary>
    /// <value>The easting.</value>
    public double Easting 
    {
      get
      {
        return easting;
      }
    }

    /// <summary>
    /// Gets the northing.
    /// </summary>
    /// <value>The northing.</value>
    public double Northing 
    {
      get
      {
        return northing;
      }
    }

    /// <summary>
    /// Gets the latitude zone character.
    /// </summary>
    /// <value>The latitude zone character.</value>
    public char LatZone 
    {
      get
      {
        return latZone;
      }
    }

    /// <summary>
    /// Get the longitude zone number.
    /// </summary>
    /// <value>The longitude zone number.</value>
    public int LngZone 
    {
      get
      {
        return lngZone;
      }
    }
  }
}
