using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit unsigned integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Boolean i)
        {
            return Convert.ToUInt32(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Byte i)
        {
            return Convert.ToUInt32(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Byte i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(SByte i)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(SByte i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i), indexSize));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Int16 i)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Int16 i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i), indexSize));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(UInt16 i)
        {
            return Convert.ToUInt32(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(UInt16 i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 32-bit signed integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Int32 i)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 32-bit signed integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(Int32 i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(Math.Abs(i), indexSize));
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to its 32-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(UInt32 i)
        {
            return Convert.ToUInt32(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to its 32-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static UInt32 ToBinaryUInt32(UInt32 i, Byte indexSize)
        {
            return Convert.ToUInt32(ToBinaryString(i, indexSize));
        }
    }
}
