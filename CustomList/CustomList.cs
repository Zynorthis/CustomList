using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T> : IEnumerable
    {
        private T[] hiddenArray = new T[4];
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity { get { return hiddenArray.Length; } }
        public T this[int i] { get { return hiddenArray[i]; } set { hiddenArray[i] = value; } }

        public CustomList()
        {
            this.hiddenArray = hiddenArray;
            
        }
        public void Add(T value)
        {
            if (value.Equals(0) || value.Equals("") || value.Equals(false))
            {
                // Do not add
            }
            else
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
        public override string ToString()
        {
            int i = 1;
            string valuesCombined;
            if (typeof(T) == typeof(int))
            {
                string x = hiddenArray[0].ToString();
                while (i < count)
                {
                    x += hiddenArray[i].ToString();
                    i++;
                }
                return valuesCombined = x;
            }
            else
            {
                throw new Exception("ToString Override Error: could not successfully convert to string.");
                return "Error";
            }
        }
        public CustomList<T> Zip(CustomList<T> secondList)
        {
            if (hiddenArray == null)
            {
                throw new ArgumentNullException("Zip Override Error: null first argument");
            }
            else if (secondList.hiddenArray == null)
            {
                throw new ArgumentNullException("Zip Override Error: null first argument");
            }
            else if (hiddenArray.GetType() != secondList.hiddenArray.GetType())
            {
                throw new Exception("Parameter Type Error: The parameters that were passed in do not have equal types.");
            }

            int a = 4;
            while (a < (count + secondList.count))
            {
                a = a * 2;
            }
            CustomList<T> resultList = new CustomList<T>();
            resultList.hiddenArray = new T[a];
            if (count >= secondList.count)
            {
                int i = 0;
                while (i < secondList.count)
                {
                    resultList.Add(hiddenArray[i]);
                    resultList.Add(secondList.hiddenArray[i]);
                    i++;
                }
                while (i < count)
                {
                    resultList.Add(hiddenArray[i]);
                    i++;
                }
            }
            else if (secondList.count > count)
            {
                int i = 0;
                while (i < count)
                {
                    resultList.Add(secondList.hiddenArray[i]);
                    resultList.Add(hiddenArray[i]);
                    i++;
                }
                while (i < secondList.count)
                {
                    resultList.Add(secondList.hiddenArray[i]);
                    i++;
                }
            }
            return resultList;
        }

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            if (list1.GetType() != list2.GetType())
            {
                throw new Exception("Parameter Type Error: The parameters that were passed in do not have equal types.");
            }
            CustomList<T> list3 = new CustomList<T>();
            foreach (var item in list1.hiddenArray)
            {
                list3.Add(item);
            }
            foreach (var item in list2.hiddenArray)
            {
                list3.Add(item);
            }
            if (list3 == null)
            {
                throw new Exception("Error, List Count Exception: Could not complete addition operation.");
            }
            return list3;
        }
        //public void operator -(T value)
        //{

        //}

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < hiddenArray.Length; i++)
            {
                yield return hiddenArray[i];
            }
        }
    }
}
