using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI zamanText, patlamaText;
    public GameObject patlama;
    public float zamanSayaci = 60;
    int patlayanMeteor = 0;
    public GameObject endPanel;
    void Start()
    {
        patlamaText.text = "" + patlayanMeteor;
    }

    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "" + (int)zamanSayaci;
            
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("meteor");
            endPanel.SetActive(true);
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
    }
    public void addMeteor()
    {
        patlayanMeteor += 1;
        patlamaText.text = "" + patlayanMeteor;
    }
}
