using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    public partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit unsigned integer to its 64-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Boolean i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 64-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Byte i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 64-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Byte i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 64-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(SByte i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 64-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(SByte i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 64-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int16 i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 64-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int16 i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 64-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(UInt16 i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 64-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(UInt16 i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }
        /// <summary>
        /// Converts a 32-bit signed integer to its 64-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int32 i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 32-bit signed integer to its 64-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int32 i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to its 64-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(UInt32 i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to its 64-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(UInt32 i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 64-bit signed integer to its 64-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int64 i)
        {
            return Convert.ToInt64(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 64-bit signed integer to its 64-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int64 ToBinaryInt64(Int64 i, Byte indexSize)
        {
            return Convert.ToInt64(ToBinaryString(i, indexSize));
        }
    }
}
