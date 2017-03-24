using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit unsigned integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt16 ToBinaryUInt16(Boolean i)
        {
            return Convert.ToUInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt16 ToBinaryUInt16(Byte i)
        {
            return Convert.ToUInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 16-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representaion</returns>
        public static UInt16 ToBinaryUInt16(Byte i, Byte indexSize)
        {
            return Convert.ToUInt16(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt16 ToBinaryUInt16(SByte i)
        {
            return Convert.ToUInt16(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 16-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representaion</returns>
        public static UInt16 ToBinaryUInt16(SByte i, Byte indexSize)
        {
            return Convert.ToUInt16(ToBinaryString(Math.Abs(i), indexSize));
        }
        /// <summary>
        /// Converts a 16-bit signed integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt16 ToBinaryUInt16(Int16 i)
        {
            return Convert.ToUInt16(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 16-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representaion</returns>
        public static UInt16 ToBinaryUInt16(Int16 i, Byte indexSize)
        {
            return Convert.ToUInt16(ToBinaryString(Math.Abs(i), indexSize));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt16 ToBinaryUInt16(UInt16 i)
        {
            return Convert.ToUInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 16-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representaion</returns>
        public static UInt16 ToBinaryUInt16(UInt16 i, Byte indexSize)
        {
            return Convert.ToUInt16(ToBinaryString(i));
        }
    }
}
