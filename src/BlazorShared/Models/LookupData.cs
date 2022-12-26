using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Models
{
    public abstract class LookupData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
