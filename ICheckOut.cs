using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinLibrary
{
    public interface ICheckOut
    {
        public int MyProperty { get; set; }
        public void CheckOut();
        public void ReturnBook();
    }
}
