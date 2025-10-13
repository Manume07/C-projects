using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoBancario
{
    internal class ContoBancario
    {
        private long _numeroUnivoco;
        private string _nomeTitolare;
        private double _saldoConto;
        private double _versamento;


        public ContoBancario(long numeroUnivoco, string nomeTitolare, double saldoConto, double versamento, double prelievo)
        {
            _numeroUnivoco = numeroUnivoco;
            _nomeTitolare = nomeTitolare;
            _saldoConto = saldoConto;
        }

        public long GeneraNumeroUnivoco(long numeroUnivoco)
        {
            Random rnd = new Random();
            _numeroUnivoco = rnd.NextInt64(0000000000, 9999999999);
            return _numeroUnivoco;
        }

        public string setNomeTitolare(string nomeTitolare)
        {
            string nome = nomeTitolare;
            _nomeTitolare = nome.ToLower();
            return _nomeTitolare;
        }

        public double setRecuperaSaldo()
        {
            return _saldoConto;
        }

        public bool prelievoConto(double importoPrelievo)
        {
            if (_saldoConto <= 0)
            {
                return false;
            }
            else
            {
                if (importoPrelievo <= _saldoConto)
                {
                    _saldoConto -= importoPrelievo;
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public double versamentoConto(double importoVersamento)
        {
            bool valore;
            valore = false;
            while (valore == false)
            {
                if (_versamento > 0.0)
                {
                    valore = true;
                    _saldoConto += importoVersamento;
                }
            }
            return _saldoConto;


        }

       
    }
}


/*conto bancario(TERMINI IN ITALIANO) CLASSI E OGGETTI
- numero univoco 10 cifre che identifica conto (codice)
- stringa coi nomi dei titolari (nome persona conto corrente)
- possibile recuperare il saldo (sapere i soldi del conto)
- il conto accetta prelievi e versamenti (puoi aggiungere e togliere soldi)
- saldo iniziale positivo (soldi>-1)
- prelievi non possono risultare in saldo negativo (saldo sempre positivo dopo prelievo)
*/
