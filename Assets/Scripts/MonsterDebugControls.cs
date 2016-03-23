﻿using UnityEngine;
using System.Collections;

public class MonsterDebugControls : MonoBehaviour {

    //public MonsterMovementHolder monster;
    public MonsterGridMovement monster;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow)) monster.Up();

        if (Input.GetKeyDown(KeyCode.DownArrow)) monster.Down();

        if (Input.GetKeyDown(KeyCode.LeftArrow)) monster.Left();

        if (Input.GetKeyDown(KeyCode.RightArrow)) monster.Right();

    }
}
