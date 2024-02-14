namespace FacilitiesTicketingAPI.Interfaces
{
    public interface IGenericService<T>
    {

        public Task<T> Get();
        public Task<T> Create();
        public Task<T> Update();
        public Task<T> Delete();
        public Task<IEnumerable<T>> GetList();
    }
}
