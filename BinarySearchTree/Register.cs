using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Register 
    {
        public Keyword Key { get; set; }
        public SortedList MySortedList { get; set; }     
        public void SetNames(SortedList sort)            
        {
            sort.Add("hello", new SortedSet<int>() { 2, 3, 5, 8 });
            sort.Add("ualsa", new SortedSet<int>() { 1, 50, 115, 612 });
            sort.Add("bliea", new SortedSet<int>() { 41, 212, 356, 709 });
            sort.Add("asdde", new SortedSet<int>() { 409, 800 });
            sort.Add("lkoie", new SortedSet<int>() { 2, 1002 });
            sort.Add("popiu", new SortedSet<int>() { 4000 });
            sort.Add("nneje", new SortedSet<int>() { 2 });
        }
    }
    class Keyword
    {
        public string Name { get; set; }
    }
}
