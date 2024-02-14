using FacilitiesTicketingAPI.Interfaces;

namespace FacilitiesTicketingAPI.Services
{
    public class GenericService<T> : IGenericService<T>
    {
        public Task<T> Create()
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<T> Get()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
