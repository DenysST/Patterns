#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace Proxy;

public class DocumentProxy : IDocument
{
    private readonly Document _document;
    private readonly string _userRole;

    public DocumentProxy(string content, string userRole)
    {
        _document = new Document(content);
        _userRole = userRole;
    }

    public string View()
    {
        if (_userRole == "AuthorizedUser")
        {
            return _document.View();
        }

        return "Unauthorized access";
    }
}