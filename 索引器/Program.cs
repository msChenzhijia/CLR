using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    class Program
    {

        static void Main(string[] args)
        {
            /**             
             *  索引器参数和返回类型除了void其他都可以
             **/
            BitArray bitArray = new BitArray(14);
            //调用set访问器方法,将编号为偶数的所有位都设为true
            for (Int32 i = 0;  i< 14; i++)
            {
                bitArray[i] = (i % 2 == 0);                
            }
            //调用get访问器显示所有位都设为true
            for (Int32 i = 0; i < 14; i++)
            {
                Console.WriteLine("Bit " + i + "is" + (bitArray[i] ? "on" : "off"));
            }
        }
    }
    public sealed class BitArray
    {
        private Byte[] m_byteArray;
        private Int32 m_numBits;
        public BitArray(Int32 numBits)
        {
            
            if (numBits<0)
            {
                throw new ArgumentOutOfRangeException("numBits must be >0");
            }
            m_numBits = numBits;
            m_byteArray = new Byte[(numBits + 7) / 8];
        }
        [IndexerName("Bit1")]
        public Boolean this[Int32 bitPos]
        {
            get
            {
                if ((bitPos<0)||(bitPos>=m_numBits))
                {
                    throw new ArgumentOutOfRangeException("bitPos");
                }
                return (m_byteArray[bitPos / 8] & (1 << (bitPos % 8))) != 0;
            }
            set
            {
                if ((bitPos<0)||(bitPos>=m_numBits))
                {
                    throw new ArgumentOutOfRangeException("bitPos", bitPos.ToString());
                }
                if (value)
                {
                    //将指定索引处的位设为true
                    m_byteArray[bitPos / 8] = (Byte)(m_byteArray[bitPos / 8] | (1 << (bitPos % 8)));
                }
                else
                {
                    m_byteArray[bitPos / 8] = (Byte)(m_byteArray[bitPos / 8] &~ (1 << (bitPos % 8)));
                }
            }
        }
        [IndexerName("Bit1")]
        public Boolean this[Int32 bitPos, String a]
        {
            get
            {
                if ((bitPos < 0) || (bitPos >= m_numBits))
                {
                    throw new ArgumentOutOfRangeException("bitPos");
                }
                return (m_byteArray[bitPos / 8] & (1 << (bitPos % 8))) != 0;
            }
            set
            {
                if ((bitPos < 0) || (bitPos >= m_numBits))
                {
                    throw new ArgumentOutOfRangeException("bitPos", bitPos.ToString());
                }
                if (value)
                {
                    //将指定索引处的位设为true
                    m_byteArray[bitPos / 8] = (Byte)(m_byteArray[bitPos / 8] | (1 << (bitPos % 8)));
                }
                else
                {
                    m_byteArray[bitPos / 8] = (Byte)(m_byteArray[bitPos / 8] & ~(1 << (bitPos % 8)));
                }
            }
        }
    }
}
