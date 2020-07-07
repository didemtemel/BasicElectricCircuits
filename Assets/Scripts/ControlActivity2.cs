using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ControlActivity2 : MonoBehaviour
{
   public GameObject Ampulc;
    public GameObject AmpulcX;
    public GameObject AmpulcTik;

    public GameObject Pilc;
    public GameObject PilcX;
    public GameObject PilcTik;

    public GameObject Kabloc;
    public GameObject KablocX;
    public GameObject KablocTik;

    public GameObject Ampermetrec;
    public GameObject AmpermetrecX;
    public GameObject AmpermetrecTik;

    public GameObject Anahtarc;
    public GameObject AnahtarcX;
    public GameObject AnahtarcTik;

    public GameObject Voltmetrec;
    public GameObject VoltmetrecX;
    public GameObject VoltmetrecTik;

    
    

    public GameObject Olumlu1Panel;
    public GameObject Olumsuz1Panel;
    public GameObject Olumlu1Buton;
    public GameObject Olumsuz1Buton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 public void Kontrol()
    {
        //c

       if (Ampulc.GetComponent<DragDropActivity2>().inTheChartAmpul == true)
        {
            AmpulcX.SetActive(false);
            AmpulcTik.SetActive(true);

        }
        if(Ampulc.GetComponent<DragDropActivity2>().inTheChartAmpul == false) 
        {
            AmpulcX.SetActive(true);
            AmpulcTik.SetActive(false);

        }

        if (Pilc.GetComponent<DragDropActivity2>().inTheChartPil == true)
        {
            PilcX.SetActive(false);
            PilcTik.SetActive(true);

        }
        if (Pilc.GetComponent<DragDropActivity2>().inTheChartPil == false)
        {
            PilcX.SetActive(true);
            PilcTik.SetActive(false);

        }
        if (Kabloc.GetComponent<DragDropActivity2>().inTheChartKablo == true)
        {
            KablocX.SetActive(false);
            KablocTik.SetActive(true);

        }
        if (Kabloc.GetComponent<DragDropActivity2>().inTheChartKablo == false)
        {
            KablocX.SetActive(true);
            KablocTik.SetActive(false);

        }
        if (Ampermetrec.GetComponent<DragDropActivity2>().inTheChartAmper == true)
        {
            AmpermetrecX.SetActive(false);
            AmpermetrecTik.SetActive(true);

        }
        if (Ampermetrec.GetComponent<DragDropActivity2>().inTheChartAmper == false)
        {
            AmpermetrecX.SetActive(true);
            AmpermetrecTik.SetActive(false);

        }
        if (Anahtarc.GetComponent<DragDropActivity2>().inTheChartAnahtar == true)
        {
            AnahtarcX.SetActive(false);
            AnahtarcTik.SetActive(true);

        }
        if (Anahtarc.GetComponent<DragDropActivity2>().inTheChartAnahtar == false)
        {
            AnahtarcX.SetActive(true);
            AnahtarcTik.SetActive(false);

        }

        if (Voltmetrec.GetComponent<DragDropActivity2>().inTheChartVolt == true)
        {
            VoltmetrecX.SetActive(false);
            VoltmetrecTik.SetActive(true);

        }
        if (Voltmetrec.GetComponent<DragDropActivity2>().inTheChartVolt == false)
        {
            VoltmetrecX.SetActive(true);
            VoltmetrecTik.SetActive(false);

        }

    }


   public void kontrol2()

   {
       Debug.Log("");
       if(Anahtarc.GetComponent<DragDropActivity2>().inTheChartAnahtar == true &&  
            Kabloc.GetComponent<DragDropActivity2>().inTheChartKablo == true &&  
            Voltmetrec.GetComponent<DragDropActivity2>().inTheChartVolt == true  &&
            Ampulc.GetComponent<DragDropActivity2>().inTheChartAmpul == true   && 
            Ampermetrec.GetComponent<DragDropActivity2>().inTheChartAmper == true &&  Pilc.GetComponent<DragDropActivity2>().inTheChartPil == true )
       
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
    public void kontrolKapat()
    {
        VoltmetrecX.SetActive(false);
        VoltmetrecTik.SetActive(false);
        AnahtarcX.SetActive(false);
        AnahtarcTik.SetActive(false);
        AmpermetrecX.SetActive(false);
        AmpermetrecTik.SetActive(false);
        KablocX.SetActive(false);
        KablocTik.SetActive(false);
        PilcX.SetActive(false);
        PilcTik.SetActive(false);
        AmpulcX.SetActive(false);
        AmpulcTik.SetActive(false);
    }
}
    
