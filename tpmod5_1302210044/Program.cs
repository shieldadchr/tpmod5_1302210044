// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T inputuser)
        {
            Console.WriteLine("Hallo user " + inputuser);
        }
    }
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Shielda");
        DataGeneric<string> nim = new DataGeneric<string>("1302210044");
        nim.PrintData();
    }
}