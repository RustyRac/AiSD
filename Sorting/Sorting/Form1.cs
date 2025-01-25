using System.CodeDom.Compiler;
using System.Collections.Concurrent;

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        public int[] generuj()
        {
            int count = (int) numericUpDown1.Value;
            int[] tablica = new int[count];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rnd.Next(0, 100);
            }
            return tablica;
        }

        public string tabToString(int[] array)
        {
            string str = "[ ";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i].ToString();
                str += " ";
            }
            str += "]";
            return str;
        }

        //Bubble
        public void bubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
        //Counting

        public int getMaxValue(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        public void countingSort(int[] array)
        {
            int max = getMaxValue(array);
            int[] count = new int[max + 1];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }
            for (int i = 0, j = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    array[j] = i;
                    j++;
                    count[i]--;
                }
            }

        }

        //Insertion Sort

        public void insertionSort(int[] array)
        {
            int i = 1;
            while (i < array.Length)
            {
                int temp = array[i];
                int j = i;
                while (j > 0 && temp < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[j] = temp;
                i++;
            }
        }
        //Merge

        public void mergeSort(int[] array)
        {
            int length = array.Length;
            if (length <= 1)
                return;

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }

            mergeSort(leftArray);
            mergeSort(rightArray);
            merge(array, leftArray, rightArray);

        }

        public void merge(int[] array, int[] leftArray, int[] rightArray)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int i = 0; int l = 0; int r = 0;
            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }

        }
        //Quick

        public void quickSort(int[] array, int start, int end)
        {
            if (end <= start) return;

            int pivot = partition(array, start, end);
            quickSort(array, start, pivot - 1);
            quickSort(array, pivot + 1, end);
        }

        public int partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start -1;
            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp1 = array[i];
                    array[i] = array[j];
                    array[j] = temp1;
                }
            }
            i++;
            int temp = array[i];
            array[i] = array[end];
            array[end] = temp;
            return i;

        }






        private void button1_Click(object sender, EventArgs e)
        {
            var tablica = generuj();
            label2.Text = tabToString(tablica);
            bubbleSort(tablica);
            label4.Text = tabToString(tablica);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tablica = generuj();
            label2.Text = tabToString(tablica);
            countingSort(tablica);
            label4.Text = tabToString(tablica);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tablica = generuj();
            label2.Text = tabToString(tablica);
            insertionSort(tablica);
            label4.Text = tabToString(tablica);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tablica = generuj();
            label2.Text = tabToString(tablica);
            mergeSort(tablica);
            label4.Text = tabToString(tablica);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var tablica = generuj();
            label2.Text = tabToString(tablica);
            quickSort(tablica, 0, tablica.Length - 1);
            label4.Text = tabToString(tablica);
        }
    }
}
