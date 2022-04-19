using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73DersInterfaces // Interfacesler cokca kullanilir. Abstractlarin gelistirilmis halidir. Yani arayuz cizimleri icin kullanilir.
                            // Baska siniflardan miras alinir ve miras alindiktan sonra ilgili metotlar turev siniflarda override edilmeye zorlanir...
{
    class Program
    {
        public interface ISekil
        {
            void SekilCiz();
        }

        class Dikdortgen : ISekil
        {
            public void SekilCiz()
            {
                Console.WriteLine("Dikdortgen ciziliyor...");
            }
        }
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.SekilCiz();
        }
    }
}
