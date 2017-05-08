using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Domain.Model
{
    public abstract class Field : Entity
    {
        public virtual int Id { get; set; }
        public virtual bool IsDeleted { get; set; }
    }

    public class PrimitiveField<T> : Field
    {
        public virtual T Value { get; set; }
    } 
}
