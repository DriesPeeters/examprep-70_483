using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question91
{
    public delegate void MaximumTermReachedHandler(object source, EventArgs e);
    class Loan
    {
        private int _term;
        private const int MaximumTerm = 10;
        private const decimal Rate = 0.034m;

        public event MaximumTermReachedHandler OnMaximumTermReached;

        public int Term
        {
            get
            {
                return _term;
            }
            set
            {
                if(value <= MaximumTerm)
                {
                    _term = value;
                }
                else
                {
                    if(OnMaximumTermReached != null)
                    {
                        OnMaximumTermReached(this, new EventArgs());
                    }
                }
            }
        }
    }
}
