using BankService.ServiceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankService.DataBaseInteraction
{
    public class DataBaseManager
    {
        public bool AddBanknote(int denomination, long quantity)
        {
            BankDBEntities bankDBEntities = new BankDBEntities();

            try
            {
                bankDBEntities.Banknotes.Add(new Banknote { Denomination = denomination, Quantity = quantity });

                bankDBEntities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                bankDBEntities.Dispose();
            }
        }

        public List<BanknoteModel> GetAllInfo()
        {
            List<BanknoteModel> banknotes = new List<BanknoteModel>();

            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                foreach (var item in bankDBEntities.Banknotes)
                {
                    banknotes.Add(new BanknoteModel { Denomination = item.Denomination, Quantity = item.Quantity });
                }
            }

            return banknotes;
        }
    }
}