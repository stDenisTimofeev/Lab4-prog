using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Lab4_prog
{
    public class DoublyLinkedList<T> : LinkedList<T>, IDoublyLinkedList<T>
        where T : INodeValueStruct
    {
        public LinkedListNode<T> FindFirstByText(string _compareText)
        {
            var _currentNode = First;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueText == _compareText)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Next;
            } while (_currentNode != null);

            return _currentNode;
        }

        public LinkedListNode<T> FindLastByText(string _compareText)
        {
            var _currentNode = Last;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueText == _compareText)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Previous;
            } while (_currentNode != null);

            return _currentNode;
        }

        public LinkedListNode<T> FindFirstByColor(Color _compareColor)
        {
            var _currentNode = First;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueColor == _compareColor)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Next;
            } while (_currentNode != null);

            return _currentNode;
        }

        public LinkedListNode<T> FindLastByColor(Color _compareColor)
        {
            var _currentNode = Last;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueColor == _compareColor)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Previous;
            } while (_currentNode != null);

            return _currentNode;
        }
    }
}