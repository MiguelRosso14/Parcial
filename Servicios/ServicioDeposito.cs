using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    class ServicioDeposito
    {
        MenuPrincipal menu = new MenuPrincipal();
        public void ImprimirMenu()
        {

        }
        public void opcion1()
        {
            Console.WriteLine("Dispensara solo papeletas de 200 y 1000 \nVuelva atras presionando 4");
            int eleccion = int.Parse(Console.ReadLine());
            Dispensor dispension = new Dispensor(eleccion);
            Repositorio.Instancia.depositos.Add(dispension);
            Console.WriteLine("se agrego con exito");
            menu.ImprimirMenu();
            Console.ReadKey();
            ImprimirMenu();
        }
        public void opcion2()
        {
            Console.WriteLine("Dispensara solo papeletas de 100 y 500\nVuelva atras presionando 4");
            int eleccion = int.Parse(Console.ReadLine());
            Dispensor dispension = new Dispensor(eleccion);
            Repositorio.Instancia.depositos.Add(dispension);
            Repositorio.Instancia.depositos.Add(dispension);
            Console.WriteLine("se agrego con exito");
            menu.ImprimirMenu();
            Console.ReadKey();
        }
        public void opcion3()
        {
            Console.WriteLine("Dispensara solo papeletas de 100,200,500 y 1000\nVuelva atras presionando 4");
            int eleccion = int.Parse(Console.ReadLine());
            Dispensor dispension = new Dispensor(eleccion);
            Repositorio.Instancia.depositos.Add(dispension);
            Repositorio.Instancia.depositos.Add(dispension);
            Repositorio.Instancia.depositos.Add(dispension);
            Console.WriteLine("se agrego con exito");

            menu.ImprimirMenu();
            Console.ReadKey();
        }
    }
}
