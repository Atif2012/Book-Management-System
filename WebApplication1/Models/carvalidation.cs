using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    [MetadataType(typeof(carregMetaData))]
    public partial class carReg
    {
        public class carregMetaData 
        { 
        
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Book Number")]
        public string Car_Number { get; set; }

        [DisplayName("Book Name")]
        public string Model { get; set; }

        [DisplayName("Price")]
        public string Availability { get; set; }


        }
    }
}