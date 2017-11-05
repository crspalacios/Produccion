using System.ComponentModel.DataAnnotations;

namespace Produccion.Domain
{
    public class Maquina
    {

        [Key]
        public int MaquinaId
        {
            get;
            set;
        }
        [Required]
        public string MaquinaPersonalId
        {
            get;
            set;
        }
        [Required]
        public string Description
        {
            get;
            set;
        }
    }
}
