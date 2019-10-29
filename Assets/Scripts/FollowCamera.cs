using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public float xOffset = 0f;
    public float yOffset = 0f;
    public Transform player;

    private void LateUpdate()
    {
        this.transform.position = new Vector3(player.transform.position.x + xOffset,player.transform.position.y + yOffset, -10);
    }
}
