using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public float distanceBetweenPipes = 4f;
    public int numberOfPipes = 100;
    public GameObject pipeReference;
    public GameObject pipesParent;

    private void Start()
    {
        SpawnNewPipes();
    }

    private void SpawnNewPipes()
    {
        for (float newX = 0f; newX <= distanceBetweenPipes * numberOfPipes; newX += distanceBetweenPipes)
        {
            int newY = Random.Range(-2, 3);
            Vector3 newPipePos = new Vector3(newX, newY);

            Instantiate(pipeReference, newPipePos, Quaternion.identity, pipesParent.transform);
        }
    }

}
