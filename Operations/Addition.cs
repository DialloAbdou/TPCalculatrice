namespace Namespace;
public class Addition : Operation
{
    public Addition(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    public void Executer()
    {
        Resultat = OperandeGauche + OperandeDroite;
    }

}
