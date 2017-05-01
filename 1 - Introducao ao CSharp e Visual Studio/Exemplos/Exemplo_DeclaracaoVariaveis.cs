using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_DeclaraçãoVariaveis
{
    static void Main(string[] args)
    {
        //Inteiros
        byte b1 = 255; // 0 até 255
        sbyte sb1 = -128; // -128 até 128

        short s = -3276; // -32767 até 32767
        ushort us = 65535; // 0 até 65535

        int i = -2147483647; // -2147483647 até 2147483647
        uint ui = 4294967295; // 0 até 4294967295

        long l = -9223372036854775808;
        ulong ul = 18446744073709551615;

        char c1 = (char) 123;
        char c2 = 'a';


        //Decimais
        float f1 = (float) 3.1234567;
        float f2 = 3.1234567f;

        double d1 = 9812739801723123.1234567891234567;
        double d2 = 9812739801723123.1234567891234567d;

        decimal dc1 = (decimal) 9812739801723123.1234567891234567;
        decimal dc2 = 9812739801723123.1234567891234567m;


        //Booleano e Caracteres
        bool verdadeiro = true;
        char meuChar = 'a';

        string minhaString1 = "abc...z";
        string minhaString2 = "abc...z" + "\n123...9";
        string minhaOutraString3 =
            @"esta string 
            aceita
            linhas";


        //Escape Character Sequence
        string singleQuote = "\'Single Quote\'";
        string doubleQuote = "\"Single Quote\"";
        string backslash = "\\Single Quote\\";
    }
}
