using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGap : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // add score if player leaves pipe gap
            ScoreCounter.score++;
        }
    }
}
