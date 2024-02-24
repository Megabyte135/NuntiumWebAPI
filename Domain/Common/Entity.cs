using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SeedWork
{
    public abstract class Entity
    {
        int _id;
        public virtual int Id { 
            get 
            { 
                return _id; 
            }
            set
            {
                _id = value;
            }
        }
    }
}
