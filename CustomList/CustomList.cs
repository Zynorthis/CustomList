using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T> where T : IEnumerable
    {
        T[] hiddenArray = new T[4];
        private int count;
        public int Count { get { return count; } }
        public CustomList()
        {
            this.hiddenArray = hiddenArray;
        }
        public void Add( T value )
        {
            int i = 0;
            while (i <= hiddenArray.Length)
            {
                if (hiddenArray[i].Equals(0))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                if (hiddenArray[i].Equals(""))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                if (hiddenArray[i].Equals(true) || hiddenArray[i].Equals(false))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                if (hiddenArray[i].Equals(null))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                if (hiddenArray.Length == i)
                {
                    int x = hiddenArray.Length * 2;
                    // hiddenArray.Length =
                }
            }
        }
        public void Remove( T value )
        {

        }
        public string ToString()
        {
            return "string";
        }
        public void Zip()
        {
            
        }

        public void operator +(T value)
        {

        }
        public void operator -(T value)
        {

        }
    }
}
