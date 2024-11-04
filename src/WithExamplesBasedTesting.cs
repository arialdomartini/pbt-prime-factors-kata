using Xunit;

namespace PrimeFactorsKata;

public class WithExamplesBasedTesting
{
    private static List<int> FactorsOf(int n) => throw new NotImplementedException();

    [Fact]
    void factors_of_1()
    {
        Assert.Equal([], FactorsOf(1));
    }

    [Fact]
    void factors_of_2()
    {
        Assert.Equal([2], FactorsOf(2));
    }

    [Fact]
    void factors_of_3()
    {
        Assert.Equal([3], FactorsOf(3));
    }

    [Fact]
    void factors_of_4()
    {
        Assert.Equal([2, 2], FactorsOf(4));
    }

    [Fact]
    void factors_of_5()
    {
        Assert.Equal([5], FactorsOf(5));
    }

    [Fact]
    void factors_of_6()
    {
        Assert.Equal([2, 3], FactorsOf(6));
    }

    [Fact]
    void factors_of_7()
    {
        Assert.Equal([7], FactorsOf(7));
    }

    [Fact]
    void factors_of_8()
    {
        Assert.Equal([2, 2, 2], FactorsOf(8));
    }
    
    [Fact]
    void factors_of_9()
    {
        Assert.Equal([3, 3], FactorsOf(9));
    }
}
