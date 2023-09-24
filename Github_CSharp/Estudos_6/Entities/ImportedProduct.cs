
using System.Globalization;

namespace Estudos4.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double totalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
