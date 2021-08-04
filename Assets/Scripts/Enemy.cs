using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Sprite HurtEnemy;
    public Sprite DeadEnemy;
    public Rigidbody2D enemy; //creating rigidbody for itself

    public float moveSpeed = 15.0f;

    public bool changeDirection;
    public int check = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
        if (check == 20)
        {
           this.gameObject.GetComponent<SpriteRenderer>().sprite = HurtEnemy;
        }
        if (check == 40)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DeadEnemy;
        }
    }

    public void moveEnemy()
    {
        if (changeDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        }
        else if (changeDirection == false)
        {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Right wall")
        {
         
            changeDirection = true;
        }
        if (col.gameObject.name == "Left wall")
        {
           
            changeDirection = false;
        }
        if (col.gameObject.name == "PlayerProjectile(Clone)")
        {
            col.gameObject.SetActive(false);

            check += 1;
        }
    }
}
