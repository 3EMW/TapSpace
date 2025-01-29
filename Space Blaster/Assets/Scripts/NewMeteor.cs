using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMeteor : MonoBehaviour
{
    public GameObject meteor;
    float meteorDusmeSuresi = 1f;
    float zamanSayaci = 0f;
    GameManager gkScript;
    void Start()
    {
        gkScript = this.gameObject.GetComponent<GameManager>();
    }

    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int)(gkScript.zamanSayaci / 10) - 6;
        katsayi *= -1;
        if (zamanSayaci < 0 && gkScript.zamanSayaci > 0)
        {
            GameObject go = Instantiate(meteor, new Vector3(Random.Range(1.5f, -1.5f), 6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(-50f * katsayi, -130f * katsayi), 0));
            zamanSayaci = meteorDusmeSuresi;
        }
    }
}
