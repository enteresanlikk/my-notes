using System.Text;

namespace BuilderPattern.Builders;

public class UrlBuilder
{
    private readonly StringBuilder _sbUrl = new();
    private readonly StringBuilder _sbParams = new();
    private const char _delimiter = '/';

    public string BaseUrl { get; set; }
    public UrlBuilder(string baseUrl)
    {
        BaseUrl = baseUrl.TrimEnd(_delimiter);
    }

    public UrlBuilder AddPath(string path)
    {
        _sbUrl.Append(path);
        _sbUrl.Append(_delimiter);

        return this;
    }

    public UrlBuilder AddQuery(string key, string value)
    {
        _sbParams.AppendFormat("{0}={1}&", key, value);

        return this;
    }

    public string Build()
    {
        string url = $"{BaseUrl}{_delimiter}{_sbUrl.ToString().TrimEnd(_delimiter)}";
        if (_sbParams.Length > 0)
        {
            string urlParams = _sbParams.ToString().TrimEnd('&');

            url = $"{url}?{urlParams}";
        }
        return url;
    }
}
