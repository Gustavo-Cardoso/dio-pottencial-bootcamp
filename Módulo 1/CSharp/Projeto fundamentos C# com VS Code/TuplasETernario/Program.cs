﻿using TuplasETernario.Models;
using System.Globalization;

// Tupla
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Gustavo", "Cardoso", 1.75M);// Essa aqui é a mais recomendada

// Outras maneiras de usar a Tupla
//Fazendo de uma dessas maneiras não é possível nomear meu objeto
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Gustavo", "Cardoso", 1.75M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Gustavo", "Cardoso", 1.75M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}m");

// Usando uma tupla em um método
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    Console.WriteLine("Quantidade linhas do meu arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("não foi porssível ler o arquivo");
}
