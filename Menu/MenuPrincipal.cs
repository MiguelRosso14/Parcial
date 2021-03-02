using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    public class MenuPrincipal : iMenu
    {
        public void ImprimirMenu()
        {
            try
            {

                iMenu menu;
                Console.Clear();
                Console.WriteLine("1-Modo de dispension \n " +
                                  "2-Retiro de dinero \n " +
                                  "3-Salir");
                Console.Write("Eliga que desea hacer:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu = new MenuDeposito();
                        menu.ImprimirMenu();
                        break;
                    case 2:
                        menu = new MenuRetiro();
                        menu.ImprimirMenu();
                        break;
                    case 3:
                        Console.WriteLine("Salida");
                        break;
                    default:
                        Console.WriteLine("Debe elegir una opcion existente");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe elegir una opcion existente");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
