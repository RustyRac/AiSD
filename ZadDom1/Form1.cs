namespace ZadDom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public int[] SortArray(int[] numbers)
        { 
            var n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (numbers[j] > numbers[j + 1])
                    {
                        var tempVar = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempVar;
                    }

            return numbers;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            
            string[] stringList = userInput.Split(' ');
            int[] numberList = new int[stringList.Count()];
           
            for (int i = 0;  i < stringList.Count(); i++)
            {
                numberList[i] = Int32.Parse(stringList[i]);
             
            }

            if (numberList.Count() > 4)
            {
                int[] bubbleSortedList = SortArray(numberList);
                string sortedString = string.Join(" ", bubbleSortedList);
                label1.Text = sortedString;
            }
            else
            {
                label1.Text = "Guh?";
            }
        }
    }
}
