using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_prog
{
    interface IView
    {
        IModel Model { get; set; }

        void UpdateView();
    }
}
