using ToDoList.Models;

namespace ToDoList.Repository
{
    public interface ITicketRepository<T> : IRepository<Ticket>
    {
        IEnumerable<Status> GetAllStatuses();
 
    }
}