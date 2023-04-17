using System.Globalization;

namespace PTIAlgoritimos
{

    class Program
    { 

        static void Main(string[] args)
        {
            bool calcIsRun = true;

            do
            {
                Console.Write("Digite o valor da Gasolina: ");
                double gasoline = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o valor do Etanol: ");
                double ethanol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var calcFuel = ethanol / gasoline;

                var calcFuelFormatted = calcFuel.ToString(CultureInfo.InvariantCulture);

                if (calcFuel > 0.7)
                {
                    Console.WriteLine($"Vale mais apena Abastecer com Gasolina {calcFuel}");
                }

                else if (calcFuel < 0.7)
                {
                    Console.WriteLine($"Vale mais apena Abastecer com Etanol {calcFuel}");
                }

                else
                {
                    Console.WriteLine($"Qualquer dos dois combustiveis vale apena {calcFuel}");
                }

                Console.WriteLine("Aperte <Enter> para Continuar ou <Esc> para sair");
                var continueCalc = Console.ReadKey();

                if (continueCalc.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Pronto para realizar outro calculo");
                }

                else
                {
                    calcIsRun = false;
                }
            }
            while (calcIsRun);
        }
    }
}