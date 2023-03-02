using BibliotecaMAUI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMAUI.Models
{
    [Table("setor", Schema = "public")]
    public class Setor : IServico
    {
        [Key]
        public int cd_codigo { get; set; }
        public string ds_setor { get; set; }
    }
}