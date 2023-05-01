using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swicher : MonoBehaviour
{
    public string x;
 
    public void LoadLevel()
    {
        SceneManager.LoadScene(x);
    }

}
