using System.Runtime.ConstrainedExecution;

namespace Namespace;
public class Operation
{
    public int OperandeDroite { get; set; }
    public int OperandeGauche { get; set; }
    public int Resultat { get; set; }
    public Operation(int operandeGauch, int operandeDroite)
    {
       OperandeGauche = operandeGauch;
       OperandeDroite = operandeDroite;
    }
   

}
