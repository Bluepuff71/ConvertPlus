using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit integer to its 8-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static SByte ToBinarySByte(Boolean i)
        {
            return Convert.ToSByte(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 8-bit binary representation. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representaion</returns>
        public static SByte ToBinarySByte(SByte i)
        {
            return Convert.ToSByte(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 8-bit binary representation.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static SByte ToBinarySByte(SByte i, Byte indexSize)
        {
            return Convert.ToSByte(ToBinaryString(i, indexSize));
        }
    }
}
