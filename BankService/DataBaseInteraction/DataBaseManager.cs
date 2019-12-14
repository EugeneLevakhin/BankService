using BankService.ServiceDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankService.DataBaseInteraction
{
    public sealed class DataBaseManager
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

        public List<BanknoteModel> GetAllBanknotes()
        {
            List<BanknoteModel> banknotes = new List<BanknoteModel>();

            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                foreach (var item in bankDBEntities.Banknotes)
                {
                    banknotes.Add(new BanknoteModel(item.Denomination, item.Quantity));
                }
            }

            return banknotes;
        }

        public BanknoteModel GetBanknote(int denomination)
        {
            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                return bankDBEntities.Banknotes
                    .Where(b => b.Denomination == denomination)
                    .ToArray()
                    .Select(b => new BanknoteModel(b.Denomination, b.Quantity))
                    .FirstOrDefault();
            }
        }
    }
}