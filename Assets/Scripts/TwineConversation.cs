using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TwineConversation
{
    private string _title;
    private List<TwineSentence> _sentences;
    private List<TwineReponse> _reponses;

    public string Title => _title;

    public List<TwineSentence> Sentences => _sentences;

    public List<TwineReponse> Reponses => _reponses;

    public TwineConversation(string title, List<TwineSentence> sentences, List<TwineReponse> reponses)
    {
        _title = title;
        _sentences = sentences;
        _reponses = reponses;
    }

    public static TwineConversation Parse(string conversationData)
    {
        return null;
    }
}
