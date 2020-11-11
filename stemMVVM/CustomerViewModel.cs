using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace stemMVVM
{
    public class CustomerViewModel: INotifyPropertyChanged
    {
        //字段，customer
        private Customer obj = new Customer();

        //属性，customer的转换逻辑
        public string TxtCustomerName
        {
            get { return obj.CustomerName;}
            set{ obj.CustomerName = value;}
        }

        public string TxtAmount
        {
            get { return Convert.ToString(obj.Amount); }
            set { obj.Amount = Convert.ToDouble(value); }
        }

        public string AmountColor
        {
            get
            {
                if(obj.Amount>2000) { return "Blue";}
                else if (obj.Amount > 1500) { return "Red"; }
                return "Yellow";
            }
        }

        public bool IsMarried
        {
            get
            {
                if(obj.Married == "Married") { return true; }
                else { return false; }
            }
        }

        public string TxtTax
        {
            get { return Convert.ToString(obj.Tax); }           
        }

        //方法
        public event PropertyChangedEventHandler PropertyChanged;
        public void Calculate()
        {
            obj.CalculateTax();

            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("TxtTax"));
            }            
        }



        private ButtonCommand objCommand;
        public CustomerViewModel()
        {
            objCommand = new ButtonCommand(Calculate,obj.IsValid);
        }

        public ICommand btnClick
        {
            get
            {
                return objCommand;
            }
        }
    }
}
