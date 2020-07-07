using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragDropActivity1 : MonoBehaviour
{
    Vector3 firstPosition;
    Quaternion firstRatation;
    GameObject firstObject;

    public bool inTheChartAmpul;
    public bool inTheChartAmper;
    public bool inTheChartPil;
    public bool inTheChartVolt;
    public bool inTheChartAnahtar;
    public bool inTheChartKablo;
    public bool inTheChartInd;

    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position;
        firstRatation = this.transform.rotation;
        firstObject = this.gameObject;

    
    }

void OnMouseDown()
    {

        Debug.Log(this.name + " objesine tıklandı.");

    }

    void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);

    }

    void OnMouseUp()
    {
        if(!inTheChart)
        {

            this.transform.position = firstPosition;
            

        }
        else
        {
            inTheChartPil = false;
            if (firstObject.gameObject.tag == "pil")
            {
                inTheChartPil = true;
                
            }
            inTheChartInd = false;
            if (firstObject.gameObject.tag == "ind")
            {
                inTheChartInd = true;
                
            }

            inTheChartAmper = false;
            if (firstObject.gameObject.tag == "ampermetre")
            {
                inTheChartAmper = true;

            }
            
            inTheChartKablo = false;
            if (firstObject.gameObject.tag == "kablo")
            {
                inTheChartKablo = true;

            }

            inTheChartAnahtar = false;
            if (firstObject.gameObject.tag == "anahtar")
            {
                inTheChartAnahtar = true;

            }
            
            inTheChartAmpul = false;
            if (firstObject.gameObject.tag == "ampul")
            {
                inTheChartAmpul = true;

            }

            inTheChartVolt = false;
            if (firstObject.gameObject.tag == "voltmetre")
            {
                inTheChartVolt = true;

            }

            GameObject newObject;
            newObject = Instantiate(firstObject, firstPosition, firstRatation);
        }

        Debug.Log(this.name + " objesi bırakıldı.");

    }


    
    bool inTheChart = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        inTheChart = true;



    }

        void OnTriggerExit2D(Collider2D collision)
    {

        inTheChart = false;
        inTheChartKablo = false;
        inTheChartAmper = false;
        inTheChartAmpul = false;
        inTheChartAnahtar = false;
        inTheChartVolt = false;
        inTheChartInd = false;
    }


}
