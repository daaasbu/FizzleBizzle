Create a class that implements the interface below. Then create a simple ASP.NET Web
Forms or MVC application that accepts input from the user and displays the output.
Please use Twitter Bootstrap as your UI framework. Please implement the UI using the
three attached .jpg files.
In your response, take into consideration not just correctness, but also reusability and
maintainability.
Submit a ZIP file that includes your complete project that opens, builds, and will run in
Visual Studio.

Pre-reqs:
Have node/npm installed
Have visual studio 2017 (community edition is fine) / .NET Core version 1.1

Steps to run:
Navigate to directory you want to clone project in
git clone https://github.com/daaasbu/FizzleBizzle.git
cd FizzleBizzle
dotnet restore FizzleBizzle/FizzleBizzle.Project/FizzleBizzle.Project.csproj
dotnet restore FizzleBizzle/FizzleBizzle.Test/FizzleBizzle.Test.csproj
dotnet publish FizzleBizzle/FizzleBizzle.Project/FizzleBizzle.Project.csproj

dotnet run bin\Debug\netcoreapp1.1\FizzleBizzle.Project.dll

In browser navigate to localhost:5000 which application is currently running on.


