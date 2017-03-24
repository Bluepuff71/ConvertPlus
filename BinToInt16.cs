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
        public static Int16 ToBinaryInt16(Boolean i)
        {
            return Convert.ToInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 16-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary Representation</returns>
        public static Int16 ToBinaryInt16(SByte i)
        {
            return Convert.ToInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 16-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int16 ToBinaryInt16(SByte i, Byte indexSize)
        {
            return Convert.ToInt16(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 16-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary Representaion</returns>
        public static Int16 ToBinaryInt16(Byte i)
        {
            return Convert.ToInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 16-bit binary representation.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int16 ToBinaryInt16(Byte i, Byte indexSize)
        {
            return Convert.ToInt16(ToBinaryString(i, indexSize));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 16-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Int16 ToBinaryInt16(Int16 i)
        {
            return Convert.ToInt16(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 16-bit signed integer to its 16-bit binary representation. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Int16 ToBinaryInt16(Int16 i, Byte indexSize)
        {
            return Convert.ToInt16(ToBinaryString(i, indexSize));
        }
    }
}
