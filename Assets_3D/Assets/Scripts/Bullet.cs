using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float lifeTime = 10f;

        private void Awake() {
        Destroy(gameObject, lifeTime);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.name.Contains("TonneauPrefab")) {
            Destroy(gameObject);
            collision.collider.GetComponent<Tonneau>().Hit();        
        }
    }

}
