using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    // public PlayableDirector playableTimeline;
    public GameObject character;
    public GameObject timeline;

    void Start()
    {
        StartCoroutine(delayTime());
    }

    // Update is called once per frame
    void Update()
    {
        
       // playableTimeline.Stop();
    }
    IEnumerator delayTime()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("called");
        // playableTimeline.Stop();
        timeline.SetActive(true);
        character.SetActive(true);
    }
}
