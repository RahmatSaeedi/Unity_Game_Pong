using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void MoveToScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
