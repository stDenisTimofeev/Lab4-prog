using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_prog
{
    public class Model : IModel
    {
        public Model()
        {
        }

        private DoublyLinkedList<NodeValueStruct> listOfColoredText = new DoublyLinkedList<NodeValueStruct>();
        public DoublyLinkedList<NodeValueStruct> GetlistOfColoredText()
        {
            return listOfColoredText;
        }

        public void AddNode(string _newText, Color _newColor)
        {
            listOfColoredText.AddLast(new NodeValueStruct(_newText, _newColor));
        }

        public void RemoveFirstByColor(Color _removeColor)
        {
            LinkedListNode<NodeValueStruct> foundedNode = listOfColoredText.FindFirstByColor(_removeColor);
            if (foundedNode != null)
            {
                listOfColoredText.Remove(foundedNode);
            }
        }

        public void ChangeColorByText(string _findText, Color _newColor)
        {
            LinkedListNode<NodeValueStruct> foundedNode = listOfColoredText.FindFirstByText(_findText);
            if (foundedNode != null)
            {
                foundedNode.Value = new NodeValueStruct(foundedNode.Value.ValueText, _newColor);
            }
        }
    }
}
