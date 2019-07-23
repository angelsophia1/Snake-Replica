using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnDestroy()
    {
        if (!GameManager.isGameOver)
        {
            FindObjectOfType<SpawnFood>().Spawn();
        }
    }

}
