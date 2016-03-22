using UnityEngine;
using System.Collections;

public class MonsterMovementHolder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(2.5f, 0f, 2.5f);
	}
	
	public void Up()
    {
        transform.Translate(new Vector3(0f, 0f, 5f));
    }

    public void Down()
    {
        transform.Translate(new Vector3(0f, 0f, -5f));
    }

    public void Left()
    {
        transform.Translate(new Vector3(-5f, 0f, 0f));
    }

    public void Right()
    {
        transform.Translate(new Vector3(5f, 0f, 0f));
    }
}
