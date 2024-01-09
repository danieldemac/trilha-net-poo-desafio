using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos um Nokia
            Smartphone nokia = new Nokia("1234567890");

            // Instalamos um aplicativo no Nokia
            nokia.InstalarAplicativo("WhatsApp");

            // Instanciamos um Iphone
            Smartphone iphone = new Iphone("9876543210");

            // Instalamos um aplicativo no Iphone
            iphone.InstalarAplicativo("Instagram");
        }
    }
}