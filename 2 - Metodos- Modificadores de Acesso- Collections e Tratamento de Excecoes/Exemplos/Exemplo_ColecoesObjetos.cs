using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_ColecoesObjetos
{
    void Exemplo_ArrayList()
    {

        ArrayList lst = new ArrayList();

        // ArrayList permite a insercao de objetos HOMOGENEOS
        lst.Add(1);
        lst.Add("Minha String");
        
        Pessoa pessoa = new Pessoa();

        lst.Add(pessoa);
        lst.Add(new Pessoa());


        //Retorna o objeto da posicao 0
        int meuInt = (int) lst[0];

        //Remove o objeto da posicao 0
        lst.RemoveAt(0);

        //Remove o objto do tipo int e valor 1
        lst.Remove(1);
    }

    void Exemplo_Queue()
    {
        //Queue permite a insercao de objetos heterogeneos ou homogeneos

        //Utilizacao de objetos heterogeneos
        //Stack lstPessoas = new Stack();

        //Utilizacao de objetos homogeneneos
        Queue<Pessoa> lstPessoas = new Queue<Pessoa>();

        // Adiciona uma pessoa na fila
        lstPessoas.Enqueue(new Pessoa());
        lstPessoas.Enqueue(new Pessoa());
        lstPessoas.Enqueue(new Pessoa());

        // Retorna a primeira pessoa da fila
        Pessoa pessoa = lstPessoas.Peek();

        //Retorna a pessoa da posicao desejada
        pessoa = lstPessoas.ElementAt(1);
 
        // Remove a primeira pessoa da lista
        lstPessoas.Dequeue();
    }

    void ExemploStack()
    {
        //Stack permite a insercao de objetos heterogeneos ou homogeneos

        //Utilizacao de objetos heterogeneos
        //Stack lstPessoas = new Stack();

        //Utilizacao de objetos homogeneneos
        Stack<Pessoa> lstPessoas = new Stack<Pessoa>();

        // Adiciona uma pessoa na PILHA
        lstPessoas.Push(new Pessoa());
        lstPessoas.Push(new Pessoa());
        lstPessoas.Push(new Pessoa());

        // Retorna a primeira pessoa da pilha (ou seja, DO TOPO)
        Pessoa pessoa = lstPessoas.Peek();

        //Retorna a pessoa da posicao desejada
        pessoa = lstPessoas.ElementAt(1);

        // Remove a primeira pessoa da pilha
        lstPessoas.Pop();
    }

    void ExemploList()
    {
        //Stack permite a insercao de objetos heterogeneos ou homogeneos

        //Utilizacao de objetos heterogeneos
        //Stack lstPessoas = new Stack();

        //Utilizacao de objetos homogeneneos
        List<Pessoa> lstPessoas = new List<Pessoa>();

        // Adiciona uma pessoa na PILHA
        lstPessoas.Add(new Pessoa());
        lstPessoas.Add(new Pessoa());
        lstPessoas.Add(new Pessoa());

        // Retorna a primeira pessoa da lista
        Pessoa pessoa = lstPessoas.First();

        //Retorna a pessoa da posicao desejada
        pessoa = lstPessoas.ElementAt(1);

        // Remove a pessoa da posicao desejada
        lstPessoas.RemoveAt(0);
    }

    void ExemploDictionary()
    {
        //Um dicionario onde a CHAVE é o CPF (string) e a pessoa é o valor
        Dictionary<string, Pessoa> dicionario = new Dictionary<string, Pessoa>();

        //Adiciona um par chave-valor no dicionario
        dicionario.Add("028.123.123-12", new Pessoa());

        //Busca a pessoa contendo a chave determinada
        Pessoa pessoa = dicionario["123.123.123-99"];
    }
}

public class Pessoa
{
    public string Nome;

    public TipoPessoa TipoPessoa;

    public TipoEndereco TipoEndereco;

    public string Endereco;

    public TipoDocumento TipoDocoumento;

    public string documento;
}

public enum TipoPessoa
{
    Fisica = 0,
    Juridica = 1,
}

public enum TipoDocumento
{
    CPF = 0,
    RG = 1,
    ID = 2,
    CNH = 3
}

public enum TipoEndereco
{
    Residencial = 0,
    Comercial = 1,
}
