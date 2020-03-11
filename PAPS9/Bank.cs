using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS9
{
    class Bank: IObserver
    {
        public string Name { get; set; }
        IObservable acc;
        public Bank(string name,IObservable obs)
        {
            this.Name = name;
            acc = obs;
            acc.RegisterObserver(this);
        }
        public void Update(object obj)
        {
            AccountInfo accinfo = (AccountInfo)obj;
            Console.WriteLine("Владелец аккаунта номер " + accinfo.Owner + " имеет на счету сумму: " + accinfo.Balance);
        }
        public void BlockAccount()
        {
            acc.RemoveObserver(this);
            acc = null;
        }
    }
}
