using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inhwan.HashTable
{
    public class HashTable<T>
    {
         class Node
        {
            string Key;
            T Value;
            public Node(string key, T value)
            {
                this.Key = key;
                this.Value = value;
            }
            public string key
            {
                get { return Key; }
                set { Key = value; }
            }

            public T value
            {
                get { return Value; }
                set { Value = value; }
            }
        }

        LinkedList<Node>[] data;

        public HashTable(int size)
        {
            this.data = new LinkedList<Node>[size];
        }
        
        int getHashCode(string key)
        {
            int hashcode = 0;
            foreach(char c in key.ToCharArray())
            {
                hashcode += c;
            }
            return hashcode;
        }
        int convertToIndex(int hashcode)
        {
            return hashcode % data.Length;
        }
        
        Node searchKey(LinkedList<Node> list, string key)
        {
            if (list == null) return null;
            foreach(Node node in list)
            {
                if(node.key.Equals(key))
                {
                    return node;
                }
            }
            return null;
        }

        public void put(string key, T value)
        {
            int hashcode = getHashCode(key);
            int index = convertToIndex(hashcode);
            Debug.Log($"해쉬코드 : {hashcode}");
            Debug.Log($"index : {index}");
            //LinkedList<Node> list = data[index];
            if (data[index] == null)
            {
                //list = new LinkedList<Node>();
                data[index] = new LinkedList<Node>();
            }
            Node node = searchKey(data[index], key);
            if(node == null)
            {
                //list.AddLast(new Node(key, value));
                data[index].AddLast(new Node(key, value));
            }
            else
            {
                node.value = value;
            }
        }

        public T get(string key)
        {
            int hashcode = getHashCode(key);
            int index = convertToIndex(hashcode);
            Node node = searchKey(data[index], key);
            if (node == null)
                return default(T);
            else
                return node.value;
        }
    }
}
