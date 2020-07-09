using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;



public class TwineConversation
{
    private string _title;
    private List<TwineSentence> _sentences;
    private List<TwineReponse> _reponses;
    private List<string> _tags;

    public string Title => _title;

    public List<TwineSentence> Sentences => _sentences;

    public List<TwineReponse> Reponses => _reponses;

    public TwineConversation(string title, List<TwineSentence> sentences, List<TwineReponse> reponses, List<string> tags)
    {
        _title = title;
        _sentences = sentences;
        _reponses = reponses;
        _tags = tags;
    }

    private TwineConversation()
    {
        _reponses = new List<TwineReponse>();
        _sentences = new List<TwineSentence>();
        _tags = new List<string>();
        _title = "Untitled";
    }

    private static readonly Regex ReponsePattern = new Regex("@\\[\\[((?<text>.*)?->)?(?<where>.*)\\]\\]");
    private static readonly Regex HeaderPattern = new Regex("@(?<title>.*)(\\[(?<tags>.*)\\])?");
    private static readonly Regex SentencePattern = new Regex(@"(?<character>.*):(?<text>.*)");
    public static TwineConversation Parse(string conversationData)
    {
        TwineConversation twineConversation = new TwineConversation();
        var lines = conversationData.Split(new string[]{@"\r\n"}, StringSplitOptions.None);
        
        string firstLine = lines[0];
        int tagIndicator = firstLine.IndexOf('[');
        
        if (tagIndicator == -1)
        {
            twineConversation._title = firstLine;
        }
        else
        {
            // tile [tag1, tag2, tag3]
            twineConversation._title = firstLine.Substring(0, tagIndicator - 1);
            string[] tags = firstLine
                .Substring(tagIndicator + 1, firstLine.Length - 2)
                .Split(new string[]{@",\s*"}, StringSplitOptions.None);
            foreach (var tag in tags)
            {
                twineConversation._tags.Add(tag);
            }
        }

        
        for (int i = 1; i < lines.Length; ++i)
        {
            string line = lines[i];
            if (ReponsePattern.IsMatch(line))
            {
                var match = ReponsePattern.Match(line);
                TwineReponse twineReponse = new TwineReponse(match.Groups["text"].Value, match.Groups["where"].Value);
                twineConversation._reponses.Add(twineReponse);
            }
            else
            {
                var match = SentencePattern.Match(line);
                TwineSentence twineSentence = new TwineSentence("no name", line);
                twineConversation._sentences.Add(twineSentence);
            }
        }


        return twineConversation;
    }

    public bool HasTag(string tag)
    {
        return _tags.Find((s => s.Equals(tag))) != null;
    }

    public List<string> Tags
    {
        get => _tags;
        set => _tags = value;
    }

    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Sentences)}: {Sentences}, {nameof(Reponses)}: {Reponses}, {nameof(Tags)}: {Tags}";
    }
}
