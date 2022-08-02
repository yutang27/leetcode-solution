using static System.Console;

namespace BasicClassLibrary
{
    public class ListOp
    {
        // 在指定节点的尾部添加一个节点
        public static ListNode Add(int val, ListNode node)
        {
            ListNode new_node = new(val);
            node.next = new_node;

            return new_node;
        }

        // 初始化一个链表
        public static ListNode? Init_list(int[] vals)
        {
            if (vals.Length == 0)
            {
                return null;
            }

            ListNode begin_node = new ListNode();
            begin_node.val = vals[0];

            ListNode iter = begin_node;

            for (int i = 1; i < vals.Length; ++i)
            {
                iter = Add(vals[i], iter);
            }

            return begin_node;
        }

        // 遍历并打印一个链表
        public static void Print(string name, ListNode node)
        {
            Write("list {0}: ", name);
            while (node != null)
            {
                Write("{0}, ", node.val);
                node = node.next;
            }
            WriteLine();
        }
    }
}
