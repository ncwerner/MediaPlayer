using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearPlayer
{
    public class Dequeue
    {
        private List<string> dequeue;


        public Dequeue()
        {
            dequeue = new List<string>();
        }

        public int Count()
        {
            return dequeue.Count;
        }

        public void Push_Front(string s)
        {
            dequeue.Insert(0, s);
        }

        public string Pop_Front()
        {
            string ret = dequeue[0];
            dequeue.RemoveAt(0);
            return ret;
        }
        public string view_Top()
        {
            string ret = dequeue[0];
            return ret;
        }
        public void Push_Back(string s)
        {
            dequeue.Add(s);
        }

        public string Pop_Back()
        {
            string ret = dequeue[dequeue.Count - 1];
            dequeue.RemoveAt(dequeue.Count - 1);
            return ret;
        }

        public void Clear()
        {
            dequeue.Clear();
        }

        public string ElementAt(int i)
        {
            return dequeue.ElementAt(i);
        }

        public void Remove_Element(string s)
        {
            dequeue.Remove(s);
        }

        public string[] ToArray()
        {
            return dequeue.ToArray();
        }
    }
}
