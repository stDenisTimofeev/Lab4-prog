using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_prog
{
    interface IController
    {
        IModel Model { get; set; }
        void Add(string _text, Color _color);
        void Remove(Color _color);
        void Change(string _text, Color _color);
        void AddView(IView view);
    }
}
