namespace EstudoConsoleApp;

using System;
using EstudoConsoleApp.Aulas;
using EstudoConsoleApp.Desafios;

public class Program
{
    public static void Main(string[] args)
    {
        //ExecutarExemplo001();
        //ExecutarExemplo002();
        //ExecutarExemplo003();
        //ExecutarExemplo004();
        //ExecutarExemplo005();

        //Desafio001.Executar();
        //Desafio002.Executar();
        //Desafio003.Executar();
        //Desafio004.Executar();
        //Desafio005.Executar();
        //Desafio006.Executar();
        //Desafio007.Executar();
        //Desafio008.Executar();
        //Desafio009.Executar();
        //Desafio010.Executar();

        //Desafio003v2.Executar();

        //LacosDeRepeticao.Executar();

        //VetoresListas.Executar();
        Desafio018.Executar();


    }

    private static void ExecutarExemplo001()
    {
        Console.WriteLine("Operações Matemáticas");
        Console.WriteLine();
        Console.Write("Informe o primeiro número:");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número:");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicas.Somar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicas.Subtrair(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicas.Multiplicar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicas.Dividir(n1, n2));
        Console.ReadLine();
    }

    private static void ExecutarExemplo002()
    {
        Console.WriteLine("Comparações Lógicas");
        Console.WriteLine();
        Console.Write("Informe o primeiro número:");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número:");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        ComparacoesLogicas.MaiorQue(n1, n2);
        Console.WriteLine();
        ComparacoesLogicas.MenorQue(n1, n2);
        Console.ReadLine();
    }

    private static void ExecutarExemplo003()
    {
        Console.WriteLine("Comparações Lógicas V2");
        Console.WriteLine();
        Console.Write("Informe o primeiro número:");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número:");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        ComparacoesLogicasV2.MaiorQue(n1, n2);
        Console.WriteLine();
        ComparacoesLogicasV2.MenorQue(n1, n2);
        Console.ReadLine();
    }

    private static void ExecutarExemplo004()
    {
        TrabalhandoComDatas.ExibirDataAtual();
        Console.WriteLine();
        TrabalhandoComDatas.ExibirDataAtualFormatada();
        Console.ReadLine();
    }

    private static void ExecutarExemplo005()
    {
        Console.WriteLine("Operações Matemáticas V2");
        Console.WriteLine();
        Console.Write("Informe o primeiro número:");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número:");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicas.Somar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicas.Subtrair(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicas.Multiplicar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicas.Dividir(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (x^y): {0}", OperacoesMatematicasV2.Potenciacao(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (y^x): {0}", OperacoesMatematicasV2.Potenciacao(n2, n1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raiz Quadrada de N1): {0}", OperacoesMatematicasV2.Radiciacao(n1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raiz Quadrada de N2): {0}", OperacoesMatematicasV2.Radiciacao(n2));
        Console.ReadLine();
    }
}