using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropActivity9 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;

    public bool Volt6;
    public bool Volt12;
    public bool Volt25;
    public bool Amper2;
    public bool Amper3;
    public bool Amper5;



    void Start()
    {
        firstPosition = this.transform.position;
        firstRatation = this.transform.rotation;
        firstObject = this.gameObject;


    }

    void Update()
    {

    }

    void OnMouseDown()
    {

        Debug.Log(this.name.ToString() + " objesine tıklandı.");

    }

    void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
        Debug.Log("drag");

    }

    void OnMouseUp()
    {
        if (!icerdemi)
        {

            this.transform.position = firstPosition;


        }
        if (icerdemi)
        {
            Debug.Log("icerde");
            Debug.Log(this.gameObject.name.ToString());


            Volt6 = false;
            if (firstObject == GameObject.Find("pil_0") && icindeoldugumobje.tag == "alan1")
            {
               
                Volt6 = true;
            }
            Amper2 = false;
            if (firstObject == GameObject.Find("pil_0") && icindeoldugumobje.tag == "alan2")
            {
               
                Amper2 = true;
            }

            Volt12 = false;
            if (firstObject == GameObject.Find("pil_1") && icindeoldugumobje.tag == "alan1")
            {
               
                Volt12 = true;

            }

            Amper3 = false;
            if (firstObject == GameObject.Find("pil_1") && icindeoldugumobje.tag == "alan2")
            {
               
                Amper3 = true;
            }


            Volt25 = false;
            if (firstObject == GameObject.Find("pil_2") && icindeoldugumobje.tag == "alan1")
            {
               
                Volt25 = true;

            }

            Amper5 = false;
            if (firstObject == GameObject.Find("pil_2") && icindeoldugumobje.tag == "alan2")
            {
               
                Amper5 = true;
            }
            Debug.Log(icindeoldugumobje.tag + " objesinin içinde");
           
        }

        Debug.Log(this.name + " objesi bırakıldı.");

    }

    

    bool icerdemi = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        icerdemi = true;
        Debug.Log("girdigim obje:" + collision.gameObject);
        icindeoldugumobje = collision.gameObject;

    }

    GameObject icindeoldugumobje=null;
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("çıktı");


        icerdemi = false;
        Amper2 = false;
        Amper3 = false;
        Amper5 = false;
        Volt12 = false;
        Volt25 = false;
        Volt6 = false;
        icindeoldugumobje = null;
    }
}