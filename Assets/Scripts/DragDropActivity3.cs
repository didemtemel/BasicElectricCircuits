using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropActivity3 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;
    public bool ColliderInside = false;
    public bool Col1Devre1 = false;
    public bool Col2Devre1 = false;
    public bool Col3Devre1 = false;
    public bool Col1Devre2 = false;
    public bool Col2Devre2 = false;
    public bool Col3Devre2 = false;
    public bool Col1Devre3 = false;
    public bool Col2Devre3 = false;
    public bool Col3Devre3 = false;


    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position;
        firstRatation = this.transform.rotation;
        firstObject = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        Debug.Log(this.name + " objesine tıklandı.");

    }

    private void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);

    }


    private void OnMouseUp()
    {

        if (!icerdemi)
        {
            this.transform.position = firstPosition;
            Debug.Log("içeride değil");
        }
        
        if (icerdemi)
        {
            if(icindeoldugumobje.tag == "col1" && this.tag == "devre1")
            {
                Col1Devre1 = true;
            }
            if(icindeoldugumobje.tag == "col2" && this.tag == "devre1")
            {
                Col2Devre1 = true;
            }
            if(icindeoldugumobje.tag == "col3" && this.tag == "devre1")
            {
                Col3Devre1 = true;
            }


            if(icindeoldugumobje.tag == "col1" && this.tag == "devre2")
            {
                Col1Devre2 = true;
            }
            if(icindeoldugumobje.tag == "col2" && this.tag == "devre2")
            {
                Col2Devre2 = true;
            }
            if(icindeoldugumobje.tag == "col3" && this.tag == "devre2")
            {
                Col3Devre2 = true;
            }




            if(icindeoldugumobje.tag == "col1" && this.tag == "devre3")
            {
                Col1Devre3 = true;
            }
            if(icindeoldugumobje.tag == "col2" && this.tag == "devre3")
            {
                Col2Devre3 = true;
            }
            if(icindeoldugumobje.tag == "col3" && this.tag == "devre3")
            {
                Col3Devre3 = true;
            }

            Debug.Log(icindeoldugumobje.tag + " objesinin içinde");

        }

        Debug.Log(this.tag + " objesi bırakıldı.");


    }



    bool icerdemi = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        icerdemi = true;
        icindeoldugumobje = collision.gameObject;
        Debug.Log(" trigger " + icindeoldugumobje.tag);
    }
    GameObject icindeoldugumobje = null;
    private void OnTriggerExit2D(Collider2D collision)
    {

    if (icindeoldugumobje == collision.gameObject)
        {

            icerdemi = false;
            Col1Devre1 = false;
            Col1Devre2 = false;
            Col2Devre1 = false;
            Col2Devre2 = false;
            Col2Devre3 = false;
            Col3Devre3 = false;
            Col3Devre1 = false;
            Col3Devre2 = false;
            Col1Devre3 = false;
            
            icindeoldugumobje = null;
        }
    }
}
