using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_app.Models
{
    public class Model
    {
        public string Data { get; set; }

        public void LoadData()
        {
            Data = "Hello, MVP!";
        }
    }
}
