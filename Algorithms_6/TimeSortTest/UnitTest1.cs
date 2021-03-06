using System;
using Xunit;
using QuadraticComplexityAlgorithms;

namespace TimeSortTest
{
    public class UnitTest1
    {
        static Random random = new();

        static int[] array = new int[1000];
        static void Fill(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
        }
        static bool Comparer(int[] array, int[] arraySort)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] != arraySort[i])
                    return false;
            return true;
        }
        static int[] CopySort(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                copy[i] = array[i];
            Array.Sort(copy);
            return copy;
        }

        [Fact]
        public void Stupid()
        {
            Fill(array);
            Sort.Stupid(array);
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Bubble()
        {
            Fill(array);
            Sort.Bubble(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Cocktail()
        {
            Fill(array);
            Sort.Cocktail(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Insertion()
        {
            Fill(array);
            Sort.Insertion(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Gnome()
        {
            Fill(array);
            Sort.Gnome(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void SelectionMinimum()
        {
            Fill(array);
            Sort.SelectionMinimum(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void SelectionMaximum()
        {
            Fill(array);
            Sort.SelectionMaximum(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void DoubleSidedSelection()
        {
            Fill(array);
            Sort.DoubleSidedSelection(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Comb()
        {
            Fill(array);
            Sort.Comb(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
        [Fact]
        public void Shell()
        {
            Fill(array);
            Sort.Shell(array); 
            Assert.Equal(Comparer(array, CopySort(array)), true);
        }
    }
}
