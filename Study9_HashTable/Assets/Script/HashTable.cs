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

        //생성자에서 배열방 미리 만들어 놓기.
        public HashTable(int size)
        {
            this.data = new LinkedList<Node>[size];
        }
        
        //문자열의 문자마다 아스키코드로 반환
        int getHashCode(string key)
        {
            int hashcode = 0;
            foreach(char c in key.ToCharArray())
            {
                hashcode += c;
            }
            return hashcode;
        }

        //배열방의 크기만큼 나머지 연산을 해서 해쉬코드를 인덱스로 치환해줌.
        int convertToIndex(int hashcode)
        {
            return hashcode % data.Length;
        }
        
        //리스트 노드에서 키를 찾아 반환
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
            //입력한 key 값을 해쉬알고리즘을 통해 해싱
            int hashcode = getHashCode(key);
            //해시코드를 인덱스로 바꿔준다.
            int index = convertToIndex(hashcode);
            Debug.Log($"해쉬코드 : {hashcode}");
            Debug.Log($"index : {index}");
            //LinkedList<Node> list = data[index];
            //LinkedList<Node> 타입의 배열인 data의 index가 null 일경우.
            if (data[index] == null)
            {
                //list = new LinkedList<Node>();
                data[index] = new LinkedList<Node>();
            }
            //해당 인덱스의 링크드리스트에서 key값을 찾아서 반환
            Node node = searchKey(data[index], key);
            if(node == null)
            {
                //list.AddLast(new Node(key, value));
                //key가 없다면 해당 linkedlist에 추가.
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
