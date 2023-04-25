using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischerKonstruktorTest {
    public static class Demo {
        private static int zahl_1;

        public static void setZahl_1(int z) {
            zahl_1 = z;
        }

        public static void printZahl_1() {
            Console.WriteLine(zahl_1);
        }

        // Konstruktor
        static Demo() {
            Console.WriteLine("Hallo vom Konstruktor");
            zahl_1 = 999;
            printZahl_1();
            Console.WriteLine("Ende des Konstruktors");
        }
    }
}
