using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresbeheerEFlayer.Model
{
    public class StraatEF
    {
        public StraatEF()
        {
        }

        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string Straatnaam { get; set; }
        [Column("NIScode")]
        public int GemeenteNIScode { get; set; }
        public GemeenteEF Gemeente { get; set; }
    }
}
