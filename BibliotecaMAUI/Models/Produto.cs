using BibliotecaMAUI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMAUI.Models
{
    [Table("produto", Schema = "public")]
    public class Produto : IServico
    {
        [Key]
        public int cd_codigo { get; set; }
        public string ds_nome { get; set; }
        public string ds_descricao { get; set; }
        public decimal vl_valor { get; set; }
    }
}