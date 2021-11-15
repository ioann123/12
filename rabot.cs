using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsForms66
{
    [Table(Name = "Rab")]
    class rabot
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_rab")]
        public int Id { get; set; }
        [Column(Name = "name_rab")]
        public string NamePostavshict { get; set; }
        [Column(Name = "dolj")]
        public string Doljnost { get; set; }
        [Column(Name = "id_post")]
        public int IdPostavki { get; set; }
    }
}
