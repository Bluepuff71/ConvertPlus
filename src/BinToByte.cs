using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit unsigned integer to its 8-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Byte ToBinaryByte(Boolean i)
        {
            return Convert.ToByte(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 8-bit binary representation. Automatically sizes index.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <returns>Binary representation</returns>
        public static Byte ToBinaryByte(SByte i)
        {
            return Convert.ToByte(ToBinaryString(Math.Abs(i)));
        }

        /// <summary>
        /// Converts a 8-bit signed integer to its 8-bit binary representation. 
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Byte ToBinaryByte(SByte i, Byte indexSize)
        {
            return Convert.ToByte(ToBinaryString(Math.Abs(i), indexSize));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 8-bit binary representaion. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary representaion</returns>
        public static Byte ToBinaryByte(Byte i)
        {
            return Convert.ToByte(ToBinaryString(i));
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to its 8-bit binary representaion.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary representation</returns>
        public static Byte ToBinaryByte(Byte i, Byte indexSize)
        {
            return Convert.ToByte(ToBinaryString(i), indexSize);
        }
    }
}
