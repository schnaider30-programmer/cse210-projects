using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {

            //Use to detect if the filename ends with ".csv". It ignores case.
            bool isCsv = file.EndsWith(".csv", StringComparison.OrdinalIgnoreCase);

            if (isCsv)
            {
                outputFile.WriteLine("DATE,PROMPT,ANSWER");
                foreach (Entry entry in _entries)
                {
                    string date = CreateCsv(entry._date);
                    string prompt = CreateCsv(entry._promptText);
                    string answer = CreateCsv(entry._entryText);

                    outputFile.WriteLine($"{date},{prompt},{answer}");
                };
            }

            else
            {
                outputFile.WriteLine("Date | Prompt | Answer");

                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                }
            }

        }

    }

    private string  CreateCsv(string text)
    {
        if (text == null) return "\"\"";
        string textQuoted = text.Replace("\"", "\"\"");
        return $"\"{textQuoted}\"";
    }

    public void LoadFromFile(string file)
    {
        bool isCsv = file.EndsWith(".csv", StringComparison.OrdinalIgnoreCase);

        IEnumerable<string> lines = File.ReadLines(file).Skip(1);

        foreach (string line in lines)
        {
            if (isCsv)
            {
                string[] parts = line.Split(",");

                string date = parts[0];
                date = date.Trim().Trim('"');

                string prompt = parts[1];
                prompt = prompt.Trim().Trim('"');

                string answer = string.Join(",", parts.Skip(2));
                answer = answer.Trim().Trim('"');

                Entry entry = new Entry(date, prompt, answer);
                AddEntry(entry);
            }
            
            else
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string answer = parts[2];

                Entry entry = new Entry(date, prompt, answer);
                AddEntry(entry);
            }
        }

    }
}