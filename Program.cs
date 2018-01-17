﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace cyclesort
{
    class Program
    {
        //data structures
        static void Main(string[] args)
        {
            //cycle soting algorithm c# 
            Console.WriteLine("***********CYCLE_SORT***********");
            cyclesortwithFiling a = new cyclesortwithFiling();
            int Len = a.getlength();
            Console.WriteLine(" Length of List:   " + Len);
            Console.WriteLine("\n\n Before cycle sorting Sorting: ");
            int[] arr = a.Reader(Len);
            cyclesort csa = new cyclesort();
            //DISPLAYING INDEX AFTER
            Console.WriteLine("\n\n After Cycle Sort: ");
            arr = csa.sortiing(arr);
            for (int Q = 0; Q < Len; Q++)
            {//DISPLAYING INDEX BEFORE
                Console.WriteLine(" -INDEX [0]- :    {1}", Q, arr[Q]);
            }
            Console.WriteLine("********END**********");
            Console.WriteLine("\nGroup Members:");
            Console.WriteLine("UZAIR KHAN 16B-006-SE");
            Console.WriteLine("ZUNAIRA TEHSEEN 16B-028-SE");
            Console.WriteLine("ZAINAB ZUBAIR 16B-067-SE");
            a.Writer(arr);
            Console.ReadLine();
        }
    }
    class cyclesortwithFiling
    {
        string mydocpath = "C:\\Users\\uzair\\Desktop\\cycle sorting.txt";
        public int getlength()
        {
            int count = 0;
            try
            {
                using (StreamReader s = new StreamReader(mydocpath))
                {
                    string Line;
                    while ((Line = s.ReadLine()) != null)
                    {
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Warning");
                Console.WriteLine(e.Message);
            }
            return count;
        }
        public void Writer(int[] Array)
        {
            using (StreamWriter sw = new StreamWriter(mydocpath))
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    sw.WriteLine(Array[i]);
                }
            }
        }
        
        public int[] Reader(int Len)
        {
            int[] Arr = new int[Len];
            try
            {
                using (StreamReader SR = new StreamReader(mydocpath))
                {
                    for (int i = 0; i < Len; i++)
                    {
                        Arr[i] = Convert.ToInt16(SR.ReadLine());
                        Console.WriteLine(" -INDEX [0]- :    {1}", i, Arr[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" NO ELEMENTS ARE FOUND SORYY!!");
                Console.WriteLine(e.Message);
            }
            return Arr;
        }
    }
    class cyclesort
    {
        public int[] sortiing(int[] array)
        {
            int temp;
            //int s;
            int poos;
            int im;
            
            for (int cycleStart = 0; cycleStart < array.Length; cycleStart++)
                //LOOPS AND CONDITIONS
            {
                im = array[cycleStart];
                poos = cycleStart;
                for (int i = cycleStart + 1; i < array.Length; i++)
                {
                    if (array[i] < im)
                        poos++;
                }
                if (poos == cycleStart)
                    continue;
                while (im == array[poos])
                    poos++;
                if (im != array[poos])
                {//values swapping
                    temp = array[poos];
                    array[poos] = im;
                    im = temp;
                }//conditions
                while (poos != cycleStart)
                {
                    poos = cycleStart;
                    for (int i = cycleStart + 1; i < array.Length; i++)
                    {
                        if (array[i] < im)
                            poos++;
                    }
                    /*while (im == array[poos])
                        poos++;
                    if (?!= array[poos])
                    {
                        temp = array[poos];
                        aim;
                        im = temp;
                    }*/
                    while (im == array[poos])
                        poos++;
                    if (im != array[poos])
                    {
                        temp = array[poos];
                        array[poos] = im;
                        im = temp;
                    }
                }
            }
            return array;
        }
    }
    
}