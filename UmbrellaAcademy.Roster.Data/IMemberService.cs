using UmbrellaAcademy.Roster.Domain;

namespace UmbrellaAcademy.Roster.Data
{
    public interface IMemberService
    {
        Member[] GetMembers(int pageSize, int pageIndex);
        Member? GetMember(short number);
    }
}
