using BibliotecaMAUI.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMAUI.Models
{
    [Table("solicitacao", Schema = "public")]
    public class Solicitacao : IServico
    {
        [Key]
        public int cd_codigo { get; set; }
        public int cd_codigo_interno { get; set; }
        public string ds_parametros { get; set; }
        public string ds_entidade { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
        public string ds_metodo { get; set; }
        public string ds_resolucao { get; set; }
    }
}
