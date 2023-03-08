# Umbrella Academy

This application contains the secret database of the Umbrella Acadamy.
However, this application is far from complete, therefore we need to fix it.

There are 6 challenges, where the last challenge is a bonus.

## Challenge 1
This repository is a template repository.
Create a new repository in your own GitHub account. Use this as your GitHub template.

Go to https://github.com and log in to your account.
Create a repository based on the template __mvanleijenhorst/UmbrellaAcademy__ and call it __UmbrellaAcademy__. 
This will create a repository with the code of the Umbrella Academy so far.

The pipeline will need to be configured (Pipelines are called Actions in GitHub).
We need to set some secrets and the retention period of the pipeline. Open you __repository__ of __UmbreallaAcademy__ and go to __Settings__, 
First we set the retention period of our pipeline to one day. Go to __Actions__ and __General__. Scroll down until you 
see __Artifact and log retention__ set this from 90 to 1 days and press __Save__.
So now all our artifacts (build applications) will only be available for one day.

The second part is to set the secrets. Go to __Secrets and variable__ and __Actions__.  
The actions have no secrets at the moment. 
We need to add to secrets. 
1. AZURE_CREDENTIALS
2. AZURE_RG

Both values are given to you by the Umbrella Code master.

We can start the pipeline after this is done. Go to __Actions__
On the Actions screen, you will see a workflow that is called __Buid and deploy ASP.NET Core App...__.
Select the workflow and press __Run Workflow__.

This will start the workflow. the first challenge is completed.

## Challenge 2
How strange, the pipeline has failed. That is not what we wanted. So we better get started on fixing this.
Get the code from GitHub and set it up locally. Now we need to fix the build.
Build the application and look at the error message, try to fix it.

If you fixed the problem, __commit__ and __push__ the changes to GitHub.
Look at GitHub's Actions. You see notice that your pipeline is started automatically, the pipeline is building you code.
When you fixed it correctly the application will be deployed to Azure.

Ask your Academy Code Master for the URL to check your application.

## Challenge 3
Now that we have created an application that compiles and runs, we would have observed that this is not a working application. 
The application is not returning any data about the Umbrella Academy members, we need to fix the issue.

Go to your __Visual Studio__ project and open the project __UmbrellaAcademy.Roster.Tests__. 
The class "MemberStoreTests" contains the automated tests for this application. 
Each of those tests is called a UnitTest, there are more automated tests. We will tackle more tests in future challenges.
In the MemberStoreTests.cs you will notice two methods that are commented out.

```csharp
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
```

Remove the "//" comments from the code and try to fix this test. 
(Tip! You could highlight the code and use visual studio shortcuts to uncomment the whole section, try CTRL+K -> CTRL+U).
But before you do that, read the below section about how the tests work.

### How do unit tests work
If you look above the method you will notice the attribute __[FACT]__ everything between brackets [] above a class or a method is called an attribute. 
The testing framework searches the code for the attribute "Fact" and that part of the code is used for running tests.

What we want to do in testing, is to put some logical tests and receive the outcome of those tests.
As we look at the test, we see three (AAA) parts in every test.
1. Assign; prepare your code and assign everything for the test.
2. Act; Execute the test.
3. Assert; Validate the test.

As we look at our test, we have on line 37 the below code
```csharp 
var foundMembers = memberService.GetMembers(2, 0);
```
This will check the GetMembers method of the service memberService with the parameters, page size of 2, and the first page (starting at 0). 

After that, we have multiple Asserts. Good tests don't need a lot of Asserts (Best practices typically have a maximum of 3 asserts). 
If you place too many asserts, it often means that your test is trying to test multiple functionalities.

The name of the functions needs to explain what you are testing.
Get_Members_Should_Return_Correct_Number_Of_Members, test that the number of records returned correctly.
Get_Members_Should_Return_Correct_Number_Of_MembersOnPage(), test the number of members on the page that are returned correctly.

Now go ahead and uncomment the tests, run them, and see the result. Time to fix some code.

## Challenge 4
Now we have the first test working. We now need to add functionality. We want to search for a Member by their number.
So searching by number 2 should return member number 2 and searching by number 13 should return no member.

The common and known exception is the NullReferenceException, this occurs when a variable is _null_ and you want to access some properties
In the latest c# language features is the '?' question mark at the end of the datatype. You will also see this project.
If there is a ? at the of a datatype, that means that the type can be _null_. 
Visual Studio will check the on compiling and gives you warnings if you return _null_ when that is not possible or try to call a method on a variable that can be _null_ without a null check.

Now try of fix the unit tests:
* Get_Member_By_Correct_Number_Should_Return_Correct_Member
* Get_Member_By_Wrong_Number_Should_Return_No_Member

And also implement the code behind the test. The service is not built yet.

## Challenge 5
We are almost there! In this challenge we want you to create a search on skills, so that we can find members by their special skills.

We didn't write tests and code. 
The test method needs the following name:
* Get_Member_By_Correct_Skill_Should_Return_Correct_Member
* Get_Member_By_Wrong_Skill_Should_Return_No_Member

Look at the class SkillController. A Controller is an API endpoint (API is a website for an application to get data from, and has now nice user interface). 
In our case there is already a controller and on line 24 a method.

``` csharp
        [HttpGet]
        [Route("member")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]        
        public IActionResult GetMemberSkills(string skill)
        {
            // TODO
            throw new NotImplementedException();
        }
```

This method needs to be implemented. Go to your website to find some example skills.

## Challenge 6 (Bonus!)
We are unable to identify the members, their photos are not appearing on the website!.
Look at the code, when you fix it, show the result to the Umbrella Academy code masters.
