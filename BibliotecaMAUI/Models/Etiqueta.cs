using BibliotecaMAUI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMAUI.Models
{
    [Table("etiqueta", Schema = "public")]
    public class Etiqueta : IServico
    {
        [Key]
        public int cd_codigo { get; set; }
        public int cd_etiqueta { get; set; }
        public int cd_produto { get; set; }
        public decimal vl_m2 { get; set; }
        public int vl_quantidade { get; set; }
        public int cd_setor { get; set; }
    }
}