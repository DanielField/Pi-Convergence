using System;

namespace Pi {
    class Program {

        /// <summary>
        /// Calculate pi using an infinite series which converges on pi.
        /// This method is based on Gottfried Leibniz's formula.
        /// 
        /// The method is faster without Console.WriteLine, but still slow.
        /// Though it's nice to see it slowly converging. :)
        /// </summary>
        static void ConvergeOnPi() {
            decimal pi = 0m;
            decimal i = 1m;
            while (true) {
                // Determine whether to add or subtract based on whether i = 1 (mod 4)
                pi += i % 4m == 1m ? (4m / i) : -(4m / i);
                Console.WriteLine(pi);
                i += 2m; // Set i equal to the next odd number.
            }
        }

        static void Main(string[] args) {
            ConvergeOnPi();
        }
    }
}
