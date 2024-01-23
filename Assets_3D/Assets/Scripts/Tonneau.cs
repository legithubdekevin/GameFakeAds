using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tonneau : MonoBehaviour {
    private int HP; 
    private TextMeshProUGUI hpTextMesh;

    private void Start() {
        hpTextMesh = GetComponentInChildren<TextMeshProUGUI>();

        if (hpTextMesh != null) {
            UpdateHPText();
        }
    }
    private void UpdateHPText() {
        if (hpTextMesh != null) {
            hpTextMesh.text = HP.ToString();
            hpTextMesh.transform.LookAt(Camera.main.transform);
        }
    }
    public void SetHP(int HP) {
        this.HP = HP;
    }
    public int GetHP() { return this.HP; }

    public void Hit() {
        HP--;
        UpdateHPText();
        if (HP <= 0) { Die(); }
    }
    public void Die() {
        Destroy(gameObject);
    }
}
