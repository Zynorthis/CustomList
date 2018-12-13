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
            int i = 0;
            while (i <= Count)
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
        public override string ToString()
        {
        int i = 1;
        string valuesCombined;
            string x = hiddenArray[0].ToString();
            while (i < count)
            {
                x += hiddenArray[i].ToString();
                i++;
            }
            return valuesCombined = x;
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
            if (list1 == null || list2 == null)
            {
                throw new Exception("Error, List Count Exception: Could not complete addition operation.");
            }
            if (list1.GetType() != list2.GetType())
            {
                throw new Exception("Parameter Type Error: The parameters that were passed in do not have equal types.");
            }
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                list3.Add(list2[i]);
            }
            return list3;
        }
        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            if (list1 == null || list2 == null)
            {
                throw new Exception("Error, List Count Exception: Could not complete addition operation.");
            }
            if (list1.GetType() != list2.GetType())
            {
                throw new Exception("Parameter Type Error: The parameters that were passed in do not have equal types.");
            }

            CustomList<T> list3 = new CustomList<T>();

            T[] tempArray = new T[list1.Capacity];
            int counter = 0;
            foreach (T item in list1)
            {
                tempArray[counter] = item;
                counter++;
            }

            int i = 0;
            bool w = true;
            while (i < list1.Count)
            {
                bool x = false;
                foreach (var item2 in list2.hiddenArray)
                {
                    if (list1[i].Equals(item2))
                    {
                        list1.Remove(item2);
                        x = true;
                        w = false;
                    }
                    if (x == false && w == false)
                    {
                        if (i == 0)
                        {
                            list3.Add(list1[i]);
                            w = true;
                        }
                        else
                        {
                            list3.Add(list1[i - 1]);
                            w = true;
                        }
                    }
                    //else if (x == false)
                    //{
                    //    list3.Add(list1[i]);
                    //    w = true;
                    //}
                    x = false;
                }
                i++;
            }

            list1 = new CustomList<T>();

            counter = 0;
            foreach (var item in tempArray)
            {
                list1.Add(item);
                counter++;
            }
            return list3;
        }

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < hiddenArray.Length; i++)
            {
                yield return hiddenArray[i];
            }
        }
    }
}
