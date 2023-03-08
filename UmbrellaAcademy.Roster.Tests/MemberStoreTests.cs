using UmbrellaAcademy.Roster.Data;
using UmbrellaAcademy.Roster.Domain;

namespace UmbrellaAcademy.Roster.Tests
{
    public class MemberStoreTests
    {
        private readonly FakeRosterStorage _rosterStorage;

        public MemberStoreTests()
        {
            _rosterStorage = new FakeRosterStorage();

        }

        //[Fact]
        //public void Get_Members_Should_Return_Correct_Number_Of_Members()
        //{
        //    _rosterStorage.ClearMembers();

        //    var memberOne = new Member
        //    {
        //        Number = 1,
        //        Name = "Frankie"
        //    };

        //    var memberTwo = new Member
        //    {
        //        Number = 2,
        //        Name = "Jackie"
        //    };

        //    _rosterStorage.AddMember(memberOne);
        //    _rosterStorage.AddMember(memberTwo);

        //    var memberService = new MemberService(_rosterStorage);
        //    var foundMembers = memberService.GetMembers(2, 0);

        //    Assert.Equal(memberOne, foundMembers.ElementAtOrDefault(0));

        //    Assert.Equal(memberTwo, foundMembers.ElementAtOrDefault(1));

        //    Assert.Null(foundMembers.ElementAtOrDefault(2));

        //}

        //[Fact]
        //public void Get_Members_Should_Return_Correct_Number_Of_MembersOnPage()
        //{
        //    _rosterStorage.ClearMembers();
        //
        //    var memberOne = new Member
        //    {
        //        Number = 1,
        //        Name = "Frankie"
        //    };

        //    var memberTwo = new Member
        //    {
        //        Number = 2,
        //        Name = "Jackie"
        //    };

        //    _rosterStorage.AddMember(memberOne);
        //    _rosterStorage.AddMember(memberTwo);

        //    var memberService = new MemberService(_rosterStorage);
        //    var foundMembers = memberService.GetMembers(1, 1);

        //    Assert.Equal(memberTwo, foundMembers.ElementAtOrDefault(0));

        //    Assert.Null(foundMembers.ElementAtOrDefault(1));
        //}

        

        //[Fact]
        //public void Get_Member_By_Correct_Number_Should_Return_Correct_Member()
        //{
        //_rosterStorage.ClearMembers();

        //var memberOne = new Member
        //{
        //    Number = 1,
        //    Name = "Frankie"
        //};

        //var memberTwo = new Member
        //{
        //    Number = 2,
        //    Name = "Jackie"
        //};

        //_rosterStorage.AddMember(memberOne);
        //_rosterStorage.AddMember(memberTwo);

        //// Write test
        //var memberService = new MemberService(_rosterStorage);            
        //}

        //[Fact]
        //public void Get_Member_By_Wrong_Number_Should_Return_No_Member()
        //{
        //_rosterStorage.ClearMembers();

        //var memberOne = new Member
        //{
        //    Number = 1,
        //    Name = "Frankie"
        //};

        //var memberTwo = new Member
        //{
        //    Number = 2,
        //    Name = "Jackie"
        //};

        //_rosterStorage.AddMember(memberOne);
        //_rosterStorage.AddMember(memberTwo);

        // Write test
        //var memberService = new MemberService(_rosterStorage);
    }
}
}
