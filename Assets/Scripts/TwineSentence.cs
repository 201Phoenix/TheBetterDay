using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwineSentence
{
    private string _character;
    private string _text;

    public TwineSentence(string character, string text)
    {
        _character = character;
        _text = text;
    }

    public override string ToString()
    {
        return $"{nameof(Character)}: {Character}, {nameof(Text)}: {Text}";
    }

    public string Character
    {
        get => _character;
        set => _character = value;
    }

    public string Text
    {
        get => _text;
        set => _text = value;
    }
}
