using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceis420FinalProject
{
    public abstract class Iterator
    {

        public abstract double First();
        public abstract double? Next();
        public abstract bool IsDone();
        public abstract double CurrentItem();

    }
}
