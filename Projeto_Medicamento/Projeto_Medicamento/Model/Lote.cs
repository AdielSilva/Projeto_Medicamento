using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento
{
    class Lote
    {
        private int id;
        private int qtd;
        private DateTime vencimento;

        public int Id { get { return this.id; } set { id = value; } }
        public int Qtd { get { return this.qtd; } set { qtd = value; } }
        public DateTime Vencimento { get { return this.vencimento; } set { vencimento = value; } }

        public Lote()
        {

        }

        public Lote(int id, int qtd, DateTime data)
        {
            this.id = id;
            this.qtd = qtd;
            this.vencimento = data;
        }

        public override string ToString()
        {
            return id + " - " + qtd + " - " + vencimento;
        }
    }
}
