using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum
{
  /// <summary>
  /// The Datum class represents a set of parameters for describing a particular
  /// datum, including a name, the reference ellipsoid used and the seven
  /// parameters required to translate co-ordinates in this datum to the WGS84
  /// datum.
  /// </summary>
  public abstract class Datum
  {
    internal string name;

    internal DotNetCoords.Ellipsoid.Ellipsoid ellipsoid;

    /**
     * Translation along the x-axis for use in 7-parameter Helmert
     * transformations. This value should be used to convert a co-ordinate in a
     * given datum to the WGS84 datum.
     */
    internal double dx;

    /**
     * Translation along the y-axis for use in 7-parameter Helmert
     * transformations. This value should be used to convert a co-ordinate in a
     * given datum to the WGS84 datum.
     */
    internal double dy;

    /**
     * Translation along the z-axis for use in 7-parameter Helmert
     * transformations. This value should be used to convert a co-ordinate in a
     * given datum to the WGS84 datum.
     */
    internal double dz;

    /**
     * Scale factor for use in 7-parameter Helmert transformations. This value
     * should be used to convert a co-ordinate in a given datum to the WGS84
     * datum.
     */
    internal double ds;

    /**
     * Rotation about the x-axis for use in 7-parameter Helmert transformations.
     * This value should be used to convert a co-ordinate in a given datum to the
     * WGS84 datum.
     */
    internal double rx;

    /**
     * Rotation about the y-axis for use in 7-parameter Helmert transformations.
     * This value should be used to convert a co-ordinate in a given datum to the
     * WGS84 datum.
     */
    internal double ry;

    /**
     * Rotation about the z-axis for use in 7-parameter Helmert transformations.
     * This value should be used to convert a co-ordinate in a given datum to the
     * WGS84 datum.
     */
    internal double rz;


    /// <summary>
    /// Get the name of this Datum.
    /// </summary>
    /// <value>The name of this Datum.</value>
    public string Name
    {
      get
      {
        return name;
      }
    }

    /// <summary>
    /// Get the reference ellipsoid associated with this Datum.
    /// </summary>
    /// <value>The reference ellipsoid associated with this Datum.</value>
    public DotNetCoords.Ellipsoid.Ellipsoid ReferenceEllipsoid
    {
      get
      {
        return ellipsoid;
      }
    }

    /// <summary>
    /// Gets the DS.
    /// </summary>
    /// <value>The DS.</value>
    public double DS
    {
      get
      {
        return ds;
      }
    }

    /// <summary>
    /// Gets the DX.
    /// </summary>
    /// <value>The DX.</value>
    public double DX   
    {
      get
      {
        return dx;
      }
    }

    /// <summary>
    /// Gets the DY.
    /// </summary>
    /// <value>The DY.</value>
    public double DY
    {
      get
      {
        return dy;
      }
    }

    /// <summary>
    /// Gets the DZ.
    /// </summary>
    /// <value>The DZ.</value>
    public double DZ
    {
      get
      {
        return dz;
      }
    }

    /// <summary>
    /// Gets the RX.
    /// </summary>
    /// <value>The RX.</value>
    public double RX
    {
      get
      {
        return rx;
      }
    }

    /// <summary>
    /// Gets the RY.
    /// </summary>
    /// <value>The RY.</value>
    public double RY
    {
      get
      {
        return ry;
      }
    }

    /// <summary>
    /// Gets the RZ.
    /// </summary>
    /// <value>The RZ.</value>
    public double RZ
    {
      get
      {
        return rz;
      }
    }


    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the parameters of the current Datum object.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the parameters of the current Datum object.
    /// </returns>
    public override string ToString()
    {
      return Name + " " + ellipsoid.ToString() + " dx=" + dx + " dy=" + dy
          + " dz=" + dz + " ds=" + ds + " rx=" + rx + " ry=" + ry + " rz=" + rz;
    }
  }

  /// <summary>
  /// Generic datum class represents a set of parameters for describing a particular
  /// datum, including a name, the reference ellipsoid used and the seven
  /// parameters required to translate co-ordinates in this datum to the WGS84
  /// datum.
  /// </summary>
  public abstract class Datum<T> : Datum where T : Datum, new()
  {
    private static T reference;

    /// <summary>
    /// Get the static instance of this datum.
    /// </summary>
    /// <value>A reference to the static instance of this datum.</value>
    public static T Instance
    {
      get
      {
        if (reference == null)
        {
          reference = new T();
        }
        return reference;
      }
    }
  }
}
