namespace lab._5.FolderforModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Motorbike
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        public double Price { get; set; }

        public int Horsepower { get; set; }

        public double Milieage { get; set; }

        [Required]
        public string Picture { get; set; }
    }
}
