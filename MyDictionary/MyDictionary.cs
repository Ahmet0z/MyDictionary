using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict <K,V>
    {
        K[] Key;
        V[] Value;

        K[] tempKey;
        V[] tempValue;
        public MyDict()
        {
            Key = new K[0];
            Value = new V[0];
        }
        public void Add(K item1, V item2)
        {
            tempKey = Key;
            tempValue = Value;
            Key = new K[Key.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                Value[i] = tempValue[i];
            }

        }

        public int Count
        {
            get { return Key.Length; }
        }

    }
}
