using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS9
{
    class Account:IObservable
    {
        AccountInfo accountInfo;
        List<IObserver> observers;
        public Account()
        {
            observers = new List<IObserver>();
            accountInfo = new AccountInfo();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach(IObserver o in observers)
            {
                o.Update(accountInfo);
            }
        }
        public void GenerateData()
        {
            Random rnd = new Random();
            accountInfo.Balance = rnd.Next(100, 15000);
            accountInfo.Owner = rnd.Next(1000, 9999);
            NotifyObservers();
        }
    }
}
