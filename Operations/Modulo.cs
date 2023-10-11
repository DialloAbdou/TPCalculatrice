namespace Namespace;
public class Modulo : Operation
{
    public Modulo(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
    }

    public void Executer()
    {
        Resultat = OperandeGauche % OperandeDroite;
    }
}
