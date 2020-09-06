using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstButtonClicked : MonoBehaviour
{
	public Button yourButton;
	public GameObject choosingCanvas;
	public Button testButton;


	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		Button btn2 = testButton.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClickTest);
	}

	void TaskOnClick()
	{
		Debug.Log("CHOOSING BUTTON PRESSED");
        if (choosingCanvas.activeSelf)
        {
			choosingCanvas.SetActive(false);
		}
        else
        {
			choosingCanvas.SetActive(true);
		}
		
	}

	void TaskOnClickTest()
    {
		Debug.Log("JA HAST GEDRÜCKT");
    }

	// Update is called once per frame
	void Update()
    {
        
    }
}
