using FsCheck;
using FsCheck.Xunit;
using static PrimeFactorsKata.PrimeNumberTestExtensions;

namespace PrimeFactorsKata;

internal static class PrimeNumberTestExtensions
{
    internal static bool IsPrime(int n) =>
        Enumerable.Range(1, n)
            .Where(i => !(i == 1 || i == n))
            .All(i => n.CannotBeDividedBy(i));

    private static bool CannotBeDividedBy(this int n, int i) =>
        n % i != 0;

    internal static int Multiplied(this IEnumerable<int> xs) =>
        xs.Aggregate(1, (product, i) => product * i);
}

public class WithPBT
{
    private static List<int> FactorsOf(int n) => throw new NotImplementedException();

    [Property]
    bool boolean_factorization_in_prime_numbers(PositiveInt positiveNumber)
    {
        var n = positiveNumber.Item;

        var factors = FactorsOf(n);

        return factors.All(IsPrime) && factors.Multiplied() == n;
    }
}
