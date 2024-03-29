namespace WEBAPIRESTFULL.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Editoras 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Editoras()
        {
            Livros = new HashSet<Livros>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livros> Livros { get; set; }
    }
}
