using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface IRuleInterface
    {
        bool IsConditionTrue(int number);
        string GetSubstitue();
    }
}
