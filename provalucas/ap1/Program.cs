using System;

bool continuar = true;

while (continuar)
{
    Console.WriteLine("Bem-vindo à Calculadora de IMC!");
    Console.WriteLine("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite a idade da pessoa: ");
    int idade = int.Parse (Console.ReadLine());

    Console.WriteLine("Digite o peso da pessoa (em quilogramas): ");
    double peso = double.Parse (Console.ReadLine());

    Console.WriteLine("Digite a altura da pessoa (em metros): ");
    double altura = double.Parse (Console.ReadLine());

    // Cálculo do IMC
    double calculoDoImc = peso / (altura * altura);

    // Determinação da categoria de IMC
    string categoria;
    if (calculoDoImc < 18.5)
        categoria = "Abaixo do peso";
    else if (calculoDoImc < 24.9)
        categoria = "Normal";
    else if (calculoDoImc <= 29.9)
        categoria = "Sobrepeso";
    else
        categoria = "Obeso";

    // Determinação da faixa etária
    string faixaEtaria;
    if (idade < 10)
        faixaEtaria = "Criança";
    else if (idade >=10 && idade < 20)
        faixaEtaria = "Adolescente";
    else if (idade < 60)
        faixaEtaria = "Adulto";
    else
        faixaEtaria = "Idoso";

    // Exibição do relatório
    Console.WriteLine("\nRelatório:");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {calculoDoImc:F2}");
    Console.WriteLine($"Categoria de IMC: {categoria}");
    Console.WriteLine($"Faixa etária: {faixaEtaria}");

    // Pergunta se deseja gerar um novo relatório
    Console.WriteLine("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
    string resposta = Console.ReadLine();
    continuar = resposta.Equals("S", StringComparison.OrdinalIgnoreCase); // Comando para ignorar diferenças entre maiúsculas e minúsculas. (S,s,N,n)
}

Console.WriteLine("Obrigado por usar a Calculadora de IMC!");
