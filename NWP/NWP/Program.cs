// See https://aka.ms/new-console-template for more information

class Program
{
    public static void MatrixPrinter(int[,] array)
    {
        int rows = array.GetLength(0);  
        int cols = array.GetLength(1);  

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");  
            }
            Console.WriteLine();
        }
    }
    public static string NWP(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        
        int[,] matrix = new int[len1 + 1, len2 + 1];

       
        for (int i = 1; i <= len1; i++)
        {
            for (int j = 1; j <= len2; j++)
            {
                if (str1[i - 1] == str2[j - 1]) 
                {
                    matrix[i, j] = matrix[i - 1, j - 1] + 1;
                }
                else  
                {
                    matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                }
            }
        }

        MatrixPrinter(matrix);

        int lcsLength = matrix[len1, len2];
        char[] lcs = new char[lcsLength];
        int x = len1, y = len2;
        while (x > 0 && y > 0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                lcs[lcsLength - 1] = str1[x - 1];
                x--;
                y--;
                lcsLength--;
            }
            else if (matrix[x - 1, y] >= matrix[x, y - 1])
            {
                x--;
            }
            else
            {
                y--;
            }
        }

        return new string(lcs);
    }

    static void Main()
    {

        string str1 = "ABAB";
        Console.WriteLine(str1);

        string str2 = "ABGBAGB";
        Console.WriteLine(str2);



        string nwp = NWP(str1, str2);
        Console.WriteLine("NWP:  " + nwp);
    }
}
