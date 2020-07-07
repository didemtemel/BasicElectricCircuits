using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropActivity5 : MonoBehaviour
{
     Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;
    public bool ColliderInside = false;

    public bool icindedevre1;
    public bool icindedevre2;
    public bool icindedevre3;
    public bool icindedevre4;
    public bool icindedevre5;
    public bool icindedevre6;
    public bool icindedevre7;
    public bool icindedevre8;

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
        
         Debug.Log("drag");

    }


    private void OnMouseUp()
    {
         if(!icerdemi)
        {
            Debug.Log("icerde değil");

            this.transform.position = firstPosition;


        }
        if (icerdemi)
        {
            Debug.Log("icerde");
            Debug.Log(this.gameObject.name.ToString());


            icindedevre1 = false;
            if (icindeoldugumobje.tag == "s" && this.tag == "devre1")
            {
                icindedevre1 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre1")
            {
                icindedevre1 = false;
                ColliderInside = true;
            }
                if (icindeoldugumobje.tag == "p" && this.tag == "devre1")
            {
                icindedevre1 = false;
                ColliderInside = true;
            }



            icindedevre2 = false;
            if (icindeoldugumobje.tag == "s" && this.tag == "devre2")
            {
                icindedevre2 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre2")
            {
                icindedevre2 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "p" && this.tag == "devre2")
            {
                icindedevre2 = false;
                ColliderInside = true;
            }


            icindedevre3 = false;
            if (icindeoldugumobje.tag == "s" && this.tag == "devre3")
            {
                icindedevre3 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre3")
            {
                icindedevre3 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "p" && this.tag == "devre3")
            {
                icindedevre3 = false;
                ColliderInside = true;
            }





            icindedevre4 = false;
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre4")
            {
                icindedevre4 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "s" && this.tag == "devre4")
            {
                icindedevre4 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "p" && this.tag == "devre4")
            {
                icindedevre4 = false;
                ColliderInside = true;
            }



            icindedevre5 = false;
            if (icindeoldugumobje.tag == "p" && this.tag == "devre5")
            {
                icindedevre5 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre5")
            {
                icindedevre5 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "s" && this.tag == "devre5")
            {
                icindedevre5 = false;
                ColliderInside = true;
            }






            icindedevre6 = false;
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre6")
            {
                icindedevre6 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "s" && this.tag == "devre6")
            {
                icindedevre6 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "p" && this.tag == "devre6")
            {
                icindedevre6 = false;
                ColliderInside = true;
            }



            

            icindedevre7 = false;
            if (icindeoldugumobje.tag == "p" && this.tag == "devre7")
            {
                icindedevre7 = true;
                ColliderInside = true;
                Debug.Log(icindedevre7);
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre7")
            {
                icindedevre7 = false;
                ColliderInside = true;
                Debug.Log(icindedevre7);

            }
            if (icindeoldugumobje.tag == "s" && this.tag == "devre7")
            {
                icindedevre7 = false;
                ColliderInside = true;
                Debug.Log(icindedevre7);

            }


            

            icindedevre8 = false;
            if (icindeoldugumobje.tag == "s" && this.tag == "devre8")
            {
                icindedevre8 = true;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "ps" && this.tag == "devre8")
            {
                icindedevre8 = false;
                ColliderInside = true;
            }
            if (icindeoldugumobje.tag == "p" && this.tag == "devre8")
            {
                icindedevre8 = false;
                ColliderInside = true;
            }
        }
        Debug.Log(this.name + " objesi bırakıldı.");
       
    }



    bool icerdemi = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        icerdemi = true;
        icindeoldugumobje = collision.gameObject;
    }
    GameObject icindeoldugumobje = null;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (icindeoldugumobje == collision.gameObject)
        {
                Debug.Log("exit");

                icerdemi = false;
                icindedevre1 = false;
                icindedevre2 = false;
                icindedevre3 = false;
                icindedevre4 = false;
                icindedevre5 = false;
                icindedevre6 = false;
                icindedevre7 = false;
                icindedevre8 = false;

                icindeoldugumobje = null;
        }                   
                
                

    }


}
