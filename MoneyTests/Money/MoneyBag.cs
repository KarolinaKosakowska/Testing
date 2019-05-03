using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class MoneyBag : IMoney
    {
        private ArrayList fMonies = new ArrayList(5);

        private MoneyBag()
        {

        }
        public MoneyBag(Money[] bag)
        {
            for (int i = 0; i < bag.Length; i++)
            {
                if (!bag[i].isZero)
                {
                    AppendMoney(bag[i]);
                }
            }
        }
        public MoneyBag(Money m1, Money m2)
        {
            AppendMoney(m1);
            AppendMoney(m2)
        }
        public MoneyBag(Money m, MoneyBag bag)
        {
            AppendMoney(m);
            AppendMoney(bag)
        }
        public MoneyBag(MoneyBag m1, MoneyBAg m2)
        {
            AppendMoney(m1);
            AppendMoney(m2)
        }
        public IMoney Add(IMoney m)
        {
            return m.AddMoneyBag(this);
        }
        public IMoney AddMoney(Money m)
        {
            return (new MoneyBag(m, this)).Simplify();
        }
        public IMoney AddMoneyBag(MoneyBag s)
        {
            return (new MoneyBag(s, this)).Simplify();
        }
        private void AppendBag(MoneyBag bag)
        {
            foreach (Money m in aBag.fMonies)
            {
                AppendMoney(m);
            }
        }
        private void AppendMoney(Money aMoney)
        {
            IMoney old = FindMoney(aMoney.Currency);
            if (old == null)
            {
                fMonies.Add(aMoney);
                return;
            }
            fMonies.Remove(old);
            IMoney sum = old.Add(aMoney);
            if (sum.isZero)
                return;
            fMonies.Add(sum);

        }
        private bool Contains(Money aMoney)
        {
            Money m = FindMOney(aMoney.Currency);
            return m.Amount == aMoney.Amount;
        }
        public override bool Equals(object anObject)
        {
            if (isZero)
                if (anObject is IMoney)
                    return ((IMoney)anObject).isZero;
            if (anObject is MoneyBag)
            {
                MoneyBag aMoneyBag = (MoneyBag)anObject;
                if (aMoneyBag.fMonies.Count != fMonies.Count)
                    return false;
                foreach (Money m in fMonies)
                {
                    if (!aMoneyBag.Contains(m))
                        return false;
                }
                return true;
            }
            return false;

            private Money FindMoney(string currency)
            {
                foreach (Money m in fMonies)
                    if (m.Currency.Equals(currency))
                        return m;
            }
            return null;
        }
        public override int GetHastCode()
        {
            int hash = 0;
            foreach (Money m in fMonies)
            {
                hash ^= m.GetHashCode();
            }

        }
    }
}

