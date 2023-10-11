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
        if (_operation is Addition add)
        {
            add.Executer();
        }else if(_operation is Soustraction sous)
        {
            sous.Executer();
        } else if (_operation is Multiplication mul)
        {
            mul.Executer();
        } else if(_operation is Division div)
        {
            div.Executer();
        } else if(_operation is Modulo mod) 
        {
            mod.Executer();
        }else{
            Console.WriteLine("Operation non reconnue");
        }
    }


}
