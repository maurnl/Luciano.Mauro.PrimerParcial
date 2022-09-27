    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public abstract class EntidadBase
    {
        protected int id;
        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
