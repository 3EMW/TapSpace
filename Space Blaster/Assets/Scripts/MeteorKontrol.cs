using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorKontrol : MonoBehaviour
{
    public GameObject patlama;
    GameManager gameManager;
    public AudioClip explosion;

    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        AudioSource.PlayClipAtPoint(explosion,transform.position);
        Destroy(this.gameObject);
        Destroy(go, 0.583f);
        gameManager.addMeteor();
    }
    void Start()
    {
        gameManager = GameObject.Find("_Scripts").GetComponent<GameManager>();
    }
}
