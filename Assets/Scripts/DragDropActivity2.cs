using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropActivity2 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;
    public bool ColliderInside = false;
    public bool inTheChartAmpul = false;
    public bool inTheChartAmper = false;
    public bool inTheChartPil = false;
    public bool inTheChartVolt = false;
    public bool inTheChartAnahtar = false;
    public bool inTheChartKablo = false;
    public bool inTheChartAmpulGosterim = false;
    public bool inTheChartAmperGosterim = false;
    public bool inTheChartPilGosterim = false;
    public bool inTheChartVoltGosterim = false;
    public bool inTheChartAnahtarGosterim = false;
    public bool inTheChartKabloGosterim = false;


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
            Debug.Log(this.name + " içerde değil.");
        }
        
        if (icerdemi)
        {
            if(icindeoldugumobje.tag == "ampulcol" && this.tag == "ampul")
            {
                inTheChartAmpul = true;
                Debug.Log("ampülllllllllllllllllllll:" + inTheChartAmpul);
            }
            if(icindeoldugumobje.tag == "ampulGcol" && this.tag == "ampul")
            {
                inTheChartAmpulGosterim = true;
                Debug.Log("ampüllllllllllllGosterimmmmmmmmmmmmm" + inTheChartAmpulGosterim);

            }



            if(icindeoldugumobje.tag == "pilcol" && this.tag == "pil")
            {
                inTheChartPil = true;
            }
            if(icindeoldugumobje.tag == "pilGcol" && this.tag == "pil")
            {
                inTheChartPilGosterim = true;
            }



            if(icindeoldugumobje.tag == "ampercol" && this.tag == "ampermetre")
            {
                inTheChartAmper = true;
            }
            if(icindeoldugumobje.tag == "amperGcol" && this.tag == "ampermetre")
            {
                inTheChartAmperGosterim = true;
            }


            if(icindeoldugumobje.tag == "anahtarcol" && this.tag == "anahtar")
            {
                inTheChartAnahtar = true;
            }

            if(icindeoldugumobje.tag == "anahtarGcol" && this.tag == "anahtar")
            {
                inTheChartAnahtarGosterim = true;
            }


            if(icindeoldugumobje.tag == "voltcol" && this.tag == "voltmetre")
            {
                inTheChartVolt = true;
            }
            if(icindeoldugumobje.tag == "voltGcol" && this.tag == "voltmetre")
            {
                inTheChartVoltGosterim = true;
            }



            if(icindeoldugumobje.tag == "kablocol" && this.tag == "kablo")
            {
                inTheChartKablo = true;
            }
            if(icindeoldugumobje.tag == "kabloGcol" && this.tag == "kablo")
            {
                inTheChartKabloGosterim = true;
            }

            //GameObject newObject;
            //newObject = Instantiate(firstObject, firstPosition, firstRatation);
        }
       

        Debug.Log(this.name + " objesi bırakıldı.");
        Debug.Log("logggggggggggggggggg"+ inTheChartAnahtar +" "+ inTheChartAnahtarGosterim + 
                " "+ inTheChartKablo +" "+ inTheChartKabloGosterim +" "+ inTheChartVolt + 
                " "+ inTheChartVoltGosterim + " "+ inTheChartAmpul +" "+ inTheChartAmpulGosterim + 
               " "+ inTheChartAmper + " "+ inTheChartAmperGosterim +" "+ inTheChartPilGosterim +" "+ inTheChartPil);

    }


    
    bool icerdemi = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        icerdemi = true;
        icindeoldugumobje = collision.gameObject;

        Debug.Log(this.name + " :enter");

    }
    GameObject icindeoldugumobje = null;

    
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (icindeoldugumobje == collision.gameObject)
            {
                icindeoldugumobje = null;
                icerdemi = false;
                ColliderInside = false;
                
                inTheChartAmper = false;
                inTheChartAmpul = false;
                inTheChartAnahtar = false;
                inTheChartKablo = false;
                inTheChartPil = false;
                inTheChartVolt = false;
                

            }

            Debug.Log(this.name + " :exit");
    }       

}
