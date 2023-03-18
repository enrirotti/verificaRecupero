using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scuolaRecupero
{
    internal class Alunno
    {
        private string nome;
        private string cognome;
        private int eta;
        private string classe;


        public Alunno(string nome, string cognome, int eta, string classe)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.classe = classe;
        }


        public void addAlunno(List<string> lista)
        {
            string alunno = nome + cognome + eta.ToString() + classe;
            lista.Add(alunno);
            
        }

        public string toString(string nome, List<string> lista)
        {
            for(int i=0; i< lista.Count; i++)
            {
                if (nome == lista[i])
                {
                    return lista[i];
                }
            }
        }

        public string classi(int anni)
        {
            if (anni < 16)
            {
                return "Biennio";
            }
            else {
                return "Triennio";
            }
        }
    }
}
