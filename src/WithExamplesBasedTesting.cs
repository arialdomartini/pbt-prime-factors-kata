using Xunit;

namespace PrimeFactorsKata;

public class WithExamplesBasedTesting
{
    private static List<int> FactorsOf(int n)
    {
        throw new NotImplementedException();
    }

    [Fact]
    void just_pass()
    {
        Assert.True(true);
    }
}
