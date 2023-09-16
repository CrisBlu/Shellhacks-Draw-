using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public InputActionReference shootTrigger = null;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform tipOfGun;
    [SerializeField] float bulletSpeed;

    void Awake()
    {
        shootTrigger.action.started += Shooting;
    }


    private void Shooting(InputAction.CallbackContext context){
        Debug.Log("Bang!");
        GameObject thisBullet = Instantiate(bullet, tipOfGun.position, transform.rotation);
        Rigidbody thisBulletRb = thisBullet.GetComponent<Rigidbody>();
        thisBulletRb.velocity = thisBullet.transform.forward * bulletSpeed;
    }
}
