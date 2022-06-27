
1)copy an Arrazy
using System;
namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int [] n = new int[10]; /* n is an array of 10 integers */
         int [] m = new int[5]; /* m is an array of 5 integers */
         for ( int i = 0; i < 10; i++ ) {
            n[i] = i + 1000;
         }
         Console.WriteLine("Original Array...");
         foreach (int j in n ) {
            int i = j-1000;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Array.Copy(n, 0, m, 0, 5);
         Console.WriteLine("New Array...");
         foreach (int res in m) {
            Console.WriteLine(res);
         }
         Console.ReadKey();
      }
   }
}

2)Sort of an Array

using System;
namespace Demo {
   class Program {
      static void Main(string[] args) {
         int[] list = { 22, 12, 65, 9};
         Console.Write("Original Array: ");
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         //sort the array
         Array.Sort(list);
         Console.Write("Sorted Array: ");
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}

3)Clear of An Array

using System;
class Program {
   static void Main() {
      int[] arr = new int[] {11, 40, 20};
      Console.WriteLine("Array (Old):");
      foreach (int val in arr) {
         Console.WriteLine(val);
      }
      Array.Clear(arr, 0, arr.Length);
      Console.WriteLine("Array (After using Clear):");
      foreach (int val in arr) {
         Console.WriteLine(val);
      }
   }
}

4)Reverse of an array

using System;
namespace Demo {
   class MyArray {
      static void Main(string[] args) {
         int[] list = { 29, 15, 30, 98};
         int[] temp = list;
         Console.Write("Original Array: ");
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         // reverse the array
         Array.Reverse(temp);
         Console.Write("Reversed Array: ");
         foreach (int i in temp) {
            Console.Write(i + " ");
         }
         Console.ReadKey();
      }
   }
}