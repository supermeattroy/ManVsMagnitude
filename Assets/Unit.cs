using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
    //Stat variables (unique properties for each unit)
    public float moveSpeed = 1.0f;

    //Variables to tweak (for tuning)
    public float stopDistance = 0.2f;

    //Variables to set
    public Vector3 destination;

    //State Variables
    private bool isMoving = false;

    //Components
    public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (isMoving)
        {
            Vector3 toTraverse = (destination - transform.position);
            Vector3 moveForce = moveSpeed * toTraverse.normalized;
            rigidbody.AddForce(moveForce, ForceMode.VelocityChange);
            if (toTraverse.magnitude <= stopDistance)
                isMoving = false;
        }
	}

    public void MoveTo(Vector3 destination)
    {
        this.destination = destination;
        this.destination.y = transform.position.y; //Disable verticality for now
        isMoving = true;
    }
}
