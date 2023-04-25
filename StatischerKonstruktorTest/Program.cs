namespace StatischerKonstruktorTest {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Konstruktor!");

            Demo.setZahl_1(1);
            Demo.printZahl_1();

            Console.ReadLine();
        }
    }
}