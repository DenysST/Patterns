#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace Proxy;

public class Document : IDocument
{
    private readonly string _content;

    public Document(string content)
    {
        _content = content;
    }

    public string View()
    {
        return _content;
    }
}