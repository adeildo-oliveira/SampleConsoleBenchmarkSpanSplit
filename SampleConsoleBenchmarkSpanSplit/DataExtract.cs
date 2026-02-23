namespace SampleConsoleBenchmarkSpanSplit;

public class DataExtract
{
    public static string SplitSpan(string request)
    {
        if (string.IsNullOrWhiteSpace(request)) return "";

        var originalSpan = request.AsSpan();
        var segments = originalSpan.Split('_').GetEnumerator();
        
        segments.MoveNext();
        return originalSpan[segments.Current].ToString();
    }

    public static string SplistString(string request)
    {
        if (string.IsNullOrWhiteSpace(request)) return "";
        
        return request.Split("_")[0];
    }
}