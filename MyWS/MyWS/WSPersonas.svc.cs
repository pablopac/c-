using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas

    {
        /* public string GetData(int value)
         {
             return string.Format("You entered: {0}", value);
         }

         public CompositeType GetDataUsingDataContract(CompositeType composite)
         {
             if (composite == null)
             {
                 throw new ArgumentNullException("composite");
             }
             if (composite.BoolValue)
             {
                 composite.StringValue += "Suffix";
             }
             return composite;
         }*/
        public Persona ObtenerPersona(string Identificacion)
        {
            if (Identificacion == "0")
            {
                return new Persona() { Nombre = "Felipe", Edad = 55 };
            }
            else if (Identificacion == "1")
            {
                return new Persona() { Nombre = "Carlos", Edad = 60 };
            }
            else
            {
                return new Persona() { Error = "error " };
            }
            //throw new NotImplementedException();
        }
    }
}
