using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        List<IRuleInterface> rules = new List<IRuleInterface>();
        public void AddRulesToCheck()
        {
            rules.Add(new FizzBuzzRule());
            rules.Add(new FizzRule());
            rules.Add(new BuzzRule());
            rules.Add(new BarRule());
            rules.Add(new FooRule());
        }
        public string CheckElement(int number)
        {
            foreach (var rule in rules)
            {
                if (rule.IsConditionTrue(number))
                    return rule.GetSubstitue();
            }
            return number.ToString();
        }
        public void Run(int limit = 100)
        {
            AddRulesToCheck();
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(CheckElement(i));
            }
        }
        
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();
            engine.Run();
        }
    }
}
