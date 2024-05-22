using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    Player player;

    public GameObject bloodParticle;
    bool inactive = false;
    void Start()
    {
        player=FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,player.transform.position,speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (inactive == false)
        {

            if (collision.tag == "Hole")
            {
                player.AddScore();
                Destroy(Instantiate(bloodParticle, transform.position, Quaternion.identity), 1f);
                //Destroy(collision.gameObject);
                Destroy(gameObject);

            }
            if (collision.tag == "Player" || collision.tag == "Enemy")
            {
                player.TakeDamage();
                Destroy(gameObject);
                speed = 0;
                transform.parent = player.transform;
            }

            inactive = true;
        }
    }
 

}
