namespace MethodAndReturnType
{
    public class Program
    {
        public static void Main(String[] args)
        {
            MethodAndReturnType obj = new MethodAndReturnType();
            obj.Method();
            obj.MethodOne(10);
            Console.WriteLine(obj.MethodTwo());
            Console.WriteLine(obj.MethodThree());
            Console.WriteLine(obj.MethodFour());
            Console.ReadKey();
        }
    }
}