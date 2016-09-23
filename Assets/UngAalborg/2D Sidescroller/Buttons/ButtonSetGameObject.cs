using UnityEngine;
using System.Collections;

public class ButtonSetGameObject : MonoBehaviour
{

    public bool SetGameObjectTo;

    public void SetGameObject(GameObject obj)
    {
        obj.SetActive(SetGameObjectTo);
    }
}
