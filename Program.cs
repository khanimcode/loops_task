using System;

namespace intro3_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1
            #region
         //   int n = 10;
         //   int sum = 0;
         //   int count= 0;
         //   for(int i = 1; i <= n; i++)
         //   {
         //       if (i % 2 == 0)
         //       {
         //           sum += i;
         //           count++;
                   
         //       }
         //   }
         //float avarage   = sum / count;
         //   Console.WriteLine(avarage);



            #endregion
            //TASK-2
            #region
            int num = 356;
            int sum = 0;
            int digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                num = num / 10;

            }
            Console.WriteLine(sum);
            #endregion
















        }
    }
}
