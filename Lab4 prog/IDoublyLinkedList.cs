using System.Collections.Generic;
using System.Drawing;
namespace Lab4_prog
{
    public interface IDoublyLinkedList<T> where T : INodeValueStruct
    {
        LinkedListNode<T> FindFirstByText(string _compareText);
        LinkedListNode<T> FindLastByText(string _compareText);
        LinkedListNode<T> FindFirstByColor(Color _compareColor);
        LinkedListNode<T> FindLastByColor(Color _compareColor);

    }
}