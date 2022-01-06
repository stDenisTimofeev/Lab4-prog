using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Lab4_prog
{
    interface IModel
    {
        DoublyLinkedList<NodeValueStruct> GetlistOfColoredText();

        void AddNode(string _newText, Color _newColor);

        void RemoveFirstByColor(Color _removeColor);

        void ChangeColorByText(string _findText, Color _newColor);

    }
}
