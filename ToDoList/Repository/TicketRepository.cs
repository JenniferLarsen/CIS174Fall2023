using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Repository
{
    public class TicketRepository : ITicketRepository<Ticket>
    {
        private readonly TicketContext _context;

        public TicketRepository(TicketContext context)
        {
            _context = context;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        public Ticket GetById(int id)
        {
            return _context.Tickets.Find(id);
        }

        public void Add(Ticket entity)
        {
            _context.Tickets.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Ticket entity)
        {
            _context.Tickets.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Tickets.Find(id);
            if (entity != null)
            {
                _context.Tickets.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Status> GetAllStatuses()
        {
            return _context.Statuses.ToList();
        }

        // Implement other ticket-specific methods if needed
    }
}
