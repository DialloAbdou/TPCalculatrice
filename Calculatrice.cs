using System.Diagnostics;

namespace Namespace;
public class Calculatrice
{
    public Operation _operation { get; set; }
    public Calculatrice(Operation operation)
    {
        _operation = operation;
    }

    /// <summary>
    ///  la fonction pour exécuter
    /// </summary>
    public void Executer()
    {
       _operation.Executer();
    }


}
