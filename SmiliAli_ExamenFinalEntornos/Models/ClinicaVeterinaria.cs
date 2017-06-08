using SmiliAli_ExamenFinalED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmiliAli_ExamenFinalEntornos.Models
{
    class ClinicaVeterinaria
    {

        public IList<Animal> listaAnimales;
        private Perro p;


        //CONSRUCTOR PARA INICILIZAR LA LISTA VACÍA
        public ClinicaVeterinaria()
        {
            this.listaAnimales = new List<Animal>();
        }

        //METODOS

        public void InsertaAnimal(Animal a)
        {
            if (listaAnimales.Contains(a)) throw new Exception("El animal que quiere insertar ya existe en la lista !");
            this.listaAnimales.Add(a);

        }

        //MENU

        public void MenuPrincipal()
        {
            int opcion = 0;
            Boolean esCorrecto = true;
            Animal anim;


            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1- Añadir Animal a la Clinica");
                Console.WriteLine("2- Modificar comentario");
                Console.WriteLine("3- Pesar el animal");
                Console.WriteLine("4- Mostrar ficha animal");

                ValidarInt(opcion);

                switch (opcion)
                {
                    case 1:
                        MenuAgregar();
                        break;
                    case 2:
                        Console.WriteLine("Introduzca el nombre del animal que quieras modificar el comentario");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Introduzca el comentario que quiere modificar");
                        string str2 = Console.ReadLine();
                        ModificaComentarioAnimal(str1, str2);
                        break;
                    case 3:
                        Console.WriteLine("Introduzca el peso");
                        string str = Console.ReadLine();
                        double num;
                        bool esCorrecto2 = Double.TryParse(str, out num);
                       // if (esCorrecto2) 



                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Hasta luego!");
                        break;
                        esCorrecto = false;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (esCorrecto);
        }
        public void MenuAgregar()
        {
            int opcion = 0;
            Boolean ok = true;
            do
            {
                Console.WriteLine("Animales:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1-Perro");
                Console.WriteLine("2-Gato");
                Console.WriteLine("3-Reptil");
                Console.WriteLine("4- Volver atras");
                ValidarInt(opcion);
                switch (opcion)
                {
                    case 1:
                        InsertaAnimal((Perro)  p);
                        break;
                    case 2:
                        InsertaAnimal((Gato) g);
                        break;
                    case 3:
                        InsertaAnimal( (Reptil) g);
                   
                    case 4:
                        ok = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }

            } while (ok);
        }

        public Animal BuscaAnimal(string nombre)
        {

            foreach (Animal a in listaAnimales){
                if (!a.Nombre.Equals(nombre))
                {
                    throw new Exception("El nombre introducido no se corresponde a ningún animal de la lista");
                } else
                {
                    return a;
                }
            }

        }



        //ModificaComentarioAnimal

        public string ModificaComentarioAnimal(string nombre, string comentario)
        {
            string str = "";
            foreach (Animal a in listaAnimales){
                if (a.Nombre.Equals(nombre))
                {
                    a.Comentarios(comentario);
                     str +=a.Comentarios;
                }
                else
                {
                    if (comentario == null || comentario.Equals(""){
                        throw new Exception("El comentario introducido no puede ser una cadena vacía");

                    } else {
                        throw new Exception("El nombre introducido no se corresponde a ningún animal de la lista");
                    }
                }

            }

        }

        public  int ValidarInt(int numero)
        {
            
            String cadena = null;
            bool escorrecto = true;
            do
            {
                cadena = Console.ReadLine();
                escorrecto = Int32.TryParse(cadena, out numero);

            } while (!escorrecto);
            return numero;
        }

        //Metodo ToString

        public override string ToString()
        {
            string str = "";
            
            foreach (Animal a in listaAnimales){
                str += a.ToString()+"\n";
                
                Console.WriteLine("");

            }
            return str;

            

        }

       
    }
}
