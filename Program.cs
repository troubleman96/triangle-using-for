using System;

class Program{

    static void Main(string [] args){

       int heightOfTriangle = 5;

       for(int i = 1; i <= heightOfTriangle; i++){

            for(int j = 1; j <= i; j++){
                System.Console.Write("*");
            }
            System.Console.WriteLine();
       }

    }
}