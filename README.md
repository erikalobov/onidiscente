Code challenge.

At this code challenge we are looking for your coding skills, familiarity with C#, ASP.Net core framework,
Entity Framework, Unit Testing, React, Typescript, utilizing best practices, clean coding, reusability,
version control, teamwork and problem solving.
This challenge consists of multiple steps, and it is based on C#, ASP.Net Core, React, and Typescript. We’d
like you to follow through each step and solve the problem and more importantly use version control (git)
while you are progressing. You can have multiple branches and commits, but what we expect is, when you
reach to the solid answer to a question, the latest commit that represents the answer to the question
should be tagged.
You can define the format of the tag name, but as an example it can be question1, question_1, V1.0, v1.0,
step1 or step_1.
And finally, the complete code challenge should be on a versioning control platform (github, gitlab and
etc...) as a repository.
Provide the link to the repository, and we evaluate the code challenge as soon as possible.

1. Start an empty solution. Create an ASP.Net Core Web Application. Choose ASP .NET Core 5 and
API for the template of the project. Configure the HTTPS on the API project.
Follow the given patterns to name the solution: <<yourname>> _codechallenge
Follow the given patterns to name the project: CodeChallenge.API
2. Prepare a supporting architecture (classes/entities) for the following situation. With having the
concept of reusability in mind.
We have an application that requires to show the list of departments in the company to the
company manager. Each department will have a name and a unique address.
Departments are consisting of employees. Like a regular employee they will have, first name, last
name, job title and address of residence (mailing address)
** You are not required to break the address down to the country, state, city level. An address
field is enough for the code challenge purpose.
3. Define a service Implementation for the following functionality.
For Employees we need to have these functionalities. The method signatures should be exactly
the same as follows:
IEnumerable<Employee> GetAll()
IList<Employee> ListAll()
Since we are not using a database, provide 2-3 test data.

4. Provide a RESTful API controller for employees and provide these two endpoints.
GET api/employees
GET api/employees/department/{departmentId}
5. Add the docker and docker compose support to the solution and API project.
6. Imagine we are connected to the Database now. We’d like to switch from in Memory
implementation of Employee service to the database implementation. Suggest and apply a way
to switch from your previous implementation to the new one and consider the methods you
implemented before.
IEnumerable<Employee> GetAll()
IList<Employee> ListAll()
** Database and Entity Framework implementation is not required.
7. Using React Native with Typescript or Uno Platform with C# develop an Android App to display
the data returned by the REST api. The interface should list all departments. Clicking a
department directs you to that department’s list of employees. Clicking an Employee directs
you to the employee’s details page. You should also put back links to return to the previous
pages.
8. Add a console project to the solution. Add this class to the console project.
public static class QuestionClass
{
static List<string> NamesList = new List<string>()
{
"Jimmy",
"Jeffrey",
"John",
};
}
Iterate through the NamesList items without using ForEach/For loops.
9. Create a method called TESTModule, this method simply is a method that we pass values to it,
and it returns the result.
With one Switch Statement, cover the provided requirements.
A. For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
B. For any integer value bigger than 4, multiply the provided value by 3 and return the result.
C. for integer values below 1, throw proper exception.
D. For float values of 1.0f and 2.0f return 3.0f
E. For any string values convert them to UpperCase.
F. for anything else, return the input value itself.
10. Add an AWS Lambda Project to the solution, write a simple lambda to catch DynamoDbEvent,
Debug/Mock the lambda function, log (console log) the Id of updated DynamoDb entries.
