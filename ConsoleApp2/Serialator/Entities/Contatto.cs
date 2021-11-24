using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialator
{
    [DataContract]
    public class Contatto
    {
        #region Properties
        [DataMember] public int Id { get; set; }
        [DataMember] public string Nome { get; set; }
        [DataMember] public string Cognome { get; set; }
        [DataMember] public string NumberPhone { get; set; }
        [DataMember] public DateTime? BirthDay { get; set; }
        #endregion
        #region Constructor
        public Contatto()
        {
        }
        #endregion
    }
}
