using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LeftSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector director;
    public GameObject choice;
    public GameObject dialouge;
    void Start()
    {
        director.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (director.state.Equals(UnityEngine.Playables.PlayState.Paused))
        {
            choice.SetActive(true);
            dialouge.SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
