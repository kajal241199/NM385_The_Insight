using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
     public int playerSpeed;
     public void change()
    {   
        transform.position = transform.position+Camera.main.transform.forward*playerSpeed*time.deltatime;
        yield return new waitforsends(3f);    
        UnityEngine.SceneManagement.SceneManager.LoadScene("crater", LoadSceneMode.Single);
    }
}
