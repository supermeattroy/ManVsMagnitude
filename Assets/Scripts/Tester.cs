using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {
	
	public Transform lert;
	// Use this for initialization
	void Start () {
		for (int i=0; i<5; i++) {
			Instantiate(lert,new Vector3((float)i,(float)i),Quaternion.identity);
			//lert.SetParent(TwitchIrcExample,false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
