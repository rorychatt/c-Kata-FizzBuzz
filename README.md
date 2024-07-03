# Commands for building project from scratch

```
dotnet new sln
dotnet new mstest -o FizzBuzzer.Tests
dotnet new classlib -o FizzBuzzer
dotnet sln add ./FizzBuzzer.Tests/FizzBuzzer.Tests.csproj
dotnet sln add ./FizzBuzzer/FizzBuzzer.csproj
dotnet add ./FizzBuzzer.Tests/FizzBuzzer.Tests.csproj reference ./FizzBuzzer/FizzBuzzer.csproj
dotnet add ./FizzBuzzer.Tests/FizzBuzzer.Tests.csproj package FluentAssertions
dotnet build
dotnet test
dotnet watch test --project FizzBuzzer.Tests

```