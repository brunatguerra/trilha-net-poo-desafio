using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        {
            Smartphone nokia = new Nokia("123456", "4242", "1234", 20);
            nokia.InstalarAplicativo("WhatsApp");

            // Teste com a classe Iphone
            Smartphone iphone = new Iphone("654321", "4343", "4321", 25);
            iphone.InstalarAplicativo("Instagram");

        }
    }
}