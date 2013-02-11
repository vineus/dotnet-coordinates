using System;

namespace DotNetCoords
{
  internal static class Util
  {

    /**
     * Calculate sin^2(x).
     * 
     * @param x
     *          x
     * @return sin^2(x)
     * @since 1.0
     */
    internal static double sinSquared(double x)
    {
      return Math.Sin(x) * Math.Sin(x);
    }

    /**
     * Calculate sin^3(x).
     * 
     * @param x
     *          x
     * @return sin^3(x)
     * @since 1.1
     */
    internal static double sinCubed(double x)
    {
      return sinSquared(x) * Math.Sin(x);
    }


    /**
     * Calculate cos^2(x).
     * 
     * @param x
     *          x
     * @return cos^2(x)
     * @since 1.0
     */
    internal static double cosSquared(double x)
    {
      return Math.Cos(x) * Math.Cos(x);
    }


    /**
     * Calculate cos^3(x).
     * 
     * @param x
     *          x
     * @return cos^3(x)
     * @since 1.1
     */
    internal static double cosCubed(double x)
    {
      return cosSquared(x) * Math.Cos(x);
    }


    /**
     * Calculate tan^2(x).
     * 
     * @param x
     *          x
     * @return tan^2(x)
     * @since 1.0
     */
    internal static double tanSquared(double x)
    {
      return Math.Tan(x) * Math.Tan(x);
    }


    /**
     * Calculate sec(x).
     * 
     * @param x
     *          x
     * @return sec(x)
     * @since 1.0
     */
    internal static double sec(double x)
    {
      return 1.0 / Math.Cos(x);
    }

    internal static double ToRadians(double val) 
    { 
      return val * (Math.PI / 180); 
    }

    internal static double ToDegrees(double val)
    {
      return val * (180 / Math.PI);
    }
  }
}
