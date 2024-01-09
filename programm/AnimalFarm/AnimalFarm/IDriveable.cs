using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal interface IDriveable
    {
        string LicenesePLate { get; set; }

        void setOwner(Farmer farmer);

        void getOwner(Farmer owner);
    }
}
