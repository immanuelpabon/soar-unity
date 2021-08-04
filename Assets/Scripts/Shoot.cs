using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform projectileSpawn;

    public GameObject projectile;

    public float nextFire = 1.0f; // 1 second between firing
    public float currentTime = 0.0f; // increase this time and compare this to determine if you can fire

    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform; //generate projectile
    }

    // Update is called once per frame
    void Update()
    {
        shoot(); //creates shoot funciton
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;// increase fire timer

        if(Input.GetButton("Fire1") && currentTime > nextFire) //when larger than nextfire you fire
        {
            nextFire += currentTime;

            Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //shoot or create the object

            nextFire -= currentTime; // returns so you can count back to 1 second
            currentTime = 0.0f;
        }
    }
}
