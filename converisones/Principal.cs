using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converisones
{
    public class Principal
    {
        public void Welcome()
        {
            Console.WriteLine("Bienvenido al programa de conversiones, presione cualquier tecla para proceder al menu");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void Menu()
        {
            Unidad u = new Unidad();
            int opc = 0; double result = 0;
            Console.WriteLine("Seleccione con un numero la conversion que quiere realizar: \n\n1.-Convertir Centimetros a Metros.\n2.-Convertir Metros a Pulgadas.\n3.-Convertir Litros a Mililitros.\n4.-Salir.");
            opc = int.Parse(Console.ReadLine());
            RepoConversiones repo = new RepoConversiones();
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de centimetros a convertir: ");
                    u.Valor = double.Parse(Console.ReadLine());
                    result = repo.Convertir(u.Valor);
                    Console.WriteLine("La cantidad de metros resultantes es: {0} metro(s), presione cualquier tecla para volver al menu",result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad de metros a convertir: ");
                    u.Valor = double.Parse(Console.ReadLine());
                    result = repo.Convertir(u.Valor, 39.3701);
                    Console.WriteLine("La cantidad de pulgadas resultantes es: {0} pulgada(s), presione cualquier tecla para volver al menu",result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.WriteLine("Ingrese la cantidad de Litros a convertir: ");
                    u.Valor = double.Parse(Console.ReadLine());
                    result = repo.Convertir(u.Valor,10,100);
                    Console.WriteLine("La cantidad de Mililitros resultantes es: {0} Mililitro(s), presione cualquier tecla para volver al menu", result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el programa, presione cualquier tecla para salir");
                    Console.ReadKey();
                    System.Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida por favor");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
    }
}
