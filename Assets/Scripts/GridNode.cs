using UnityEngine;
using System.Collections;

public class GridNode : MonoBehaviour {

    public int x, y;
    GridNode[] adjacent = new GridNode[4];
    GridManager gm;
    public bool hasBase;
    GameObject pBase;

	void Start () {
        gm = GetComponentInParent<GridManager>();

        try { adjacent[0] = gm.FindNode(x, y + 1); }
        catch { adjacent[0] = null; }

        try { adjacent[1] = gm.FindNode(x, y - 1); }
        catch { adjacent[0] = null; }

        try { adjacent[2] = gm.FindNode(x - 1, y); }
        catch { adjacent[0] = null; }

        try { adjacent[3] = gm.FindNode(x + 1, y); }
        catch { adjacent[0] = null; }
        
        if (hasBase) pBase = Instantiate(Resources.Load("Prefabs/PlayerBase", typeof(GameObject)), transform.position, transform.rotation) as GameObject;
    }
	
	void Update () {
        bool inRange = false;
	    foreach(GridNode node in adjacent) {
            if ((node != null) && (node.hasBase)) inRange = true;
        }

        if(inRange) GetComponent<Renderer>().material.color = Color.red;
        else GetComponent<Renderer>().material.color = Color.white;
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
        Destroy(pBase);
        hasBase = false;
    }
}
