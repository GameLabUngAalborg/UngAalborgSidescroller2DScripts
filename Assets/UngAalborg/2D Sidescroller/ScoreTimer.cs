using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour {

	public string ScoreNavnAtGemmeTil;
	public Text ScoreText;
	public string PreFix = "Din tid: ";
	private float counter;

	// Update is called once per frame
	void Update () 
	{
	
		counter += Time.deltaTime;

		if (ScoreText == true)
		{
			ScoreText.text = PreFix + counter.ToString ("##.###");
		}


	}

	// Når du disabler objektet, så bliver scoren gemt. 
	void OnDisable()
	{
		print ("ScoreTimer bliver disabled");

		if (ScoreText == true)
		{
			ScoreText.text = PreFix + counter.ToString ("##.###");
		}

		if (PlayerPrefs.GetFloat (ScoreNavnAtGemmeTil) > counter || PlayerPrefs.GetFloat(ScoreNavnAtGemmeTil) == 0) 
		{
			// Gemmer kun tiden til harddisken hvis den er hurtigere end den tidligere
			PlayerPrefs.SetFloat (ScoreNavnAtGemmeTil, counter);
			print ("Gemt score under " + ScoreNavnAtGemmeTil);

		}
	}
}
