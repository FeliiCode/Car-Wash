using Car_Wash.Data;
using Car_Wash.Model;

namespace Car_Wash.Service
{
    public class CustomerService
    {
        private readonly AppDbContext _db;
        public CustomerService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Customers.OrderBy(m => m.Name)
                .Select(m => new 
                {
                    m.Id,
                    DisplayName = m.CustomerId + " - " + m.Name
                })
                .ToList<object>();
            return list;
        }

        public Customer? FindById(int id)
        {
            return _db.Customers.FirstOrDefault(x => x.Id == id);
        }

        public List<Customer> SetGrid()
        {
            return
                _db.Customers.ToList<Customer>();
        }

        public async void Update(Customer member)
        {
            _db.Customers.Update(member);
            await _db.SaveChangesAsync();
        }
    }
}
