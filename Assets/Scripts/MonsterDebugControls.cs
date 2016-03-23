using UnityEngine;
using System.Collections;

public class MonsterDebugControls : MonoBehaviour {

    //public MonsterMovementHolder monster;
    public MonsterGridMovement monster;
    public bool direct = false;
    public CommandBuffer cb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (direct) {
            if (Input.GetKeyDown(KeyCode.UpArrow)) monster.Up();
            if (Input.GetKeyDown(KeyCode.DownArrow)) monster.Down();
            if (Input.GetKeyDown(KeyCode.LeftArrow)) monster.Left();
            if (Input.GetKeyDown(KeyCode.RightArrow)) monster.Right();
        } else {
            if (Input.GetKeyDown(KeyCode.UpArrow)) cb.Input(0);
            if (Input.GetKeyDown(KeyCode.DownArrow)) cb.Input(1);
            if (Input.GetKeyDown(KeyCode.LeftArrow)) cb.Input(2);
            if (Input.GetKeyDown(KeyCode.RightArrow)) cb.Input(3);
            if (Input.GetKeyDown(KeyCode.Space)) cb.Input(4);
        }
    }
}
