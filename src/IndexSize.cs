using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Used to set the index automatically.
        /// </summary>
        /// <param name="i">Unsigned Integer to use. Must be less than or equal to SByte.MAX_VALUE.</param>
        /// <returns></returns>
        private static Byte GetIndexSize(SByte i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (Byte x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }

        /// <summary>
        /// Used to set the index automatically.
        /// </summary>
        /// <param name="i">Unsigned Integer to use. Must be less than or equal to Byte.MAX_VALUE.</param>
        /// <returns>Index size</returns>
        private static Byte GetIndexSize(Byte i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (Byte x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }

        /// <summary>
        /// Used to set the index automatically
        /// </summary>
        /// <param name="i">Unsigned Integer to use. Must be less than or equal to UInt16.MAX_VALUE.</param>
        /// <returns>Index size</returns>
        private static Byte GetIndexSize(UInt16 i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (UInt16 x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }

        /// <summary>
        /// Used to set index size automatically
        /// </summary>
        /// <param name="i">Unsigned Integer to use. Must be less than or equal to UInt32.MAX_VALUE.</param>
        /// <returns>Index size</returns>
        private static Byte GetIndexSize(UInt32 i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (UInt32 x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }

        private static Byte GetIndexSize(Int32 i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (UInt32 x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }

        /// <summary>
        /// Used to set size automatically
        /// </summary>
        /// <param name="i">Insigned Integer to use. Must be less than or equal to UInt64.MAX_VALUE.</param>
        /// <returns>Index size</returns>
        private static Byte GetIndexSize(UInt64 i)
        {
            Byte count = 0;
            if (i == 0)
            {
                return 1;
            }
            for (UInt64 x = 1; (i - x) >= 0; x *= 2)
            {
                count++;
            }
            return count--;
        }
    }
}
