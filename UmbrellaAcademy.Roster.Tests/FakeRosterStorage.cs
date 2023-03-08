using UmbrellaAcademy.Roster.Data.Storage;
using UmbrellaAcademy.Roster.Domain;

namespace UmbrellaAcademy.Roster.Tests
{
    internal class FakeRosterStorage : IRosterStorage
    {
        private readonly Domain.Roster _roster;

        public FakeRosterStorage()
        {
            _roster = new Domain.Roster();
        }

        public void AddMember(Member member)
        {
            _roster.Members = _roster.Members!.Concat(new[] { member }).ToArray();
        }

        public void ClearMembers()
        {
            _roster.Members = Array.Empty<Member>();
        }

        public Domain.Roster GetRoster()
        {
            return _roster;
        }
    }
}
