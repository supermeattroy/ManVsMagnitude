using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class alertText : MonoBehaviour {
	

	private Text someText;
	public string messageText;
	private int lifespan = 5;

	// Use this for initialization
	void Start () {
		someText = GetComponent<Text> ();
		someText.text = messageText;
		Destroy (gameObject, lifespan);
		//put it in the right place
		//maybe flash or be fancy
	}
	
	// Update is called once per frame
	void Update () {
	}
}
