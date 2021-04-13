using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Configurator_PC.Data;

namespace Configurator_PC.Models
{
    public class HardDrive : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }
    }
}
