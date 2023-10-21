using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    public void LoadLevel1Scene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel2()
    {
        //haha, probably not
    }
}

