using BankService.DataBaseInteraction;
using BankService.ServiceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    public class BanknotesService : IBanknotesService
    {
        public List<BanknoteModel> GetAllInfo()
        {
            DataBaseManager dataBaseManager = new DataBaseManager();

            return dataBaseManager.GetAllInfo();
        }

        public bool AddBanknote(int denomination, long quantity)
        {
            DataBaseManager dataBaseManager = new DataBaseManager();

            return dataBaseManager.AddBanknote(denomination, quantity);
        }
    }
}