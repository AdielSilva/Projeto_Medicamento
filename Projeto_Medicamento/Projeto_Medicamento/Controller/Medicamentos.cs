using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento.Model
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos { get { return this.listaMedicamentos; } }

        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            if(medicamento.qtdDisponiveis() == 0)
            {
                listaMedicamentos.Remove(medicamento);
                return true;
            }
            return false;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            foreach (Medicamento x in listaMedicamentos)
            {
                if(medicamento.Equals(x))
                {
                    return medicamento;
                }
            }
          
            return null;
        }
    }
}
