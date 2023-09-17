using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStats : MonoBehaviour
{
    public Transform target;
    public float speed;
    [SerializeField] int damage;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    public bool playedNoise = false;

    void Awake(){
        target =  GameObject.Find("Player").transform;

    }
    void Update() {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        transform.LookAt(target);

        if ((Vector3.Distance(target.position, transform.position) < 10f) && playedNoise == false)
        {
            source.PlayOneShot(clip, 3f);
            playedNoise = true;
        }


    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player"){
            //other.gameObject.GetComponent<TowerCollision>().DamageTower(damage);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Destroy(gameObject);
        }
    }

}
