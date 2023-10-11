namespace Namespace;
public class Division : Operation
{   public Division(int operandeGauch, int operandeDroite) : base(operandeGauch, operandeDroite)
    {
        
    }

    public void Executer()
    {
        if(OperandeDroite!=0)
        {
            Resultat = OperandeGauche /OperandeDroite;
        }
    }

}
