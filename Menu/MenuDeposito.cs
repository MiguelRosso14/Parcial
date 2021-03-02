using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    class MenuDeposito : iMenu
    {
        private ServicioDeposito depositos { get; set; }


        public MenuDeposito()
        {
            depositos = new ServicioDeposito();
        }
        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();
                Console.Clear();
                Console.WriteLine("1-Papeletas de 200 y 1000" +
                                  "\n2-Papeletas de 100 y 500" +
                                  "\n3-Papeletas de 100,200,500 y 1000" +
                                  "\n4-Volver atras");
                Console.WriteLine("Eliga una de las opciones:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        depositos.opcion1();
                        ImprimirMenu();
                        break;
                    case 2:
                        depositos.opcion2();
                        ImprimirMenu();
                        break;
                    case 3:
                        depositos.opcion3();
                        ImprimirMenu();
                        break;
                    case 4:
                        menu.ImprimirMenu();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    default:
                        Console.WriteLine("Debe elegir una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe elegir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
