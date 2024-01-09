namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no Iphone...");
            Console.WriteLine("Nome do aplicativo: {0}", nomeApp);
        }
    }
}