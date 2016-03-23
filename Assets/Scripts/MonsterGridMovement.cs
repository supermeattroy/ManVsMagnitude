using UnityEngine;
using System.Collections;

public class MonsterGridMovement : MonoBehaviour
{

    public GridManager gm;
    int x, y;

    // Use this for initialization
    void Start()
    {
        x = y = 5;

        transform.position = gm.Find(x, y);
    }

    public void Command(int i)
    {
        switch (i) {
            case 0: Up();
                    break;

            case 1: Down();
                    break;

            case 2: Left();
                    break;

            case 3: Right();
                    break;

            case 4: Special();
                    break;
        }
    }

    public void Up()
    {
        if(y<9) y += 1;

        transform.position = gm.Find(x, y);
        gm.Smash(x, y);
    }

    public void Down()
    {
        if (y > 0) y -= 1;

        transform.position = gm.Find(x, y);
        gm.Smash(x, y);
    }

    public void Left()
    {
        if (x > 0) x -= 1;

        transform.position = gm.Find(x, y);
        gm.Smash(x, y);
    }

    public void Right()
    {
        if (x < 9) x += 1;

        transform.position = gm.Find(x, y);
        gm.Smash(x, y);
    }

    public void Special()
    {

    }
}
