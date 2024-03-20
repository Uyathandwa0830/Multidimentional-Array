using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] studentInformation =
        {
            {"Student 1\n","Name : Uyathandwa Nkosi\n ", "Gender : M \n", "DOB : 08.30.2000\n"},
            {"Student 2\n","Name : Nolwethu Masilela\n","Gender : M\n" , "DOB : 02.06.2001\n"},
            {"Student 3\n","Name : Nomcebo Mndawe\n","Gender : F\n" , "DOB : 04.04.2003\n"},
        };
        //Display the array
        Console.WriteLine("Student Information");
        for (int row = 0; row < studentInformation.GetLength(0); row++)
        {
            for (int col = 0; col < studentInformation.GetLength(1); col++)
            {
                Console.Write(studentInformation[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}

