using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
