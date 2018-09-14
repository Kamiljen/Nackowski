using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Nackowski.DAL.Model
{
    [DataContract]
    public class AuctionModel
    {
        [DataMember]
        public int AuktionID { get; set; }

        [DataMember]
        public string Titel { get; set; }

        [DataMember]
        public string Beskrivning { get; set; }

        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember(Name = "StartDatum")]
        public string StartDatumString { get; set; }

        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember(Name = "SlutDatum")]
        public string SlutDatumString { get; set; }

        [DataMember]
        public int Gruppkod { get; set; }

        [DataMember]
        public int Utropspris { get; set; }

        [DataMember]
        public string SkapadAv { get; set; }

        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }


    }
}
