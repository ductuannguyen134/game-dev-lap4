using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    int i;
    int a;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        a = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        if(gameObject.tag == "Red" && i == 100) {
            gameObject.SetActive(false);
        } else if (gameObject.tag == "Blue" && i == a){
            rend.enabled = false;
        }
        Debug.Log($"{gameObject.name}:{i}");
    }
}
