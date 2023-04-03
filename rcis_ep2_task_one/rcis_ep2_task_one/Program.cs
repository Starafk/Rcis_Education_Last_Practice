using System;

namespace Program
{
    public class Program
    {
        // 1 Задание
        static void Main()
        {
            Console.Write("Введите драгоценности: ");
            string js = Console.ReadLine();
            Console.Write("Введите камни: ");
            string se  = Console.ReadLine();
            
            int result = 0;
            
            for (int i = 0; i < js.Length; ++i)
            {
                for (int j = 0; j < se.Length; ++j)
                {
                    if (js[i] == se[j])
                    {
                        result += 1;
                    }
                }
            }
            Console.WriteLine(result);
        }
        // 2 Задание
        static void Main()
        {
            List<int> candidates = new List<int>() {10,1,2,7,6,1,5,3};
            const int target = 8;
            candidates.Sort();

            List<int> combination = new List<int>();

            List<List<int>> result = new List<List<int>>();
            
            TwoFunk(combination, candidates, target, result);
        }

        static void TwoFunk(List<int> combination, List<int> candidates, int target, List<List<int>> result)
        {
            if (combination.Sum() == target)
            {
                bool isSpecial = true;
                for (int i = 0; i < result.Count; ++i)
                {
                    if (Enumerable.SequenceEqual(result[i], combination))
                    {
                        isSpecial = false;
                    }
                }

                if (isSpecial)
                {
                    result.Add(combination);
                    Console.Write($"[");
                    for (int i = 0; i < combination.Count; ++i)
                    {
                        Console.Write($" {combination[i]} ");
                    }
                    Console.WriteLine($"]");
                }
            }

            if (combination.Sum() >= target)
            {
                return;
            }

            for (int i = 0; i < candidates.Count; ++i)
            {
                var newArray = new List<int>();
                for (int k = i + 1; k < candidates.Count; ++k)
                {
                    newArray.Add(candidates[k]);
                }
                
                var reCombination = new List<int>(combination) { candidates[i] };
                
                TwoFunk(reCombination, newArray , target, result);
            }
        }
        // 3 Задание
        static void Main()
        {
            int[] array = new[] { 3, 11, 24, 5, 345 , 99 };
            Console.WriteLine(ThreeFunk(array));
        }
        static bool ThreeFunk(int[] array)
        {
            if (array.Length != array.Distinct().Count())
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
