using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_prog
{
    class RichTextBoxView : RichTextBox, IView
    {
        public RichTextBoxView()
        {
        }

        public IModel Model { get; set; }

        public void UpdateView()
        {
            DoublyLinkedList<NodeValueStruct> listOfColoredText = Model.GetlistOfColoredText();
            
            var _currentNode = listOfColoredText.First;

            this.Clear();

            do
            {
                if (_currentNode != null)
                {
                    this.SelectionStart = this.TextLength;
                    this.SelectionLength = 0;

                    this.SelectionColor = _currentNode.Value.ValueColor;
                    this.AppendText(_currentNode.Value.ValueText + Environment.NewLine);
                    this.SelectionColor = this.ForeColor;
                }

                _currentNode = _currentNode.Next;
            } while (_currentNode != null);

            //this.Show();
            //this.Refresh();
            //this.Update();
            //this.UpdateView();
        }
    }
}
