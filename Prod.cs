using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WindowsForms66
{
   
        [Table(Name = "Prodykt")]
    
        class Prod
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_prod")]
        public int Id { get; set; }
        [Column(Name = "name_prod")]
        public string ProductName { get; set; }
        [Column(Name = "price_prod")]
        public int Price { get; set; }

    }
}
