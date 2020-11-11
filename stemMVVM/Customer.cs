using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stemMVVM
{
    public class Customer
    {
        //字段
        private string customerName;
        private double amount;
        private string married;
        private double tax;

        //属性（由字段自动封装生成）
        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string Married
        {
            get
            {
                return married;
            }

            set
            {
                married = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }

        }

        //方法
        public void CalculateTax()
        {
            if (amount > 2000) { tax = 20; }
            else if (amount > 1000) { tax = 10; }
            else { tax = 5; }
        }

        public bool IsValid()
        {
            if(amount == 0) { return false; }
            else { return true; }
        }
    }
}
