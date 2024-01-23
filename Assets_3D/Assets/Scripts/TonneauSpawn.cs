using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonneauSpawn : MonoBehaviour
{
    [SerializeField] private List<Transform> tonneauSpawner;
    [SerializeField] private GameObject tonneauPrefab;
    private int HP = 10; 

    private void Start() {
        InvokeRepeating("randomSpawn", 0f,1f);
    }

    private void Update() {
        
    }

    private void randomSpawn() {
        Transform randomSpawn = tonneauSpawner[Random.Range(0, tonneauSpawner.Count)];
        GameObject tonneau = Instantiate(tonneauPrefab, randomSpawn.position, randomSpawn.rotation);

        Tonneau tonneauScript = tonneau.GetComponent<Tonneau>();
        if (tonneauScript != null) {
            tonneauScript.SetHP(HP);
        }
        Vector3 test = new Vector3 (0, 0, -1);
        Rigidbody tonneauRb = tonneau.GetComponent<Rigidbody>();
        tonneauRb.AddForce(test * 100000f );
        //Debug.Log(tonneau.transform.forward * 100f);
    }

}
