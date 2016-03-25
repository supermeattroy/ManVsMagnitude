using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

    public int gridWidth, gridHeight;
    GameObject[,] grid = new GameObject[10,10];

	void Awake () {
	    foreach (Transform child in transform) {            //Get all the grid nodes and store them in array
            int x, y;
            Vector3 holder = child.transform.position;
            holder += new Vector3(22.5f, 0f, 22.5f);
            x = System.Convert.ToInt32(holder.x * .2f);
            y = System.Convert.ToInt32(holder.z * .2f);
            grid[x, y] = child.gameObject;

            child.name = "Node (" + x + ", " + y + ")";     //Label the node and give it coordinates
            child.GetComponent<GridNode>().x = x;
            child.GetComponent<GridNode>().y = y;
        }
	}

    public Vector3 Find(int x, int y)                       //Returns location of node (x, y)
    {
        return grid[x, y].transform.position;
    }

    public void Smash(int x, int y)                         //Sets node (x, y) inactive
    {
        if (!GridBounds(x, y)) return;

        grid[x, y].SetActive(false);
    }

    bool GridBounds(int x, int y)                           //returns false if node (x, y) is beyond grid limits
    {
        if (x < 0) return false;
        if (y < 0) return false;
        if (x >= gridWidth) return false;
        if (y >= gridHeight) return false;

        return true;
    }
}
