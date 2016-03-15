using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {
    enum BuildState{PREBUILD, BUILDING, PAUSED, COMPLETED, DAMAGED};

    BuildState mBuildState;
    BoxCollider mCollider;
    public float mBuildTime = 10;
    float timeUntilBuilt;
    int collCounter = 0;

    Building(Vector3 Position)
    {
        transform.position = Position;
        mBuildState = BuildState.PREBUILD;
    }


	// Use this for initialization
	void Start () {
        mCollider = GetComponent<BoxCollider>();
        mBuildState = BuildState.PREBUILD;
        Color color = GetComponent<MeshRenderer>().material.color;
        color.b = 1.0f;
        GetComponent<MeshRenderer>().material.SetColor("_Albedo", color);
        Debug.Log("Should see blue box now");
        timeUntilBuilt = mBuildTime;
	}
	
	// Update is called once per frame
	void Update () {
        switch(mBuildState){
            case (BuildState.PREBUILD):
                Debug.Log("Prebuild");
                if (true || CanBuildHere()){
                    mBuildState = BuildState.BUILDING;
                    Color color = GetComponent<MeshRenderer>().material.color;
                    color.r = 1.0f;
                    color.a = 0.5f;
                    GetComponent<MeshRenderer>().material.color = color;
                }
                break;
            case (BuildState.BUILDING):
                Debug.Log("Building");
                Build(Time.deltaTime);
                break;
            case (BuildState.PAUSED): // TODO
                break;
            case (BuildState.COMPLETED): // TODO
                Debug.Log("Building Completed");
                break;
            case (BuildState.DAMAGED): //TODO
                break;
            default:
                break;
        };
            
	}

    bool CanBuildHere(){
        if (mCollider != null && collCounter == 0)
        {
            return true;
        }
        return false;
    }

    void Build(float deltaTime) //enables collisions 
    {
        if (timeUntilBuilt == mBuildTime){
            BoxCollider bc = GetComponent<BoxCollider>();
            if (bc)
            {
                bc.isTrigger = false;
            }
        }
        timeUntilBuilt -= deltaTime;
        if (timeUntilBuilt <= float.Epsilon)
        {
            mBuildState = BuildState.COMPLETED;
            Color color = GetComponent<MeshRenderer>().material.color;
            color.a = 1f;
            GetComponent<MeshRenderer>().material.color = color;
        }
    }

    void OnTriggerEnter(Collider other){
        collCounter++;
    }
    void OnTriggerExit(Collider other)
    {
        collCounter--;
    }
}
