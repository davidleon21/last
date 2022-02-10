using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appconsolasproyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            char matt;
            String cp1;
            int cp2;

            Console.WriteLine("---------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("---------------");
            do
            {
                Console.WriteLine("escribe tu usuario o correo: ");
                cp1 = Console.ReadLine();
                Console.WriteLine("escribe tu contraseña: ");
                int.TryParse(Console.ReadLine(), out cp2);
                if ((cp1 == "admin") && (cp2 == 1234))
                {
                    Console.WriteLine("inicio su login");
                    Console.Clear();
                    /*Console.ReadLine();*/
                    Console.WriteLine("funciones matematicas");
                    Console.WriteLine("1- suma");
                    Console.WriteLine("2- resta ");
                    Console.WriteLine("3- divicion");
                    Console.WriteLine("4- multiplicacion");
                    char.TryParse(Console.ReadLine(), out matt);



                    switch (matt)
                    {


                        case '1':
                            {
                                Console.Clear();
                                int n1, n2, total;
                                Console.WriteLine("suma");
                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n1);

                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n2);

                                total = n1 + n2;

                                Console.WriteLine("el total es de: " + total);
                                Console.ReadLine();
                            }
                            break;

                        case '2':
                            {
                                Console.Clear();
                                int n1, n2, total;
                                Console.WriteLine("resta");
                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n1);

                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n2);

                                total = n1 - n2;

                                Console.WriteLine("el total es de: " + total);
                                Console.ReadLine();

                            }
                            break;

                        case '3':
                            {
                                Console.Clear();
                                int n1, n2, total;
                                Console.WriteLine("divicion");
                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n1);

                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n2);

                                total = n1 / n2;

                                Console.WriteLine("el total es de: " + total);
                                Console.ReadLine();
                            }
                            break;

                        case '4':
                            {
                                Console.Clear();
                                int n1, n2, total;
                                Console.WriteLine("multiplicacion");
                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n1);

                                Console.WriteLine("digite un numero: ");
                                int.TryParse(Console.ReadLine(), out n2);

                                total = n1 * n2;

                                Console.WriteLine("el total es de: " + total);
                                Console.ReadLine();
                            }
                            break;

                    }
                }


                else
                {
                    Console.WriteLine("no puede acceder");
                    Console.ReadLine();
                }
            } while (cp2 != 1234);

        }
    }
}
