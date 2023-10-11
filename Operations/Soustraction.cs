namespace Namespace;
public class Soustraction : Operation
{
    public Soustraction(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    /// <summary>
    /// la fonction
    /// </summary>
    public override void Executer()
    {
        Resultat = OperandeGauche - OperandeDroite;
    }
}
