// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Namespace;
int getValeur(string valeur )
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
            catch
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
Operation? operation = null;
Operation? operationSeconde = null;
// instanciation du Constructeur
Console.WriteLine("Veuillez saisir l'operateur pour le calcul");
string? operateur = Console.ReadLine();

if (operateur == "+")
{
    operation = new Addition(operandeGauche, operandeDroite);
    operationSeconde = new Addition(operandeGauche,operandeDroite);
    Console.WriteLine($"les deux operation sont égaux ? {operation.Equals(operationSeconde)}");
}
else if (operateur == "-")
{
    operation = new Soustraction(operandeGauche, operandeDroite);
}
else if (operateur == "*")
{
    operation = new Multiplication(operandeGauche, operandeDroite);

}
else if (operateur == "/")
{
    operation = new Division(operandeGauche, operandeDroite);
}
else
{
    operation = new Modulo(operandeGauche, operandeDroite);

}
Calculatrice calculatrice = new Calculatrice(operation);
calculatrice.Executer();
Console.WriteLine($"le resultat {calculatrice._operation.ToString()} est :{calculatrice._operation.Resultat}");





