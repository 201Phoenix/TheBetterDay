using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private ConversationManager _conversationManager;
    
    [SerializeField]
    private Conversation conversation;
    void Start()
    {
        _conversationManager = FindObjectOfType<ConversationManager>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCoversation()
    {
            
    }
    
}
