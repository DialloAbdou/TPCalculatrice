namespace Namespace;
public class Multiplication : Operation
{
    public Multiplication(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    public override void Executer()
    {
        Resultat = OperandeGauche * OperandeDroite;
    }
}
