

namespace Money
{
    /// <summary>
    /// Ten interface jest do pieniędzy
    /// </summary>
    interface IMoney
    {
        IMoney Add(IMoney m);
        IMoney AddMoney(Money m);
        IMoney AddMoneyBag(MoneyBag s);

        bool isZero { get; }

        IMoney Multiply(int factor);
        IMoney Negate();
        IMoney Substract();
    }
}
