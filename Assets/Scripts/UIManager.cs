using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int choice=2;
    public GameObject obj;
    public GameObject track2;
    public GameObject track3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void leftButton()
    {
        choice = 0;
        obj.SetActive(false);
        track2.SetActive(true);
    }
    public void rightButton()
    {
        choice = 1;
        obj.SetActive(false);
        track3.SetActive(true);
    }

}
