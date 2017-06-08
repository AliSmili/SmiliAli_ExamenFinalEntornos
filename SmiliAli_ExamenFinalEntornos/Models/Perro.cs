using SmiliAli_ExamenFinalED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmiliAli_ExamenFinalEntornos.Models
{
    class Perro : Animal
    {
        private string _raza;
        private string _microchip;

        //CONSTRUCTOR

        public Perro(string nombre, string fechaNacimiento, double peso, string raza, string microchip): base(nombre, fechaNacimiento, peso){
            this.Raza = raza;
            this.Microchip = microchip;
        }

        //PROPIEDADES

            public string Raza
        {
            get
            {
                return _raza;
            }
            set
            {
                if (value == null) throw new Exception("Este campo no puede quedar vacío");
                _raza = value;
            }
        }

        public String Microchip
        {
            get
            {
                return _microchip;
            }
            set
            {
                if (value == null) throw new Exception("Este campo no puede quedar vacío");
                _microchip = value;
            }


        }


        //METODOS
        public override void Pesar(double peso)
        {
            Console.WriteLine("El perro se ha pesado");
        }

        //METODO ToString()

        new string ToString()
        {
            var str = "";

            str = "Ficha de Perro\n";
            str += "Nombre : " + Nombre+"\n";
            str += "Raza : " + Raza + "\n";
            str += "Fecha de Nacimiento : " + FechaNacimiento + "\n";
            str += "Peso : " + Peso + "\n";
            str += "Microchip : " + Microchip + "\n";
            str += "Comentarios : " + Comentarios + "\n";

            return str;
        }





    }
}
