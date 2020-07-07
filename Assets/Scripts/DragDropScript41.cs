using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropScript41 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;

    public GameObject toActivatepil;
    public GameObject toActivateampul;
    public GameObject toActivatepanel;



    public GameObject toActivatekablo;
    public GameObject toActivateanahtar;

    public GameObject Kontrolpil;
    public GameObject Kontrolampul;
    public GameObject Kontrolkablo;
    public GameObject Kontrolanahtar;

    public GameObject Olumlu1Panel;
    public GameObject Olumsuz1Panel;
    public GameObject Olumlu1Buton;
    public GameObject Olumsuz1Buton;

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

    }

    void OnMouseUp()
    {
        if (!inTheChart)
        {

            this.transform.position = firstPosition;


        }
        else
        {
            Debug.Log("icerde");
            Debug.Log(this.gameObject.name.ToString());



            if (firstObject.gameObject.name == "pil")
            {
                firstObject.gameObject.SetActive(false);

                toActivatepil.SetActive(true);

                Debug.Log("pil gösterim aktif");

            }
            if (firstObject == GameObject.Find("kablo"))
            {
                this.gameObject.SetActive(false);
                toActivatepanel.SetActive(true);
                toActivatekablo.gameObject.SetActive(true);
                

                Debug.Log("kablo gösterim aktif");

            }
            if (firstObject == GameObject.Find("anahtar"))
            {
                this.gameObject.SetActive(false);


                toActivateanahtar.gameObject.SetActive(true);


                Debug.Log("anahtar gösterim aktif");

            }
            if (firstObject == GameObject.Find("ampul"))
            {    

                toActivateampul.gameObject.SetActive(true);

                
                this.gameObject.SetActive(false);
                Debug.Log("ampul gösterim aktif");


            }

        }

        Debug.Log(this.name + " objesi bırakıldı.");

    }

    public void KontrolEt()
    {
        if(Kontrolpil.gameObject.activeInHierarchy == false && Kontrolampul.gameObject.activeInHierarchy == false && Kontrolanahtar.gameObject.activeInHierarchy == false && Kontrolkablo.gameObject.activeInHierarchy == false)
        {
            Olumlu1Panel.SetActive(true);
            Olumlu1Buton.SetActive(true);

        }
         else
        {
            Olumsuz1Panel.SetActive(true);
            Olumsuz1Buton.SetActive(true);
        }
    }

    bool inTheChart = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        inTheChart = true;



    }


    void OnTriggerExit2D(Collider2D collision)
    {

        inTheChart = false;
    }
}
