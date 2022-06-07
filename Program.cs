using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace unCommonNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2031\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2031\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            string a;
            string secondLine;
            using (var readera = new StreamReader(inputpath))
            {
                a = readera.ReadLine();
                secondLine = readera.ReadLine();

            };
            string[] lineForInt = secondLine.Split(' ');


            int[] A;
            A = new int[Convert.ToInt32(a)];


            int count = 0;
            foreach(var s in lineForInt)
            {
                A[count++] = Convert.ToInt32(s);
            }
            #endregion
            count = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    
                    if (A[i] == A[j] )
                    {
                        count++;
                        if (list.Contains(A[i]))
                        {
                            count = 0;
                        }
                        else if(count>1 & i!=j)
                        {
                            list.Add(A[i]);
                            count = 0;
                        }
                    }
                }
            }

            string outputstring = "";
            for(int i=0;i<list.Count;i++)
            {
                outputstring = outputstring + list[i] + ' ';
            }

            using (var writer = new StreamWriter(outputpath))
            {
                writer.WriteLine(list.Count);
                writer.Write(outputstring);
            }

        }
    }
}
