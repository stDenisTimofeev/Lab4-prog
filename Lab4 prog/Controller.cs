using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_prog
{
    class Controller : IController
    {
        Model model = new Model();
        List<IView> views = new List<IView>();

        public IModel Model { get => model; set => model = (Model)value; }

        public void AddView(IView view)
        {
            views.Add(view);
        }

        private void UpdateAll()
        {
            foreach (var v in views)
                v.UpdateView();
        }


        public void Add(string _text, Color _color)
        {
            model.AddNode(_text, _color);
            UpdateAll();
        }

  
        public void Change(string _text, Color _color)
        {
            model.ChangeColorByText(_text, _color);
            UpdateAll();
        }

        public void Remove(Color _color)
        {
            model.RemoveFirstByColor(_color);
            UpdateAll();
        }
    }
}
