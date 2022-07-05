using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoPOO
{
    public class Empregado : Pessoa
    {
        private double dSalario;

        private double dSalarioMinimo = 240.00;

        private int iLicencasPremioRecebidas;
        public double DSalario { get => this.dSalario; set => this.dSalario = value; }
        public double DSalarioMinimo { get => this.dSalarioMinimo; set => this.dSalarioMinimo = value; }
        public int ILicencasPremioRecebidas { get => iLicencasPremioRecebidas; set => iLicencasPremioRecebidas = value; }

        public Empregado(string sName, double dSalario, double dSalarioMinimo, int iLicencasPremioRecebidas) : base(sName)
        {
            this.sName = sName;
            this.dSalario = dSalario;
            this.dSalarioMinimo = dSalarioMinimo;
            this.iLicencasPremioRecebidas = iLicencasPremioRecebidas;
        }
    }
}
