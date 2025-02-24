using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

class CustomerContactRepository(DataContext context) : BaseRepository<CustomerContactEntity>(context), ICustomerContactRepository
{
}
