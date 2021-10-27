using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenechangetrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(1);
    }
}
