using System.Collections;

namespace Algorithms.Greedy
{
    public class Cashiers
    {
        public Cashiers() { }

        //Cashiers Problem
        public List<int> MakeChange(int n, int[] coins)
        {
            var Solution = new List<int>();
            int index = coins.Length - 1;
            //para cada moeda da lista de troco
            while (index >= 0)
            {   //enquanto a moeda atual ainda for menor ou igual a quantidade de troco (começando pela maior/Length-1)
                while (coins[index] <= n)
                {
                    //Adiciona a moeda ao conjunto solução e remove o valor da moeda da quantidade de troco necessaria
                    Solution.Add(coins[index]);
                    n = n - coins[index];
                }
                index--;
            }
            return Solution;
        }
    }
}