using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T>
    {
        T[] hiddenArray = new T[4];
        private int count;
        public int Count { get { return count; } }
        public T this[int i]
        {
            get
            {
                return hiddenArray[i];
            }
            set
            {
                hiddenArray[i] = value;
            }
        }
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
                else if (hiddenArray[i].Equals(""))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                else if (hiddenArray[i].Equals(false))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                else if (hiddenArray[i].Equals(null))
                {
                    hiddenArray[i] = value;
                    count++;
                    int x = hiddenArray.Length - i;
                    i = i + x;
                }
                // copies values to a tempArray then modifies hiddenArray length then copies values back over
                else if (hiddenArray.Length == (i + 1))
                {
                    int x = hiddenArray.Length * 2;
                    T[] tempArray = new T[x];
                    int a = 0;
                    foreach (T item in hiddenArray)
                    {
                        tempArray[a] = item;
                        a++;
                    }
                    hiddenArray = new T[x];
                    a = 0;
                    foreach (T item in tempArray)
                    {
                        hiddenArray[a] = item;
                        a++;
                    }
                    Add(value);
                    i = i + x;
                }
                i++;
            }
        }
        public void Remove(T value)
        {
            int i = 0;
            while (i < hiddenArray.Length)
            {
                if (hiddenArray[i].Equals(value))
                {
                    if (value.GetType() == typeof(int))
                    {
                        int a = i;
                        while ((a + 1) < hiddenArray.Length)
                        {
                            hiddenArray[i] = hiddenArray[i + 1];
                            a++;
                            i++;
                        }
                        hiddenArray[i].Equals(0);
                        count--;
                    }
                    else if (value.GetType() == typeof(string))
                    {
                        int a = i;
                        while (a < hiddenArray.Length)
                        {
                            hiddenArray[i] = hiddenArray[i + 1];
                            a++;
                            i++;
                        }
                        hiddenArray[i].Equals("");
                        count--;
                    }
                    else if (value.GetType() == typeof(bool))
                    {
                        int a = i;
                        while (a < hiddenArray.Length)
                        {
                            hiddenArray[i] = hiddenArray[i + 1];
                            a++;
                            i++;
                        }
                        hiddenArray[i].Equals(false);
                        count--;
                    }
                    else if ((hiddenArray.Length/2) == count)
                    {
                        int x = hiddenArray.Length / 2;
                        T[] tempArray = new T[x];
                        int a = 0;
                        foreach (T item in hiddenArray)
                        {
                            tempArray[a] = item;
                            a++;
                        }
                        hiddenArray = new T[x];
                        a = 0;
                        foreach (T item in tempArray)
                        {
                            hiddenArray[a] = item;
                            a++;
                        }
                        i = i + x;
                    }
                }
                i++;
            }
        }
        //public string ToString()
        //{
        //    return "string";
        //}
        //public void Zip()
        //{

        //}

        //public void operator +(T value)
        //{

        //}
        //public void operator -(T value)
        //{

        //}
    }
}
