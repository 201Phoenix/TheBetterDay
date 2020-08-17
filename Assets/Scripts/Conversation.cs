using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Conversation : ScriptableObject
{
	public string title;
	[SerializeField]
	public string[] sentences;	
}
