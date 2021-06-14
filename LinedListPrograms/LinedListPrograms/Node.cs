using System;
using System.Collections.Generic;
using System.Text;

namespace LinedListPrograms
{
    public class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

    }
}
