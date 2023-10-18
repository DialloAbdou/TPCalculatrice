// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection;
using Namespace;
using TPCalculatrice;
int getValeur(string valeur)
{
    int? resultat = null;
    while (!resultat.HasValue)
    {
        Console.WriteLine($"Veuillez saisir la {valeur} valeur entière");
        string? saisie = Console.ReadLine();
        if (saisie is not null)
        {
            try
            {
                resultat = int.Parse(saisie);
            }
            catch (ExecutionEngineException)
            {
                resultat = null;
            }
        }

    }
    return resultat.Value;
}
Console.WriteLine("===La pétite calculatrice=====");
// instanciation de la classe Calculatrice
int operandeGauche = 0;
int operandeDroite = 0;
operandeGauche = getValeur("premiere");
operandeDroite = getValeur("deuxième");

//====== Operation ======
// instanciation du Constructeur

// Utilisation de Switch Expression

try
{
    Console.WriteLine("Veuillez saisir l'operateur pour le calcul");
    string? operateur = Console.ReadLine();
    if (operateur is not null)
    {
        Operation operation = operateur switch
        {
            "+" => new Addition(operandeGauche, operandeDroite),
            "-" => new Soustraction(operandeGauche, operandeDroite),
            "*" => new Multiplication(operandeGauche, operandeDroite),
            "/" => new Division(operandeGauche, operandeDroite),
            "%" => new Modulo(operandeGauche, operandeDroite),
            _ => throw new OperateurNonReconnuException(operateur)
        };
        Calculatrice calculatrice = new Calculatrice(operation);
        calculatrice.Executer();
        Console.WriteLine($"le resultat {calculatrice._operation.ToString()} est :{calculatrice._operation.Resultat}");

    }else 
    {
        Console.WriteLine("aucun operateur a été saisie !");
    }

}
catch (OperateurNonReconnuException e)
{
    Console.WriteLine($"le resultat renvoie une opération null {e.Message}");
   
}catch(Exception e)
{
    Console.WriteLine($"Erreur genera ! {e.Message}");
}