using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        static Register reg = new Register();
        static SortedList neww = new SortedList();
        static void Main(string[] args)
        {
            //AddToList();
            Console.WriteLine("Object oriented under here");
            reg.SetNames(neww);
            AddToListObjectWay();
            Console.ReadKey();
        }
        static public void AddToListObjectWay()
        {         
            IList myKeyList = neww.GetKeyList();
            IList myValueList = neww.GetValueList();
            foreach (var item in neww)
            {
                Console.WriteLine($"{myKeyList} -> {myValueList}");
            }
        }
        static public void AddToList()
        {
            SortedList stlRoot = new SortedList();
            Random rng = new Random();
            int[] rngList = new int[7];
            for (int i = 0; i < rngList.Length; i++)
            {
                rngList[i] = rng.Next(0, 50);
            }            
            stlRoot.Add("Bookfrau", rngList[0]);
            stlRoot.Add("Fraubook", rngList[1]);
            stlRoot.Add("Neinnein", rngList[2]);
            stlRoot.Add("Dragon eh", rngList[3]);
            stlRoot.Add("Oi mateuu", rngList[4]);
            stlRoot.Add("All here", rngList[5]);
            stlRoot.Add("Cyka bly", rngList[6]);            

            IList myKeyList = stlRoot.GetKeyList();
            IList myValueList = stlRoot.GetValueList();

            Console.WriteLine("WORD\t\tPAGE");
            for (int i = 0; i < stlRoot.Count; i++)
            {                
                Console.WriteLine("{0}    -    {1}", myKeyList[i], myValueList[i]);                
            }
        }
    }
}