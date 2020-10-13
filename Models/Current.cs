using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Current
    {
        public float temp { get; set; }
        public float wind_speed { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public List<Weather> weather { get; set; }
    }
}
