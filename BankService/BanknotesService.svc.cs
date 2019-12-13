using BankService.DataBaseInteraction;
using BankService.ServiceDomain;
using System.Collections.Generic;

namespace BankService
{
    public sealed class BanknotesService : IBanknotesService
    {
        private readonly DataBaseManager _dataBaseManager;

        public BanknotesService()
        {
            _dataBaseManager = new DataBaseManager();
        }

        public List<BanknoteModel> GetAllBanknotes()
        {
            return _dataBaseManager.GetAllBanknotes();
        }

        public bool AddBanknote(int denomination, long quantity)
        {
            return _dataBaseManager.AddBanknote(denomination, quantity);
        }

        public BanknoteModel GetBanknote(int denomination)
        {
            return _dataBaseManager.GetBanknote(denomination);
        }
    }
}