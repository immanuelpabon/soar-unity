using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float moveSpeed = 15.0f;


    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            projectile.velocity = new Vector2(0, -1) * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D col) // hit ditection
    {
        if (col.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("lose");
            col.gameObject.SetActive(false);
        }
        if (col.gameObject.name == "Bottom")
        {
            col.gameObject.SetActive(false);
        }
    }
}
