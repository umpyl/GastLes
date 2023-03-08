using UmbrellaAcademy.Roster.Data.Infrastructure;

namespace UmbrellaAcademy.Roster.Data.Storage
{
    internal class RosterStorage : IRosterStorage
    {
        private readonly RosterContext _context;

        public RosterStorage(RosterContext context)
        {
            _context = context;
        }

        public Domain.Roster GetRoster()
        {
            return _context.Roster;
        }
    }
}
