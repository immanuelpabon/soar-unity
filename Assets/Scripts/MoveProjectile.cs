using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveProjectile : MonoBehaviour
{ 
    public Rigidbody2D projectile; //reference to a rigidbody2d

    public float moveSpeed = 10.0f; //speed of projectile

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>(); //returns the component rigigbody2d 
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0, 2) * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D col) // hit ditection
    {
        if (col.gameObject.name == "Top")
        {
            col.gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Chaser")
        {
            col.gameObject.SetActive(false);
        }
    }
}