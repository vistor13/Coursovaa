using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursovaa
{
    public class Base<T> where T:Base<T>
    {
        public static Dictionary<Guid, T> It = new Dictionary<Guid, T>();
        public Guid Id { get; set; }
        public Base()
        {
            Id = Guid.NewGuid();
            It.Add(Id, (T)this);
        }   
    }
}
