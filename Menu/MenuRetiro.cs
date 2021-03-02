using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    public class MenuRetiro : iMenu
    {
        public void ImprimirMenu()
        {
            MenuPrincipal menu = new MenuPrincipal();
            try
            {
                int Pesos;

                if (Repositorio.Instancia.depositos.Count <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Modo de retiro eficiente (Papeletas de 100, 200, 500 y 1000");
                    Console.WriteLine("Cuanto desea sacar?: ");
                    Pesos = int.Parse(Console.ReadLine());
                    if (Pesos >= 100 && Pesos <= 1000)
                    {
                        int CPesos = Pesos / 100;
                        if (CPesos == 1 ||CPesos == 2 || CPesos == 3 || CPesos == 4 || CPesos == 5 || CPesos == 6 || CPesos == 7 || CPesos == 8)
                        {
                            Console.WriteLine("Salieron: " + CPesos + "papeletas de 100");

                        }
                        else
                        {
                            Console.WriteLine("Solo se pueden usar numeros enteros");
                            Console.ReadKey();
                            Console.WriteLine("Desea sacar mas papeletas? S(si)" +
                                                                        "\nN(no)");
                            string reintentar = Console.ReadLine();

                            if (reintentar == "S")
                            {
                                ImprimirMenu();

                            }
                            else if (reintentar == "N")
                            {
                                menu.ImprimirMenu();
                                Console.ReadKey();
                                ImprimirMenu();
                            }
                            else
                            {
                                Console.WriteLine("Debe seleccionar S o N");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (Pesos >= 100)
                    {
                        string Cantida = Convert.ToString(Pesos / 100);
                        string[] diviso= Cantida.Split('-');
                        if (diviso.Length == 1)
                        {
                            int cien = Convert.ToInt32(diviso[0]);
                            Console.WriteLine("Salieron: " + cien + " billetes de 100");
                            Console.ReadKey();
                        }
                        else if (Pesos >= 200)
                    {
                        string Cantidad = Convert.ToString(Pesos / 200);
                        string[] divisor = Cantidad.Split('-');
                            if (divisor.Length == 1)
                            {
                                int doscientos = Convert.ToInt32(divisor[1]);
                                Console.WriteLine("Salieron: " + doscientos + " billetes de 200");
                                Console.ReadKey();
                            }
                            else if (Pesos >= 500)
                            {
                                string Cantidades = Convert.ToString(Pesos / 500);
                                string[] divisores = Cantidades.Split('-');
                                if (divisores.Length == 1)
                                {
                                    int quiniento = Convert.ToInt32(divisores[2]);
                                    Console.WriteLine("Salieron: " + quiniento + " billetes de 500");
                                    Console.ReadKey();
                                }
                                else if (Pesos >= 1000)
                                {
                                    string Cantidade = Convert.ToString(Pesos / 1000);
                                    string[] divisore = Cantidade.Split('-');
                                    if (divisore.Length == 1)
                                    {
                                        int mil = Convert.ToInt32(divisore[3]);
                                        Console.WriteLine("Salieron: " + mil + " billetes de 1000");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        if (diviso[0] == "2" || divisor[1] == "4" || divisores[2] == "6" || divisore[3] == "8")
                                        {
                                            int cien = Convert.ToInt32(diviso[0]) / 1;
                                            int doscientos = Convert.ToInt32(divisor[1]) / 2;
                                            int quiniento = Convert.ToInt32(divisores[2]) / 5;
                                            int mil = Convert.ToInt32(divisore[3]) / 1000;

                                            Console.WriteLine("Han sido dispensados la cantidad de: " + cien + " papeletas de 100 " + doscientos + " papeletas de 200" + quiniento + "papeletas de 500" + mil + "papeletas de 1000");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Write("El cajero no tiene ese tipo de papeletas");
                                            Console.ReadKey();


                                            {
                                                Console.WriteLine("Desea volver a intentarlo?\n1 - Si\n2 - No");
                                                string continuar = Console.ReadLine();

                                                if (continuar == "1")
                                                {
                                                    ImprimirMenu();

                                                }
                                                else if (continuar == "2")
                                                {
                                                    menu.ImprimirMenu();
                                                    Console.ReadKey();
                                                    ImprimirMenu();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe seleccionar 1 o 2");
                                                    Console.ReadKey();
                                                }
                                            }
                                            menu.ImprimirMenu();
                                            Console.ReadKey();
                                            ImprimirMenu();
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                if (Repositorio.Instancia.depositos.Count <= 1)
                {
                    Console.WriteLine("Modo de retiro  (papeletas de 200 y 1000)");
                    Console.WriteLine("Cuanto desea sacar?: ");
                    int Peso = int.Parse(Console.ReadLine());
                    if (Peso >= 200 && Peso <= 900)
                    {
                        int CPeso = Peso / 200;
                        if (CPeso == 1 || CPeso == 2 || CPeso == 3 || CPeso == 4)
                        {
                            Console.WriteLine("Salieron: " + CPeso + "papeletas de 200");
                        }
                        else
                        {
                            Console.WriteLine("Solo se pueden usar numeros enteros");
                            Console.ReadKey();
                            Console.WriteLine("Desea sacar mas papeletas? S(si)" +
                                "\nN(no)");
                            string reintentar = Console.ReadLine();

                            if (reintentar == "S")
                            {
                                ImprimirMenu();

                            }
                            else if (reintentar == "N")
                            {
                                menu.ImprimirMenu();
                                Console.ReadKey();
                                ImprimirMenu();
                            }
                            else
                            {
                                Console.WriteLine("Debe seleccionar S o N");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (Peso >= 1000)
                    {
                        string Cantid = Convert.ToString(Peso / 1000);
                        string[] divis = Cantid.Split('-');
                        if (divis.Length == 1)
                        {
                            int mil = Convert.ToInt32(divis[0]);
                            Console.WriteLine("Salieron: " + mil + " billetes de 1000");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (divis[1] == "2" || divis[1] == "4" || divis[1] == "6" || divis[1] == "8")
                            {
                                int mil = Convert.ToInt32(divis[0]);
                                int doscientos = Convert.ToInt32(divis[1]) / 2;
                                Console.WriteLine("Salieron: " + mil + " papeleta de 1000 y " + doscientos + " papeleta de 200");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("El cajero no tiene ese tipo de papeletas");
                                Console.ReadKey();


                                {
                                    Console.WriteLine("Desea volver a intentarlo?\nS(si)" +
                                                                                "\nN(no)");
                                    string continuar = Console.ReadLine();

                                    if (continuar == "S")
                                    {
                                        ImprimirMenu();

                                    }
                                    else if (continuar == "N")
                                    {
                                        menu.ImprimirMenu();
                                        Console.ReadKey();
                                        ImprimirMenu();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Debe seleccionar S o N");
                                        Console.ReadKey();
                                    }
                                }

                            }
                        }

                    }
                }
                if (Repositorio.Instancia.depositos.Count <= 2)
                {
                    Console.WriteLine("Modo de retiro  (papeletas de 100 y 500)");
                    Console.WriteLine("Cuanto desea sacar?: ");
                    int Peso = int.Parse(Console.ReadLine());
                    if (Peso >= 100 && Peso <= 500)
                    {
                        int CPeso = Peso / 100;
                        if (CPeso == 1 || CPeso == 2 || CPeso == 3 || CPeso == 4)
                        {
                            Console.WriteLine("Salieron: " + CPeso + "papeletas de 100");
                        }
                        else
                        {
                            Console.WriteLine("Solo se pueden usar numeros enteros");
                            Console.ReadKey();
                            Console.WriteLine("Desea sacar mas papeletas? S(si)" +
                                                                        "\nN(no)");
                            string reintentar = Console.ReadLine();

                            if (reintentar == "S")
                            {
                                ImprimirMenu();

                            }
                            else if (reintentar == "N")
                            {
                                menu.ImprimirMenu();
                                Console.ReadKey();
                                ImprimirMenu();
                            }
                            else
                            {
                                Console.WriteLine("Debe seleccionar S o N");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (Peso >= 500)
                    {
                        string Cantid = Convert.ToString(Peso / 500);
                        string[] divis = Cantid.Split('-');
                        if (divis.Length == 1)
                        {
                            int quiniento = Convert.ToInt32(divis[0]);
                            Console.WriteLine("Salieron: " + quiniento + " billetes de 1000");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (divis[1] == "2" || divis[1] == "4" || divis[1] == "6" || divis[1] == "8")
                            {
                                int quiniento = Convert.ToInt32(divis[0]);
                                int cien = Convert.ToInt32(divis[1]) / 2;
                                Console.WriteLine("Salieron: " + quiniento + " papeleta de 500 y " + cien + " papeleta de 100");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("El cajero no tiene ese tipo de papeletas");
                                Console.ReadKey();

                                {
                                    Console.WriteLine("Desea volver a intentarlo?\nS(si)" +
                                                                                "\nN(no)");
                                    string continuar = Console.ReadLine();

                                    if (continuar == "S")
                                    {
                                        ImprimirMenu();

                                    }
                                    else if (continuar == "N")
                                    {
                                        menu.ImprimirMenu();
                                        Console.ReadKey();
                                        ImprimirMenu();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Debe seleccionar S o N");
                                        Console.ReadKey();
                                    }
                                }

                            }
                        }

                    }
                }
                if (Repositorio.Instancia.depositos.Count <= 3)
                {
                    Console.WriteLine("Modo de retiro eficiente (Papeletas de 100, 200, 500 y 1000");
                    Console.WriteLine("Cuanto desea sacar?: ");
                    Pesos = int.Parse(Console.ReadLine());
                    if (Pesos >= 100 && Pesos <= 1000)
                    {
                        int CPesos = Pesos / 100;
                        if (CPesos == 1 || CPesos == 2 || CPesos == 3 || CPesos == 4 || CPesos == 5 || CPesos == 6 || CPesos == 7 || CPesos == 8)
                        {
                            Console.WriteLine("Salieron: " + CPesos + "papeletas de 100");
                        }
                        else
                        {
                            Console.WriteLine("Solo se pueden usar numeros enteros");
                            Console.ReadKey();
                            Console.WriteLine("Desea sacar mas papeletas? S(si)" +
                                                                        "\nN(no)");
                            string reintentar = Console.ReadLine();

                            if (reintentar == "S")
                            {
                                ImprimirMenu();

                            }
                            else if (reintentar == "N")
                            {
                                menu.ImprimirMenu();
                                Console.ReadKey();
                                ImprimirMenu();
                            }
                            else
                            {
                                Console.WriteLine("Debe seleccionar S o N");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (Pesos >= 100)
                    {
                        string Cantida = Convert.ToString(Pesos / 100);
                        string[] diviso = Cantida.Split('-');
                        if (diviso.Length == 1)
                        {
                            int doscientos = Convert.ToInt32(diviso[0]);
                            Console.WriteLine("Salieron: " + doscientos + " billetes de 200");
                            Console.ReadKey();
                        }
                        else if (Pesos >= 200)
                        {
                            string Cantidad = Convert.ToString(Pesos / 200);
                            string[] divisor = Cantidad.Split('-');
                            if (divisor.Length == 1)
                            {
                                int doscientos = Convert.ToInt32(divisor[1]);
                                Console.WriteLine("Salieron: " + doscientos + " billetes de 200");
                                Console.ReadKey();
                            }
                            else if (Pesos >= 500)
                            {
                                string Cantidades = Convert.ToString(Pesos / 500);
                                string[] divisores = Cantidades.Split('-');
                                if (divisores.Length == 1)
                                {
                                    int quiniento = Convert.ToInt32(divisores[2]);
                                    Console.WriteLine("Salieron: " + quiniento + " billetes de 500");
                                    Console.ReadKey();
                                }
                                else if (Pesos >= 1000)
                                {
                                    string Cantidade = Convert.ToString(Pesos / 1000);
                                    string[] divisore = Cantidade.Split('-');
                                    if (divisore.Length == 1)
                                    {
                                        int mil = Convert.ToInt32(divisore[3]);
                                        Console.WriteLine("Salieron: " + mil + " billetes de 1000");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        if (diviso[0] == "2" || divisor[1] == "4" || divisores[2] == "6" || divisore[3] == "8")
                                        {
                                            int cien = Convert.ToInt32(diviso[0]) / 1;
                                            int doscientos = Convert.ToInt32(divisor[1]) / 2;
                                            int quiniento = Convert.ToInt32(divisores[2]) / 5;
                                            int mil = Convert.ToInt32(divisore[3]) / 1000;

                                            Console.WriteLine("Han sido dispensados la cantidad de: " + cien + " papeletas de 100 " + doscientos + " papeletas de 200" + quiniento + "papeletas de 500" + mil + "papeletas de 1000");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Write("El cajero no tiene ese tipo de papeletas");
                                            Console.ReadKey();


                                            {
                                                Console.WriteLine("Desea volver a intentarlo?\n1 - Si\n2 - No");
                                                string continuar = Console.ReadLine();

                                                if (continuar == "1")
                                                {
                                                    ImprimirMenu();

                                                }
                                                else if (continuar == "2")
                                                {
                                                    menu.ImprimirMenu();
                                                    Console.ReadKey();
                                                    ImprimirMenu();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe seleccionar 1 o 2");
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("El valor es invalido");
                Console.ReadKey();
            }
        }
    }
}