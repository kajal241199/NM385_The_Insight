using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void change()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("crater", LoadSceneMode.Single);
    }
}