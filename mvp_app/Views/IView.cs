using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_app.Views
{
    public interface IView
    {
        void DisplayData(string data, float fontSize);
    }
}
