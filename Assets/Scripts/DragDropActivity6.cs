using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragDropActivity6 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;
    public bool ColliderInside = false;

    public bool icindepil1;
    public bool icindepil2;
    public bool icindepil3;
    public bool icindepil4;
    public bool icindepil5;
    public bool icindepil6;
 

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
         if(!icerdemi)
        {

            this.transform.position = firstPosition;


        }
        else
        {

        icindepil1 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil1")
        {
            icindepil1 = true;
            ColliderInside = true;

        }
        
        icindepil2 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil2")
        {
            icindepil2 = true;
            ColliderInside = true;
        }
        icindepil3 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil3")
        {
            icindepil3 = true;
            ColliderInside = true;
        }
        icindepil4 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil4")
        {
            icindepil4 = true;
            ColliderInside = true;
        }
        icindepil5 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil5")
        {
            icindepil5 = true;
            ColliderInside = true;
        }
        icindepil6 = false;
        if (icindeoldugumobje.tag == "yuva" && this.tag == "pil6")
        {
            icindepil6 = true;
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
        icindepil1 = false;
        icindepil2 = false;
        icindepil3 = false;
        icindepil4 = false;
        icindepil5 = false;
        icindepil6 = false;
       

        icerdemi = false;
    }                   

}
