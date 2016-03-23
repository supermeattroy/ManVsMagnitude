using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CommandBuffer : MonoBehaviour {

	public int threshold = 5;
	public MonsterGridMovement monster;

	public int [] moveBuffers = new int[4];
    public Slider[] directionalSliders = new Slider[4];

	public void Input(int i) {
		moveBuffers [i]++;
		if (moveBuffers[i] >= threshold) {
			monster.Command(i);
			moveBuffers[i] = 0;
		}

        directionalSliders[i].value = moveBuffers[i];
    }
}