using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShootScore
{
    abstract class WorldObject
    {
        public Guid ID { get; private set; }
        public string Name { get; protected set;}

        protected WorldObject()
        {
            ID = Guid.NewGuid();
        }
    }
}
