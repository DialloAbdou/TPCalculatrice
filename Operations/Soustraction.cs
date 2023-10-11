namespace Namespace;
public class Soustraction : Operation
{
    public Soustraction(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void Executer()
    {
        Resultat = OperandeGauche - OperandeDroite;
    }
}
