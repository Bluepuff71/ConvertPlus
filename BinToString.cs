using System;
using System.Collections.Generic;
using System.Text;
using ConvertPlus.Exceptions;
namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts a 1-bit unsigned integer to a binary string. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Boolean i)
        {
            switch (i)
            {
                case true:
                    return "1";
                case false:
                    return "0";
            }
            return "null";
        }

        /// <summary>
        /// Converts a 8-bit signed integer to a binary string. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(SByte i)
        {
            Byte absI = (Byte)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (Byte x = (Byte)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to a binary string. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Byte i)
        {
            Byte absI = (Byte)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (Byte x = (Byte)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 16-bit signed integer to a binary string. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Int16 i)
        {
            UInt16 absI = (UInt16)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (UInt16 x = (UInt16)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to a binary string. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt16 i)
        {
            UInt16 absI = (UInt16)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (UInt16 x = (UInt16)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 32-bit signed integer to a binary string. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Int32 i)
        {
            UInt32 absI = (UInt32)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (UInt32 x = (UInt32)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to a binary string. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt32 i)
        {
            UInt32 absI = (UInt32)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (UInt32 x = (UInt32)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 64-bit signed integer to a binary string. Automatically sizes index. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Int64 i)
        {
            UInt64 absI = (UInt64)Math.Abs(i);
            Byte indexSize = GetIndexSize(absI);
            String s = "";
            for (UInt64 x = (UInt64)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 64-bit unsigned integer to a binary string. Automatically sizes index.
        /// </summary>
        /// <param name="i">Unsigned integer to convert </param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt64 i)
        {
            Byte indexSize = GetIndexSize(i);
            String s = "";
            for (UInt64 x = (UInt64)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((i - x) >= 0)
                {
                    s += "1";
                    i -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 8-bit signed integer to a binary string. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(SByte i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > Byte.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a Byte allows");
            }
            Byte absI = (Byte)Math.Abs(i);
            String s = "";
            for (Byte x = (Byte)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 8-bit unsigned integer to a binary string.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Byte i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > Byte.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a Byte allows");
            }
            Byte absI = (Byte)Math.Abs(i);
            String s = "";
            for (Byte x = (Byte)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 16-bit signed integer to a binary string. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Int16 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt16.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt16 allows");
            }
            UInt16 absI = (UInt16)Math.Abs(i);
            String s = "";
            for (UInt16 x = (UInt16)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to a binary string.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt16 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt16.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt16 allows");
            }
            UInt16 absI = (UInt16)Math.Abs(i);
            String s = "";
            for (UInt16 x = (UInt16)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 32-bit signed integer to a binary string. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(Int32 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt32.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt32 allows");
            }
            UInt32 absI = (UInt32)Math.Abs(i);
            String s = "";
            for (UInt32 x = (UInt32)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to a binary string.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt32 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt32.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt32 allows");
            }
            UInt32 absI = (UInt32)Math.Abs(i);
            String s = "";
            for (UInt32 x = (UInt32)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 64-bit signed integer to a binary string. Supports negative numbers.
        /// </summary>
        /// <param name="i">Signed integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary String</returns>
        public static String ToBinaryString(Int64 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt64.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt64 allows");
            }
            UInt64 absI = (UInt64)Math.Abs(i);
            String s = "";
            for (UInt64 x = (UInt64)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((absI - x) >= 0)
                {
                    s += "1";
                    absI -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }

        /// <summary>
        /// Converts a 64-bit unsigned integer to a binary string.
        /// </summary>
        /// <param name="i">Unsigned integer to convert</param>
        /// <param name="indexSize">Number of indices</param>
        /// <returns>Binary string</returns>
        public static String ToBinaryString(UInt64 i, Byte indexSize)
        {
            if (Math.Pow(2, indexSize) > UInt64.MaxValue)
            {
                throw new OverflowException("Number of indices " + "[" + indexSize + "]" + " is greater than a UInt64 allows");
            }
            String s = "";
            for (UInt64 x = (UInt64)Math.Pow(2, indexSize); x >= 1; x /= 2)
            {
                if ((i - x) >= 0)
                {
                    s += "1";
                    i -= x;
                }
                else
                {
                    s += "0";
                }
            }
            if (i < 0)
            {
                return ToNegative(s);
            }
            return s;
        }
    }
}
