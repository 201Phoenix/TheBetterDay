using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwineReponse
{
    private string _text;
    private string _linkedConversation;

    public TwineReponse(string text, string linkedConversation)
    {
        _text = text;
        _linkedConversation = linkedConversation;
    }

    public string Text
    {
        get => _text;
        set => _text = value;
    }

    public string LinkedConversation
    {
        get => _linkedConversation;
        set => _linkedConversation = value;
    }
}
