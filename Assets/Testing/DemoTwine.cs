using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTwine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextAsset _textAsset;
    void Start()
    {
        TwineStory story = TwineStory.Parse(_textAsset.text);
        Debug.Log(story.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
