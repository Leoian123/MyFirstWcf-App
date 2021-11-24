using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialator.Entities
{

    [Serializable]
    [DataContract]
    public class Person
    {
        #region Properties
        //[System.Xml.Serialization.XmlAttributeAttribute(DataType ="string")]
        public string Nome { get; set; }
        public string Setting { get; set; }
        public string LastName { get; set; }
        #endregion
        public Person() { }
        public Person(string nome, string setting, string lastName)
        {
            this.Nome = nome;
            this.Setting = setting;
            this.LastName = lastName;
        }
    }
}
