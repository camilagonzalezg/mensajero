using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{

    //En esta interfaz se hacen todos los métodos necesarios para la app
    public interface IMensajesDAL
    {

        //Guardar
        void Save(Mensaje m);

        //Lista
        List<Mensaje> GetAll();

    }
}
