﻿using System.Globalization;

// Alterando a localização do sistema para uma localização específica
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-Us"); // Formatando para dólar

// Formatando valores monetários
decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");
/* Quando uso interpolação e uso "dois pontos", isso signica que eu quero 
formatar ele. Nesse caso o "C" ele formata em valor monetário de acordo com a configuração
do sistema */

// Definindo uma cultura mesmo com a localização travada
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formatando para real mesmo com a cultura travada em "en-Us"

// Criando uma formatação personalizada
Console.WriteLine(valorMonetario.ToString("C1")); // 1 representa a quantidade de casas decimais
Console.WriteLine(valorMonetario.ToString("C2")); // 2 representa a quantidade de casas decimais
Console.WriteLine(valorMonetario.ToString("C8")); // 8 representa a quantidade de casas decimais