using FluentAssertions;

namespace FizzBuzzer.Tests;

[TestClass]
public class SingleTests
{
    [DataTestMethod]
    [DataRow(1, "1")]
    [DataRow(2, "2")]
    [DataRow(3, "3")]
    [DataRow(4, "4")]
    [DataRow(5, "5")]
    [DataRow(6, "6")]
    [DataRow(7, "7")]
    public void ShouldReturn_FizzBuzzVersion_FromNumber(int input, string expected)
    {
        var fizzBuzzer = new FizzBuzzer.Single();

        var result = FizzBuzzer.Single.FizzThis(input);

        result
            .Should()
            .Be(expected);
    }

}