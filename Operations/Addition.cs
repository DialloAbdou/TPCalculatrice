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
        return $"{OperandeGauche} + {OperandeDroite}";
    }


    public override bool Equals(object? obj)
    {
        if(obj is null)
        {
            return false;
        }
        if (obj is Addition addition)
        {
           return this.OperandeGauche == addition.OperandeGauche
            && this.OperandeDroite == addition.OperandeDroite;
        }else
        {
            return false;
        }

    }

}
