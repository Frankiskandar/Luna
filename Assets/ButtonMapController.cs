using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMapController : MonoBehaviour {

    public Button mapButton;
    public GameObject map;
    bool condition = false;

    // Use this for initialization
    void Start () {

        map = GameObject.Find("Map");
        mapButton = GameObject.Find("ButtonMap").GetComponent<Button>();

        map.SetActive(false);
        mapButton.onClick.AddListener(TaskOnClick);

        //Button btn = mapButton.GetComponent<Button>();
        //btn.onClick.AddListener(delegate { TaskOnClick(); });
	}
	
	// Update is called once per frame
	void Update () {

        
        //mapButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        
       // if (map !=null)
     //   {
        map.SetActive(!condition);
        condition = !condition;
    //    }
        //print("test");
    }

}
