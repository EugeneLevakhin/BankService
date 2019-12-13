using System.Runtime.Serialization;

namespace BankService.ServiceDomain
{
    [DataContract]
    public sealed class BanknoteModel
    {
        private int _denomination;
        private long _quantity;

        [DataMember]
        public int Denomination
        {
            get { return _denomination; }
            set { _denomination = value; }
        }

        [DataMember]
        public long Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public BanknoteModel(int denomination, long quantity)
        {
            Denomination = denomination;
            Quantity = quantity;
        }
    }
}