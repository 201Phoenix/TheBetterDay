using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwineStory
{
    
    private Dictionary<string, TwineConversation> _conversations;
    private TwineConversation _startingConversation;
    private const int StartingIndex = 3;
    private static readonly string StartingTag = "start";
    private TwineStory()
    {
        _conversations = new Dictionary<string, TwineConversation>();
    }
    public static TwineStory Parse(string storyData)
    {
        TwineStory twineStory = new TwineStory();
        var conversations= storyData.Split(new string[]
        {
            @"::"
        }, StringSplitOptions.None);

        for (int i = StartingIndex; i <  conversations.Length; ++i)
        {
            TwineConversation twineConversation = TwineConversation.Parse(conversations[i]);
            
            twineStory._conversations.Add(twineConversation.Title, twineConversation);

            if (twineConversation.HasTag(StartingTag))
            {
                twineStory._startingConversation = twineConversation;
            }
        }
        
        return twineStory;
    }

    public TwineConversation GetStartingConversation()
    {
        return _startingConversation;
    }

    public override string ToString()
    {
        return $"{nameof(_conversations)}: {_conversations}, {nameof(_startingConversation)}: {_startingConversation}";
    }
}
