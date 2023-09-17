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
    [SerializeField] float cooldown;
    private bool canFire;

    void Awake()
    {
        canFire = true;
        shootTrigger.action.started += Shooting;
    }


    private void Shooting(InputAction.CallbackContext context){
    
        if (canFire == true)
        {
            GameObject thisBullet = Instantiate(bullet, tipOfGun.position, transform.rotation);
            Rigidbody thisBulletRb = thisBullet.GetComponent<Rigidbody>();
            thisBulletRb.velocity = thisBullet.transform.forward * bulletSpeed;
            
            canFire = false;
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(cooldown);
        canFire = true;
    }
}
