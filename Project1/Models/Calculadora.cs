using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Calculadora
    {
        private List<string> Listahistorico;
        private string data;

        public Calculadora(string ddata) 
        {
            Listahistorico = new List<string>();
            ddata = data;
        }
        public int somar(int val1, int val2)
        {      
            int res = val1 + val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int multiplicar(int val1, int val2)
        {   
            int res = val1 * val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int dividir(int val1, int val2)
        {  
            int res = val1 / val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public List <string>historico()
        {
            
            return Listahistorico;
        }
        
    }
}