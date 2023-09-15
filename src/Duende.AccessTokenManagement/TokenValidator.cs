using System.Linq;

namespace Duende.AccessTokenManagement;

static class TokenValidator
{
    private static readonly string _tokenTypeChars = "!#$%&'*+-.0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ^_`abcdefghijklmnopqrstuvwxyz|~";

    internal static bool IsValidTokenType(string tokenType) => tokenType.All(character => _tokenTypeChars.Contains(character));
}
