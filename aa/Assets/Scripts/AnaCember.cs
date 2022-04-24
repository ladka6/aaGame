using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    GameObject oyunYoneticisi;
    public GameObject kucukCember;
    // Start is called before the first frame update
    void Start()
    {
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        oyunYoneticisi.GetComponent<OyunYoneticisi>().KucukCemberlerdeTextGosterme();
    }
}
