﻿using UnityEngine;
using System.Collections;

public static class CameraShake {

    static public IEnumerator Shake(float duration, float magnitude)
    { 
        float elapsed = 0.0f;

        Vector3 originalCamPos = Camera.main.transform.position;

        while (elapsed < duration) {

            elapsed += Time.deltaTime;

            float percentComplete = elapsed / duration;
            float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);

            // map value to [-1, 1]
            float x = Random.value * 2.0f - 1.0f;
            float z = Random.value * 2.0f - 1.0f;
            x *= magnitude * damper;
            z *= magnitude * damper;

            Camera.main.transform.position = new Vector3(x, originalCamPos.y, z);

            yield return null;
        }

        Camera.main.transform.position = originalCamPos;
    }

}
