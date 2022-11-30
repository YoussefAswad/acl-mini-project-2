using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingScript : MonoBehaviour
{
    public GameObject manager;
    void Awake()
    {
        int x = manager.GetComponent<UIManager>().choice;
        if (x == 1)
        {
            SceneManager.LoadScene("right");
        }
        else if (x == 0)
        {
            SceneManager.LoadScene("left");
        }
    }
}
