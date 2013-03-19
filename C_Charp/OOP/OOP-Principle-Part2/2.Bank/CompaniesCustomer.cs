
namespace _2.Bank
{
    class CompaniesCustomer : Customer
    {
        private string NameCompanies { get; set; }

        public CompaniesCustomer(string nameCompanies)
            : base(null, null)
        {
            this.NameCompanies = nameCompanies;
        }
    }
}
