using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzRule : IRuleInterface
    {
        public string GetSubstitue()
        {
            return "Fizz";
        }

        public bool IsConditionTrue(int number)
        {
            if (number % 3 == 0)
                return true;
            else return false;
        }
    }

    public class BuzzRule : IRuleInterface
    {
        public string GetSubstitue()
        {
            return "Buzz";
        }

        public bool IsConditionTrue(int number)
        {
            if (number % 5 == 0)
                return true;
            else return false;
        }
    }
    public class FizzBuzzRule : IRuleInterface
    {
        public string GetSubstitue()
        {
            return "FizzBuzz";
        }

        public bool IsConditionTrue(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return true;
            else return false;
        }
    }
    public class BarRule : IRuleInterface
    {
        public string GetSubstitue()
        {
            return "Bar";
        }

        public bool IsConditionTrue(int number)
        {
            if (number % 7 == 0)
                return true;
            else return false;
        }
    }

    public class FooRule : IRuleInterface
    {
        public string GetSubstitue()
        {
            return "Foo";
        }

        public bool IsConditionTrue(int number)
        {
            if (number * 10 > 100)
                return true;
            else return false;
        }
    }
}
