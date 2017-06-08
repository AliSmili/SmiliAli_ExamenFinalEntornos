using SmiliAli_ExamenFinalED.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmiliAli_ExamenFinalED.Models
{
    abstract class Animal : IPesable
    {
        private string _nombre;
        private string _fechaNacimiento;
        private double _peso;
        private string _comentarios;


        //CONSTRUCTORES
        
        public Animal(string nombre, string fechaNacimiento, double peso)

        {
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._peso = peso;
            
        }

        public Animal(string nombre, string fechaNacimiento,double peso,string comentarios )

        {
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._peso = peso;
            this.Comentarios = comentarios;


        }
        //PROPIEDADES DE LA CLASE
            //Solo LECTURA
        public string Nombre
        {
            get
            {
                return _nombre;
            }
          
        }

            //Solo LECTURA
        public string FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
          
        }

            //Solo LECTURA
        public double Peso
        {
            get
            {
                if (Peso <= 0) throw new Exception("El peso no puede ser un valor nulo o negativo");
                return _peso;
            }
        }


            //LECTURA y ESCRITURA
        public string Comentarios
        {
            get
            {
                return _comentarios;
            }

            set
            {
                if (value == null) throw new Exception("Hay que establecer un comentario");
                _comentarios = value;
            }
        }


        public abstract void Pesar(double peso);


        public override string ToString()
        {
            return String.Format("{0} {1}", Nombre, FechaNacimiento);
        }

    }
}
