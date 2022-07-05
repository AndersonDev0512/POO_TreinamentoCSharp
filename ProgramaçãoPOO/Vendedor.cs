using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoPOO
{
    public class Vendedor : Empregado
    {
        private double dComissao;
        public double DComissao { get => this.dComissao; set => this.dComissao = value; }
        public Vendedor(string sName,double dSalario,double dSalarioMinimo,int iLicencasPremioRecebidas,double dComissao):base(sName,dSalario,dSalarioMinimo,iLicencasPremioRecebidas)
        {
            this.sName = sName;
            this.DSalario = dSalario;
            this.DSalarioMinimo = dSalarioMinimo;
            this.ILicencasPremioRecebidas = iLicencasPremioRecebidas;
            this.dComissao = dComissao;
        }
    }
}
