using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Design
{
    public class DblNode
    {
        public DblNode next;
        public DblNode prev;
        public int key;
        public int val;
    }


    /// <summary>
    /// 
    /// </summary>
    public class LRUCache
    {

        Dictionary<int, DblNode> cache;
        int capacity;
        DblNode head, tail;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, DblNode>(capacity);
            head = new DblNode();
            tail = new DblNode();
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            if (!cache.ContainsKey(key))
                return -1;

            MoveNodeToHead(cache[key]); //This is recently used, so move to head.
            return cache[key].val;

        }

        public void Put(int key, int value)
        {
            if (!cache.ContainsKey(key)) //key is not present 
            {
                if(cache.Count == capacity) //if cache is already full, evict an LRU key
                {
                    int keyToRemove = RemoveEndNode();
                    cache.Remove(keyToRemove);
                }
                cache[key] = new DblNode() { key = key, val = value }; //insert new key/val
                InsertNodeToHead(cache[key]);
            }
            else //key already present, so update the value and move node to head.
            {
                cache[key].val = value;
                MoveNodeToHead(cache[key]);
            }
           
        }

        private int RemoveEndNode()
        {
            var endNode = tail.prev;
            endNode.prev.next = tail;
            tail.prev = endNode.prev;

            return endNode.key;
        }

        private void InsertNodeToHead(DblNode node)
        {
            //insert next to head.
            node.next = head.next;
            node.prev = head;
            head.next = node;
            node.next.prev = node;
        }

        private void MoveNodeToHead(DblNode node)
        {
            //pluck the node from current position

            node.prev.next = node.next;
            node.next.prev = node.prev;

            // Insert node to head

            InsertNodeToHead(node);
        }
    }
}
