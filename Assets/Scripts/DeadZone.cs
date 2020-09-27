using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colission");
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
    }
}
