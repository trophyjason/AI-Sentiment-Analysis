using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class Project
    {
        private static int _NextID = 100;
        public int _ID { get; set; }
        public double _Sale { get; private set; }
        public double _Purchase { get; private set; }
        public List<KeyValuePair<string, double>> _Sales { get; private set; }
        public List<KeyValuePair<string, double>> _Purchases { get; private set; }
        public static List<int> _IDS = new List<int>();
        public Project(double pAmount)
        {
            _Sales = new List<KeyValuePair<string, double>>();
            _Purchases = new List<KeyValuePair<string, double>>();
            _Purchase = pAmount;

            int count = 0;
            while (_IDS.Count() != count)
            {
                count = 0;
                foreach (int id in _IDS)
                {
                    if (id != _NextID)
                    {
                        count++;
                    }
                    else
                    {
                        _NextID++;
                        break;
                    }
                }
            }

            _ID = _NextID;
            _IDS.Add(_ID);
            _NextID++;
        }
        public Project(double pAmount, int pID)
        {
            _Sales = new List<KeyValuePair<string, double>>();
            _Purchases = new List<KeyValuePair<string, double>>();
            _Purchase = pAmount;

            _ID = pID;
            _IDS.Add(_ID);
        }

        public void AddPurchase (string pType, double pPurchase)
        {
            _Purchases.Add(new KeyValuePair<string, double>(pType, pPurchase));
        }

        public void AddSale(string pType, double pSale)
        {
            _Sales.Add(new KeyValuePair<string, double>(pType, pSale));
        }
        public double TotalSales ()
        {
            double totalSales = 0;
            foreach (KeyValuePair<string, double> pair in _Sales)
            {
                totalSales+=pair.Value;
            }
            return totalSales;
        }
        public double TotalPurchases ()
        {
            double totalPurchases = 0;
            foreach (KeyValuePair<string, double> pair in _Purchases)
            {
                totalPurchases += pair.Value;
            }
            return totalPurchases;
        }
        public virtual double Refund () 
        {
            return 0;
        }
        public double Profit()
        {
            double profit;
            profit = (TotalSales() - TotalPurchases()) + Refund();
            return profit;
        }
    }
}
