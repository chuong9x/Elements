using System;
using System.Runtime.Serialization;

namespace Elements
{
    /// <summary>
    /// Unit conversions and utilities.
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Pi/2
        /// </summary>
        public const double PI_2 = Math.PI / 2;

        /// <summary>
        /// Convert from meters to feet.
        /// </summary>
        /// <param name="meters"></param>
        /// <returns>The provided value converted to feet.</returns>
        public static double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        /// <summary>
        /// Convert from feet to meters.
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>The provided value converted to meters.</returns>
        public static double FeetToMeters(double feet)
        {
            return feet * 0.3048;
        }

        /// <summary>
        /// Convert from meters to inches.
        /// </summary>
        /// <param name="meters"></param>
        /// <returns>The provided value converted to inches.</returns>
        public static double MetersToInches(double meters)
        {
            return meters * 39.3701;
        }

        /// <summary>
        /// Convert from inches to meters.
        /// </summary>
        /// <param name="inches">A value of inches.</param>
        /// <returns>The provided value converted to meters.</returns>
        public static double InchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        /// <summary>
        /// Convert from degrees to radians
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns>The provided value converted to radians</returns>
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        /// <summary>
        /// Convert from radians to degrees.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns>The provided value converted to radians.</returns>
        public static double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        /// <summary>
        /// Get the conversion factor from the provided length unit to meters.
        /// </summary>
        /// <param name="from">The length unit.</param>
        public static double GetConversionToMeters(LengthUnit from)
        {
            var conversion = 1.0;
            switch (from)
            {
                case LengthUnit.Kilometer:
                    conversion = 1000.0;
                    break;
                case LengthUnit.Meter:
                    conversion = 1.0;
                    break;
                case LengthUnit.Centimeter:
                    conversion = 0.01;
                    break;
                case LengthUnit.Millimeter:
                    conversion = 0.001;
                    break;
                case LengthUnit.Foot:
                    conversion = Units.FeetToMeters(1.0);
                    break;
                case LengthUnit.Inch:
                    conversion = Units.InchesToMeters(1.0);
                    break;

            }
            return conversion;
        }

        /// <summary>
        /// Units of length.
        /// </summary>
        public enum LengthUnit
        {
            /// <summary>
            /// Kilometer
            /// </summary>
            Kilometer,
            /// <summary>
            /// Meter
            /// </summary>
            Meter,
            /// <summary>
            /// Centimeter
            /// </summary>
            Centimeter,
            /// <summary>
            /// Millimeter
            /// </summary>
            Millimeter,
            /// <summary>
            /// Foot
            /// </summary>
            Foot,
            /// <summary>
            /// Inch
            /// </summary>
            Inch
        }

        /// <summary>
        /// Cardinal directions.
        /// </summary>
        public enum CardinalDirection
        {
            /// <summary>
            /// North
            /// </summary>
            North,
            /// <summary>
            /// South
            /// </summary>
            South,
            /// <summary>
            /// East
            /// </summary>
            East,
            /// <summary>
            /// West
            /// </summary>
            West
        }

        /// <summary>
        /// Unit types.
        /// </summary>        
        public enum UnitType
        {
            /// <summary>
            /// None
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            /// <summary>
            /// Area
            /// </summary>
            [EnumMember(Value = "area")]
            Area,
            /// <summary>
            /// Force
            /// </summary>
            [EnumMember(Value = "force")]
            Force,
            /// <summary>
            /// Length
            /// </summary>
            [EnumMember(Value = "length")]
            Length,
            /// <summary>
            /// Mass
            /// </summary>
            [EnumMember(Value = "mass")]
            Mass,
            /// <summary>
            /// Plane Angle
            /// </summary>
            [EnumMember(Value = "plane_angle")]
            PlaneAngle,
            /// <summary>
            /// Pressure
            /// </summary>
            [EnumMember(Value = "pressure")]
            Pressure,
            /// <summary>
            /// Time
            /// </summary>
            [EnumMember(Value = "time")]
            Time,
            /// <summary>
            /// Volume
            /// </summary>
            [EnumMember(Value = "volume")]
            Volume,
        }
    }
}