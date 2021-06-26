namespace lab03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [StringLength(225)]
        public string Title { get; set; }

        [StringLength(225)]
        public string Description { get; set; }

        [StringLength(225)]
        public string Author { get; set; }

        [StringLength(225)]
        public string images { get; set; }

        public int? Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        
    }
}
