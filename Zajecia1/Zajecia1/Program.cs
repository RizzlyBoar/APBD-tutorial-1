public class Program
{
    //metody z Duzej litery!!
    
    public static void Main(string[] args)
    {
    //primitive
         int g = 10;
         int g2 = g;//kopiujemy wartosc
         
    //complex
    string s = "ala";
    string s2 = s;
    int[] arr = { 2, 4, 5, 7 };
    int[] arr2 = arr;
    arr2[0] = 222;
    int? age = null;
    //Nullable<int> age = null;
    //Integer age.. <- java

    Console.WriteLine("Hello, World!");
    Console.WriteLine("Zajecia1;");
    }

    public static void DoSth(){}
}