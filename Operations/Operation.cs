using System.Runtime.ConstrainedExecution;
namespace Namespace;
public abstract class Operation
{
    protected int OperandeDroite { get; }
    protected int OperandeGauche { get;  }
    public int Resultat { get; protected set; }
    public Operation(int operandeGauch, int operandeDroite)
    {
       OperandeGauche = operandeGauch;
       OperandeDroite = operandeDroite;
    }
     public  abstract void Executer();

}
