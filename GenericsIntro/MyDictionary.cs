using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictionary()
        {
            
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 item1,T2 item2)
        {
            T1[] tempkeys = keys;
            T2[] tempvalues = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }
            keys[keys.Length-1] = item1;
            values[values.Length-1]= item2;
        }
        public int Count()
        {
            return keys.Length;
        }
    }
}
