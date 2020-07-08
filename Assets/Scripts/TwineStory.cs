using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwineStory
{
    private Dictionary<string, TwineConversation> _conversations;
    
    private TwineStory() {}

    private static readonly string REGEX = "";
    public TwineStory Parse(string storyData)
    {
        var conversationData= storyData.Split(new string[]
        {
            "::"
        }, StringSplitOptions.None);
        
        Debug.Log(conversationData);
        return null;
    }
    
    
}
