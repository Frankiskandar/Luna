using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocMedController : MonoBehaviour {

    public Button SocMedButton;

    // Use this for initialization
    void Start () {

        SocMedButton = GameObject.Find("ButtonSocMed").GetComponent<Button>();

        SocMedButton.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");

        Application.OpenURL("https://www.instagram.com/lunalightfestival/");
    }
}
