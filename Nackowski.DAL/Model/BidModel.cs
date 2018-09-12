using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Nackowski.DAL.Model
{
    [DataContract]
    public class BidModel
    {
        [DataMember]
        public int BudID { get; set; }
        [DataMember]
        public int Summa { get; set; }
        [DataMember]
        public int AuktionID { get; set; }
        [DataMember]
        public string Budgivare { get; set; }
    }
}
