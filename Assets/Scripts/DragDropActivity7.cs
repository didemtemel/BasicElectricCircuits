using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DragDropActivity7 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;

    public GameObject toActivatedevreSeri;
    public GameObject toActivatedevreParalel;
    public GameObject YanlıstoActivatedevreSeri;
    public GameObject YanlıstoActivatedevreParalel;

    public GameObject KyanlısSeriButton;
    public GameObject yanlısSeriButton;
    public GameObject KyanlısParalelButton;
    public GameObject yanlısParalelButton;

    public GameObject KSeriButton;
    public GameObject SeriButton;
    public GameObject KParalelButton;
    public GameObject ParalelButton;

    public bool seriDogru;
    public bool paralelDogru;

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
        if (!icerdemi)
        {

            this.transform.position = firstPosition;


        }
        else
        {
            Debug.Log("icerde");
            Debug.Log(this.gameObject.name.ToString());


            seriDogru = false;
            if (firstObject == GameObject.Find("seri") && icindeoldugumobje.tag == "alan1")
            {
                firstObject.gameObject.SetActive(false);
                yanlısSeriButton.SetActive(true);
                KyanlısSeriButton.SetActive(true);

                YanlıstoActivatedevreSeri.SetActive(true);
                seriDogru = false;

                Debug.Log("seri alan1");

            }
            
            if (firstObject == GameObject.Find("seri") && icindeoldugumobje.tag == "alan2")
            {
                firstObject.gameObject.SetActive(false);

                toActivatedevreSeri.SetActive(true);
                seriDogru = true;
                SeriButton.SetActive(true);
                KSeriButton.SetActive(true);

                Debug.Log("seri alan2");

            }

            paralelDogru = false;
            if (firstObject == GameObject.Find("paralel") && icindeoldugumobje.tag == "alan2")
            {
                this.gameObject.SetActive(false);

                YanlıstoActivatedevreParalel.gameObject.SetActive(true);
                paralelDogru = false;
                yanlısParalelButton.SetActive(true);
                KyanlısParalelButton.SetActive(true);

                Debug.Log("paralel alan2");

            }
            if (firstObject == GameObject.Find("paralel") && icindeoldugumobje.tag == "alan1")
            {
                this.gameObject.SetActive(false);

                toActivatedevreParalel.gameObject.SetActive(true);
                paralelDogru = true;
                ParalelButton.SetActive(true);
                KParalelButton.SetActive(true);

                Debug.Log("paralel alan1");

            }
            Debug.Log("seri:" + seriDogru);
            Debug.Log("paralel:" + paralelDogru);
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
        if (icindeoldugumobje == collision.gameObject)
        {

        icerdemi = false;
        icindeoldugumobje = null;
        
        }


    }
}