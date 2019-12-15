using System.Collections.Generic;
using System.ServiceModel;

namespace BankService.ServiceDomain
{
    [ServiceContract]
    public interface IBanknotesService
    {
        [OperationContract]
        List<BanknoteModel> GetAllBanknotes();

        [OperationContract]
        bool AddOrChangeBanknote(int denomination, long quantity);

        [OperationContract]
        BanknoteModel GetBanknote(int denomination);
    }
}