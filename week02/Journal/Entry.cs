using System;

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public Entry(string prompt, string response, string date = null)
    {
        Prompt = prompt;
        Response = response;
        Date = date ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}