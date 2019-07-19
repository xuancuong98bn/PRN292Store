using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    public class Payment : ITax
    {
        public delegate void OnAmountChanged(float oldValue, float newValue);
        public event OnAmountChanged AmountChanged;

        float amount;

        public Payment()
        {
        }

        public Payment(float amount)
        {
            this.Amount = amount;
        }

        public float Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (Amount != value && AmountChanged != null)
                {
                    AmountChanged(Amount, value);
                }
                amount = value;
            }
        }

        public float ComputeTax()
        {
            return Amount / 10;
        }
    }
}
