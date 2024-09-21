using System;

public class HelloWorld
{
    static void pattern1(int N){
        for(int i=0;i<N;i++){
            for ( int j=0;j<N;j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        int N=3;
        pattern1(N);
    }
}
