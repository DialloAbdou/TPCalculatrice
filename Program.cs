// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Namespace;
int getValeur(int n)
{
    int resultat = 0;
    Console.WriteLine($"Veuillez saisir {n} valeur");
    string? saisie = Console.ReadLine();
    if (saisie is not null)
    {
        try
        {
            resultat = int.Parse(saisie);
        }
        catch
        {
            resultat = 0;
        }

    }
    return resultat;
}
Console.WriteLine("===La pétite calculatrice=====");
// instanciation de la classe Calculatrice
int operandeGauche = 0;
int operandeDroite = 0;
// Console.WriteLine("Veuillez Saisir la Prémière Valeure !");
// string? strOperandeGauche = Console.ReadLine();
// if (strOperandeGauche is not null)
// {
//     operandeGauche = int.Parse(strOperandeGauche);
// }
operandeGauche = getValeur(1);
operandeDroite = getValeur(2);
// Console.WriteLine("Veuillez Saisir la deuxième valeure !");
// string? strOperandeDroite = Console.ReadLine();
// if (strOperandeDroite is not null)
// {
//     operandeDroite = int.Parse(strOperandeDroite);
// }


//====== Operation ======
Operation? operation = null;
// instanciation du Constructeur
Console.WriteLine("Veuillez saisir l'operateur pour le calcul");
string? operateur = Console.ReadLine();

if (operateur == "+")
{
    operation = new Addition(operandeGauche, operandeDroite);

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

Console.WriteLine($"le resultat :{calculatrice._operation.Resultat}");





