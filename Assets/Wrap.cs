using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    void Update()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        Vector3 moveAnjustment = Vector3.zero;
        if (viewportPosition.x < 0)
        {
            moveAnjustment.x += 1;
        }
        else if (viewportPosition.x > 1)
        {
            moveAnjustment.x -= 1;
        }
        else if (viewportPosition.y < 0)
        {
            moveAnjustment.y += 1;
        }
        else if (viewportPosition.y > 1)
        {
            moveAnjustment.y -= 1;
        }

        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition + moveAnjustment);
    }
}
