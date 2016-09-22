using UnityEngine;
using System.Collections;

public class ScoreDisplayFromTimer : MonoBehaviour 
{

	public string NavnFraGemtScore;
	public string ScorePrefix = "Din tid i bane... ";
	public UnityEngine.UI.Text TextHvorDetSkalVises;

	// Use this for initialization
	void Start () 
	{

		TextHvorDetSkalVises.text = ScorePrefix + (PlayerPrefs.GetFloat (NavnFraGemtScore).ToString("##.##"));
	
	}
	

}
