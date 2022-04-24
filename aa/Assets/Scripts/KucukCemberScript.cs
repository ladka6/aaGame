using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberScript : MonoBehaviour
{
    Rigidbody2D fizik;

    public float hiz;
    bool hareketKontrol = false;

    GameObject oyunYoneticisi; 
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "donenCemberTag")
        {
            transform.SetParent(collision.transform);
            hareketKontrol = true;
        }
        if (collision.tag == "kucukCemberTag")
        {
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    }
}
