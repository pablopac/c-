using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSPersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {

        [OperationContract]
        Persona ObtenerPersona(string Identificacion);
        /*[OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);*/

        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Persona:BaseRespuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }

        public string Sevreto { get; set; }
    }

    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string Mensaje { get; set; }
        [DataMember]
        public string Error { get; set; }
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
