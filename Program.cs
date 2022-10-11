//docs: https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation
using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        int rows = 0, column = 0;
        int buffer = 0 ;
        int [,] matrix = null;
        StreamWriter text = null;
        
        
       
            Console.Clear();
            Console.WriteLine("¡¡¡¡BIENVENIDO AL PROGRAMA DEL GRUPO # 2!!!!");
            Console.WriteLine("Dime....!");
            Console.WriteLine("¿Cúantos pares de números te gustaria sumar?");
            rows = Convert.ToInt32(Console.ReadLine());
            column = 3;
            matrix = new int [rows,column];
            Console.Clear();
            Console.WriteLine("Excelente......¡Ahora podrias ayudarme a llenar nuestra Matriz!");
             for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
               Console.WriteLine("Ingrese un numero para la posición " + i + "," + j);
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Clear();
        Console.WriteLine("Ufffffff....Terminamos, ahora a sumar!");

        for (int i = 0; i < rows; i++) 
        {
            buffer = 0;
            for (int j = 0; j < 2; j++) 
            {
                
               buffer = buffer + matrix[i,j];
               matrix[i,2] = buffer;
                
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Parece que tengo los resultados, revisa el archivo que he creado para ti..........!");
        Console.WriteLine("");
        text = new StreamWriter("./Tarea.txt");
        text.Write("¡EXCELENTE NUESTRA MATRIZ ES LA SIGUIENTE..................!");
        text.WriteLine("");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                text.Write(matrix[i,j]);
                if (j==1)
            {
                text.Write(" = ");
            }else if (j==2)
            {
                text.Write("");
            }else

            {
                text.Write(" + ");
            }

            }
            text.WriteLine("");
        }
        text.Close();
    }         
}
