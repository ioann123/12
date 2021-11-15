using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsForms66
{
    [Table(Name = "post")]
    class Pos
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_post")]
        public int Id { get; set; }
        [Column(Name = "id_prod")]
        public int ProductName { get; set; }
        [Column(Name = "koll")]
        public int Kollichestvo { get; set; }
        [Column(Name = "price_zak")]
        public int ZenaZakaza { get; set; }

    }
}
