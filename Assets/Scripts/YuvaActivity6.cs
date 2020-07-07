using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuvaActivity6 : MonoBehaviour
{
    public GameObject pil1;
    public GameObject pil2;
    public GameObject pil3;
    public GameObject pil4;
    public GameObject pil5;
    public GameObject pil6;
    public GameObject v0;
    public GameObject v3;
    public GameObject v6;
    public GameObject v9;
    public GameObject v12;
    public GameObject v15;
    public GameObject v25;
    public GameObject l3;
    public GameObject l6;
    public GameObject l9;
    public GameObject l12;
    public GameObject l15;
    public GameObject l25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void anahtarCalistir()
    {
        if(pil1.GetComponent<DragDropActivity6>().icindepil1 == true)
        {
            v0.SetActive(false);
            v12.SetActive(false);
            l12.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);

            v3.SetActive(true);
            l3.SetActive(true);

        }
       if(pil2.GetComponent<DragDropActivity6>().icindepil2 == true)
        {
            v0.SetActive(false);
            v12.SetActive(false);
            l12.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);

            v6.SetActive(true);
            l6.SetActive(true);

        }

        if(pil3.GetComponent<DragDropActivity6>().icindepil3 == true)
        {
            v0.SetActive(false);
            v12.SetActive(false);
            l12.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);


            v9.SetActive(true);
            l9.SetActive(true);

        }

        if(pil4.GetComponent<DragDropActivity6>().icindepil4 == true)
        {
            v0.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);


            v12.SetActive(true);
            l12.SetActive(true);

        }
        
        if(pil5.GetComponent<DragDropActivity6>().icindepil5 == true)
        {
            v0.SetActive(false);
            v12.SetActive(false);
            l12.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);

            v15.SetActive(true);
            l15.SetActive(true);

        }
        
        if(pil6.GetComponent<DragDropActivity6>().icindepil6 == true)
        {
            v0.SetActive(false);
            v12.SetActive(false);
            l12.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);

            v25.SetActive(true);
            l25.SetActive(true);

        }

    }

    public void anahtarKapat()
    {
            v0.SetActive(true);
            v12.SetActive(false);
            l12.SetActive(false);
            v15.SetActive(false);
            l15.SetActive(false);
            v9.SetActive(false);
            l9.SetActive(false);
            v6.SetActive(false);
            l6.SetActive(false);
            v3.SetActive(false);
            l3.SetActive(false);
            v25.SetActive(false);
            l25.SetActive(false);
    }
}
