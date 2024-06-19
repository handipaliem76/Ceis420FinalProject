using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceis420FinalProject
{
    public class SalesIterator : Iterator
    {
        private List<double> _sales;
        int position = 0;
        public SalesIterator(List<double> sales)
        {
            this._sales = sales;
        }

        public override double CurrentItem()
        {
            return _sales[position];
        }

        public override double First()
        {
            return _sales[0];
        }

        public override bool IsDone()
        {
            return position >= _sales.Count;
        }

        public override double? Next()
        {
            position++;
            if (IsDone())
                return null;
            return _sales[position];
        }
    }
}
