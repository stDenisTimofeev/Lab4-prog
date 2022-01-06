using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_prog
{

    public struct NodeValueStruct : INodeValueStruct
    {
        public string ValueText { get; set; }
        public Color ValueColor { get; set; }
        public NodeValueStruct(string valueText, Color valueColor)
        {
            ValueText = valueText;
            ValueColor = valueColor;
        }
    }
}
