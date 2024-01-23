using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int bulletSpeed = 10;
    [SerializeField] private int damage = 60;

    private Vector3 test;
    private void Start() {
        InvokeRepeating("Shoot", 0f, 1f / (float)(damage));
    }
    private void Awake() {
    }
    private void Update() {

    }

    public void Shoot() {
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        //Debug.Log(bulletSpawn.position);
        //Debug.Log(bulletSpawn.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();  
        bulletRb.AddForce(bullet.transform.forward * bulletSpeed);
        //Debug.Log(bulletRb.velocity);

    }

}
