namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando...");
        }
    }
}