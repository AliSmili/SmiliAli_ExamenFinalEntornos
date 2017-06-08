using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmiliAli_ExamenFinalED.Models;

namespace SmiliAli_ExamenFinalEntornos.Models
{
    class Reptil : Animal
    {
        private string _especie;
        private Boolean _venenoso;

        //CONSTRUCTOR

        public Reptil(string nombre, string fechaNacimiento, double peso, string especie, Boolean venenoso): base(nombre, fechaNacimiento, peso){
            this.Especie = especie;
            this._venenoso = venenoso;
            
        }

        //PROPIEDADES

        public string Especie
        {
            get
            {
                return _especie;
            }
            set
            {
                if (value == null) throw new Exception("Este campo no puede quedar vacío");
                _especie = value;
            }
        }

        public Boolean Venenoso
        {
            get
            {
                return _venenoso;
            }
            set
            {
                
                _venenoso = value;
            }
        }


        //METODOS
        public override void Pesar(double peso)
        {
            Console.WriteLine("El reptil se ha pesado");
        }

        //METODO ToString()

        new string ToString()
        {
            var str = "";

            str = "Ficha de Perro\n";
            str += "Nombre : " + Nombre + "\n";
            str += "Fecha de Nacimiento : " + FechaNacimiento + "\n";
            str += "Peso : " + Peso + "\n";
            str += "Especie : " + Especie + "\n";
            if(Venenoso == true)
            {
                str += "Es Venenoso ? -> " + "SI\n";
            }else
            {
                str += "Es Venenoso ? -> " + "NO\n";
            }
           
            str += "Comentarios : " + Comentarios + "\n";

            return str;
        }


    }
}
