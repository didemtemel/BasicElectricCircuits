using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnahtarActivity9 : MonoBehaviour
{
    
    public GameObject Olumlu1Panel;
    public GameObject Olumsuz1Panel;
    public GameObject Olumlu1Buton;
    public GameObject Olumsuz1Buton;

    public GameObject V1;
    public GameObject V2;
    public GameObject V3;
    public GameObject Vdef;


    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject ADef;

    public GameObject pil1;
    public GameObject pil2;
    public GameObject pil3;

    public GameObject light61;
    public GameObject light62;
    public GameObject light121;
    public GameObject light122;
    public GameObject light251;
    public GameObject light252;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnahtarAcVolt()
    {
         if (pil1.GetComponent<DragDropActivity9>().Volt6 == true)
            {
               
                V1.SetActive(true);
                V2.SetActive(false);
                V3.SetActive(false);
                Vdef.SetActive(false);
            }


            if (pil2.GetComponent<DragDropActivity9>().Volt12 == true)
            {
               
                V2.SetActive(true);
                V1.SetActive(false);
                V3.SetActive(false);
                Vdef.SetActive(false);

            }


            if (pil3.GetComponent<DragDropActivity9>().Volt25 == true)
            {
               
                V3.SetActive(true);
                V1.SetActive(false);
                V2.SetActive(false);
                Vdef.SetActive(false);

            }

    }
    public void AnahtarAcAmper()
    {
            if (pil2.GetComponent<DragDropActivity9>().Amper3 == true)
            {
               
                A2.SetActive(true);
                A1.SetActive(false);
                A3.SetActive(false);
                ADef.SetActive(false);

                light121.SetActive(false);
                light122.SetActive(false);
                light61.SetActive(false);
                light62.SetActive(false);

                light251.SetActive(true);
                light252.SetActive(true);
            }

            if (pil3.GetComponent<DragDropActivity9>().Amper5 == true)
            {
               
                A3.SetActive(true);
                A1.SetActive(false);
                A2.SetActive(false);
                ADef.SetActive(false);

                light251.SetActive(false);
                light252.SetActive(false);
                light61.SetActive(false);
                light62.SetActive(false);

                light121.SetActive(true);
                light122.SetActive(true);
            }
            
            if (pil1.GetComponent<DragDropActivity9>().Amper2 == true)
            {
               
                A1.SetActive(true);
                A2.SetActive(false);
                A3.SetActive(false);
                ADef.SetActive(false);


                light251.SetActive(false);
                light252.SetActive(false);
                light121.SetActive(false);
                light122.SetActive(false);


                light61.SetActive(true);
                light62.SetActive(true);
            }
    }

    public void AnahtarKapatVolt()
    {
                V3.SetActive(false);
                V1.SetActive(false);
                V2.SetActive(false);
                Vdef.SetActive(true);
    }
    public void AnahtarKapatAmper()
    {
                A1.SetActive(false);
                A2.SetActive(false);
                A3.SetActive(false);

                light251.SetActive(false);
                light252.SetActive(false);
                light121.SetActive(false);
                light122.SetActive(false);
                light61.SetActive(false);
                light62.SetActive(false);

                ADef.SetActive(true);

    }
}
