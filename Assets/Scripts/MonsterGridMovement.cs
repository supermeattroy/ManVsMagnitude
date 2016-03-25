using UnityEngine;
using System.Collections;

public class MonsterGridMovement : MonoBehaviour
{

    public GridManager gm;
    int facing = 0;                 //direction the monster is currently facing

    public int x = 5;               //Starting coordinates
    public int y = 5;                       
    
    public float shake_duration = 1f;               //Screen Shake variables
    public float shake_magnitude = 1f;


    void Start()
    {
        transform.position = gm.Find(x, y);
    }

    public void Command(int i)
    {
        switch (i) {                //switch case for different inputs
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

    public void Step()              //Shared effects between all steps
    {
        gm.Smash(x, y);
        StartCoroutine(CameraShake.Shake(shake_duration, shake_magnitude));
    }

    public void Up()
    {
        if(y<9) y += 1;
        transform.position = gm.Find(x, y);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        facing = 0;
        Step();
    }

    public void Down()
    {
        if (y > 0) y -= 1;
        transform.position = gm.Find(x, y);
        transform.rotation = Quaternion.Euler(0, 180, 0);
        facing = 1;
        Step();
    }

    public void Left()
    {
        if (x > 0) x -= 1;
        transform.position = gm.Find(x, y);
        transform.rotation = Quaternion.Euler(0, -90, 0);
        facing = 2;
        Step();
    }

    public void Right()
    {
        if (x < 9) x += 1;
        transform.position = gm.Find(x, y);
        transform.rotation = Quaternion.Euler(0, 90, 0);
        facing = 3;
        Step();
    }

    public void Special()
    {
        switch(facing) {                    //Destroys 1 block in direction
            case 0: gm.Smash(x, y + 1);
                break;

            case 1: gm.Smash(x, y - 1);
                break;

            case 2: gm.Smash(x - 1, y);
                break;

            case 3: gm.Smash(x + 1, y);
                break;
        }
    }
}
