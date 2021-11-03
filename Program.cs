using System;

namespace C_Task_1._7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-2
            /* int[] Arry = { 7, 8, 3, 7, 9, 4, 3, 5, 11 };
            arg(Arry);*/
            #endregion

            #region Task-3
            /*  int[] Arry1 = { 7, 8, 3, 4, 5, 6 };
            Console.WriteLine("please enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            argss(Arry1, a);*/
            #endregion

            #region Task-4

            /*string a = "Salam Aleykum necesen ne var ne yox ";

            substring(a);*/
            #endregion

            #region Task-5 
            /*
                        int[] Arry2 = new int[] { 7, 8, 3, 4, 22, 5, };
                        int i, max, min ;
                        max = Arry2[0];
                        min = Arry2[0];

                        for (i = 1; i < Arry2.Length; i++)
                        {
                            if (Arry2[i] > max)
                            {
                                max = Arry2[i];
                            }


                            if (Arry2[i] < min)
                            {
                                min = Arry2[i];
                            }
                        }
                        Console.Write("Max element : {0}\n", max);
                        Console.Write("Min element : {0}\n\n", min);
            */

            #endregion

            #region Task-6 
            /*  int[] a = { 30, 28, 2, 14 };
              int[] b = { 5, 49, 7, 64 };
              int[] MergeArr = new int[a.Length + b.Length];
              a.CopyTo(MergeArr, 0);
              b.CopyTo(MergeArr, a.Length);
              Array.Sort(MergeArr);
              for (int i = MergeArr.Length - 1; i >= 0; i--)
              {
                  Console.WriteLine(MergeArr[i] + " ");
              }*/


            #endregion

            #region Task-7
            /* int[] Arry3 = { 44, 8, 23, 47, 80, 6, 77, 18, 9, 40 };
             int[] cut = new int[0];
             int[] tek = new int[0];

             for (int i = 0; i < Arry3.Length; i++)
             {
                 if (Arry3[i] % 2 == 0)
                 {
                     Array.Resize(ref cut, cut.Length + 1);
                     cut[cut.Length - 1] = Arry3[i];
                 }
                 else
                 {
                     Array.Resize(ref tek, tek.Length + 1);
                     tek[tek.Length - 1] = Arry3[i];
                 }
             }
             foreach (var temp in cut)
             {
                 Console.WriteLine($"cut {temp} ");

             }
             foreach (var temp in tek)
             {
                 Console.WriteLine($"tek {temp} ");
             }*/
            #endregion

            #region Task-8
            /*Console.WriteLine("metni daxil edin");
            string a = Console.ReadLine();

            Console.WriteLine($"daxil edilen metn: {a} ");*/
            #endregion

            #region Task-9

            /*string a = Console.ReadLine();

            Console.WriteLine(a.Length);*/

            #endregion

            #region Task-10

            /* string a = "Salam Aleykum";

             for (int i = a.Length - 1; i >= 0; i--)
             {
                 Console.Write(a[i] + " ");
             }
 */
            #endregion

            #region Task-13

            /* string a = "The string where the word the present than once";
             int count = 0;
             string[] words = a.Split(" ");
             for (int i = 0; i < words.Length; i++)
             {
                 if (words[i] == "the")
                 {
                     count++;

                 }
             }
             Console.WriteLine(count);*/
            #endregion
        }
        #region Task-2(method)
        /*  static int arg(int[] Arry)
          {
              int sum = 0;

              for (int i = 0; i < Arry.Length; i++)
              {
                  for (int j = 0; j < Arry.Length; j++)
                  {
                      if (Arry[i] == Arry[j] && i != j)
                      {
                          sum++;
                      }
                  }
              }

              Console.WriteLine(sum);

              return sum;
          }*/
        #endregion

        #region Task-3(method)

        /* static void argss(int[] Arry1, int a)
         {
             for (int i = 0; i < Arry1.Length; i++)
             {

                 if (a == Arry1[i])
                 {
                     Console.WriteLine($"{a}");
                     break;

                 }
             }
         }*/
        #endregion

        #region Task-4(method)
        /*public static void Substring(string a)
        {
            int startIndex = 0;
            int length = 10;
            String substring = a.Substring(startIndex, length);
            Console.WriteLine(substring);
        }*/
        #endregion
    }
}
