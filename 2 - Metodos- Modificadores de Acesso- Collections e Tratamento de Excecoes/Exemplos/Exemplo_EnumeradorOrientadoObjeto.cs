//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoCsharp_Enumeradores
//{
//    class Exemplo_EnumeradorOrientadoObjeto
//    {
//        static void Main(string[] args)
//        {
//            Pessoa pessoa = new Pessoa();

//            pessoa.Nome = "";
//            pessoa.TipoPessoa = TipoPessoa.Fisica;

//            pessoa.TipoDocoumento = TipoDocumento.CPF;
//            pessoa.documento = "000.000.000-55";

//            pessoa.TipoEndereco = TipoEndereco.Comercial;
//            pessoa.Endereco = "Venancio Aires 1742";
//        }
//    }

//    public class Pessoa
//    {
//        public string Nome;

//        public TipoPessoa TipoPessoa;

//        public TipoEndereco TipoEndereco;
        
//        public string Endereco;

//        public TipoDocumento TipoDocoumento;

//        public string documento;
//    }

//    public enum TipoPessoa
//    {
//        Fisica = 0,
//        Juridica = 1,
//    }

//    public enum TipoDocumento
//    {
//        CPF = 0,
//        RG = 1,
//        ID = 2,
//        CNH = 3
//    }

//    public enum TipoEndereco
//    {
//        Residencial = 0,
//        Comercial = 1,
//    }
//}
