using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public GameObject followTarget;

    private void Update()
    {
        if (followTarget == null)
        {
            return;
        }
        Vector3 newPosition = new Vector3(followTarget.transform.position.x + 6f, 0f, -10f);
        this.transform.position = newPosition;
    }
}
