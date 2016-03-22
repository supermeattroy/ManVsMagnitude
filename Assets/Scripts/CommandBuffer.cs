using UnityEngine;
using System.Collections;

public class CommandBuffer : MonoBehaviour {

	public int threshold = 5;
	//public Monster theMonster;

	public int [] moveBuffers = new int[4];

	public void input(int i) {
		moveBuffers [i]++;
		if (moveBuffers[i] >= threshold) {
			//theMonster.command(i);
			moveBuffers[i] = 0;
		}
	}
}