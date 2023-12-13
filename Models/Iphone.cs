namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(){}

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Page R$ 10,00 para instalar... rs");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor == 10)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
            }
        }
    }
}