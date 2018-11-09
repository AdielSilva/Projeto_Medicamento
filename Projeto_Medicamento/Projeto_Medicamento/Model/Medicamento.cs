using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Medicamento.Model
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Laboratorio { get { return this.laboratorio; } set { laboratorio = value; } }
        public string Nome { get { return this.nome; } set { this.nome = value; } }
        public Queue<Lote> Lotes { get { return lotes; } }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            lotes = new Queue<Lote>();
        }

        public int qtdDisponiveis()
        {
            return lotes.Count();
        }

        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int quantidade)
        {
            if(qtdDisponiveis() > quantidade)
            {
                for(int i = 0; i < quantidade; i++)
                {
                    lotes.Dequeue();
                }

                return true;
            }

            else
            {
                for (int i = 0; i < quantidade; i++)
                {
                    lotes.Dequeue();
                }
            }

            return false;
        }

        public override string ToString()
        {
            return id + " - " + nome + " - " + laboratorio + " - " + qtdDisponiveis();
        }

        public override bool Equals(object obj)
        {
            Medicamento medicamento = (Medicamento)obj;
            return medicamento.id.Equals(this.id);
        }
    }
}
