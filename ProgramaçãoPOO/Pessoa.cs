using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoPOO
{
    public class Pessoa
    {
        protected string sName;
        public string SName { get => sName; set => sName = value; }
        public Pessoa(string sName)
        {
            this.sName = sName;
        }
        public Pessoa() 
        {}
    }
}
