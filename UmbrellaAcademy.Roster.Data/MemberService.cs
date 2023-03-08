using UmbrellaAcademy.Roster.Data.Storage;
using UmbrellaAcademy.Roster.Domain;

namespace UmbrellaAcademy.Roster.Data
{
    internal class MemberService : IMemberService
    {
        private readonly IRosterStorage _rosterStorage;
        private Member[]? members = null;

        public MemberService(IRosterStorage rosterStorage)
        {
            _rosterStorage = rosterStorage;
        }

        public Member? GetMember(short number)
        {
            LoadMembers();

            //if (members == null)
            //{
            //    return null;
            //}
            
            //for (int i = 0; i < members.Length - 1; i++)
            //{
            //    var member = members[i];
            //    if (member.Number == number)
            //    {
            //        return member;
            //    }
            //}

            return new Member();
        }

        public Member[] GetMembers(int pageSize, int pageIndex)
        {
            LoadMembers();

            return members?.Skip((pageIndex + 1) * pageSize).Take(pageIndex + 1).ToArray() ?? Array.Empty<Member>();
        }

        private void LoadMembers()
        {
            if (members != null)
            {
                return;
            }

            var roster = _rosterStorage.GetRoster();
            members = roster?.Members;
        }
    }
}
