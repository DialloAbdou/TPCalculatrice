using System.Runtime.Serialization;

namespace TPCalculatrice;

public class OperateurNonReconnuException : Exception
{
    public string _operateur { get; set; } = "";

    public OperateurNonReconnuException(string operateur):base($"l'operateur {operateur} n'est pas reconnu")
    {
        if (string.IsNullOrWhiteSpace(operateur))
        {
            throw  new ArgumentNullException($"'{nameof(_operateur)}' ne peut avoir une valeur null ou de l'espace vide {nameof(_operateur)}");

        }
        _operateur = operateur;
    }

}
