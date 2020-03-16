using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShorashimSystem
{
    public enum OrderStatus /*instead of class its "public enum" thats the difference!*/
    {
        Finished,
        Hold,
        Canceled,
        UnderTreatment
    }
}
