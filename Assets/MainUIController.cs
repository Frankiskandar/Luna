using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using Vuforia;

public class MainUIController : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour; 
    private GameObject mainCanvas; //main canvas UI
    //public GameObject map;
    //private GameObject button_vis_artist;
    //private GameObject button_socmed;
    //private GameObject button_map;

    // Use this for initialization
    void Start()
    {

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        mainCanvas = GameObject.Find("MainUI");

       // map = GameObject.Find("Map");

        //set default states of UI 
        mainCanvas.SetActive(false);
        //mainCanvas.transform.parent.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            // if image target is being tracked
            ShowUI();
        }
        else
        {
            HideUI();
        }
    }

    public void ShowUI()
    {

        //enable UI
        mainCanvas.SetActive(true);
        //mainCanvas.transform.parent.gameObject.SetActive(true);

        //subtitle_obj.GetComponent<Text>().text = text;
    }

    public void HideUI()
    {
        //disable UI
        if (mainCanvas != null)
        {
            mainCanvas.SetActive(false);
            //button_artist.transform.parent.gameObject.SetActive(false);
        }
/*
        if (map != null)
        {
            map.SetActive(false);
        }
*/


    }
}
