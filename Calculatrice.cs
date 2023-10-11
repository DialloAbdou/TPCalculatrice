using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Namespace;
public class Calculatrice
{
    public Operation _operation { get; }
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
