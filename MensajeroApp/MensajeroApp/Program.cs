using MensajeroModel.DAL;
using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroApp
{
    class Program
    {
        static IMensajesDAL dal = MensajesDALFactory.CreateDal();

        //Metodo ingresar
        static void IngresarMensaje()
        {
            string nombre, detalle;
            do
            {
                Console.WriteLine("Ingrese nombre:");
                nombre = Console.ReadLine().Trim();
            } while (nombre == string.Empty);

            do
            {
                Console.WriteLine("Ingrese detalle:");
                detalle = Console.ReadLine().Trim();
            } while (detalle == string.Empty);

            Mensaje m = new Mensaje();
            m.Nombre = nombre;
            m.Detalle = detalle;
            m.Tipo = "Aplicacion";

            dal.Save(m);
        }

        //Metodo mostrar
        static void MostrarMensajes()
        {
            List<Mensaje> mensajes = dal.GetAll();

            mensajes.ForEach(m =>
            {
                Console.WriteLine("Nombre:{0} | Detalle:{1} | Tipo:{2}"
                    , m.Nombre, m.Detalle, m.Tipo);
            });
        }

        //Menu
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Seleccione opción:");
            Console.WriteLine("1. Ingresar mensaje");
            Console.WriteLine("2. Mostrar mensaje");
            string opcion = Console.ReadLine().Trim();

            switch (opcion)
            {
                case "1": IngresarMensaje();
                    break;
                case "2":
                    MostrarMensajes();
                    break;
                case "0": continuar = false;
                    break;
            }
            return continuar;
        }

        static void Main(string[] args)
        {

            while (Menu()) ;
            //Mensaje m = new Mensaje()
            //{
              //Nombre = "Ema",
              //Detalle = "Volví",
              //Tipo = "Aplicacion"
            //};
            //dal.Save(m);

        }
    }
}
