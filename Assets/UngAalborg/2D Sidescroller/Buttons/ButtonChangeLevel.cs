using UnityEngine;
using System.Collections;

public class ButtonChangeLevel : MonoBehaviour {

	public void ChangeLevelTo(string LevelName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
    }
}
