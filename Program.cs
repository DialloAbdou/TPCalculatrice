// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Namespace;

Console.WriteLine("===La pétite calculatrice=====");
// instanciation de la classe Calculatrice

Console.WriteLine("Veuillez Saisir la Prémière Valeure !");
int operandeGauche = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez Saisir la deuxième valeure !");
int operandeDroite = int.Parse(Console.ReadLine());
//====== Operation ======

Operation operation = null;
// instanciation du Constructeur
Console.WriteLine("Veuillez saisir l'operateur pour le calcul");
string operateur = Console.ReadLine();

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

Console.WriteLine($"le resultat :{ calculatrice._operation.Resultat }");





