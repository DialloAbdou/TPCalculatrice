using System.Security.Cryptography.X509Certificates;

namespace Namespace;
public class Addition : Operation
{
    public Addition(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    public override void Executer()
    {
        Resultat = OperandeGauche + OperandeDroite;
    }

    public override string ToString()
    {
        return $"{OperandeGauche } + { OperandeDroite}";
    }



}
