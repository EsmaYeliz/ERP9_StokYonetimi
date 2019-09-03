using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity<IKey>: IEntity<IKey>
    {
        [Key]
        public IKey Id { get; set; }

    }
}
