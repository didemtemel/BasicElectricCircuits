using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlActivity5 : MonoBehaviour
{
    public GameObject devre1;
    public GameObject devre2;
    public GameObject devre3;
    public GameObject devre4;
    public GameObject devre5;
    public GameObject devre6;
    public GameObject devre7;
    public GameObject devre8;


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

    public void kontrol5()
    {
         if( devre1.GetComponent<DragDropActivity5>().icindedevre1 == true && devre5.GetComponent<DragDropActivity5>().icindedevre5 == true &&
         devre2.GetComponent<DragDropActivity5>().icindedevre2 == true && devre6.GetComponent<DragDropActivity5>().icindedevre6 == true &&
         devre3.GetComponent<DragDropActivity5>().icindedevre3 == true && devre7.GetComponent<DragDropActivity5>().icindedevre7 == true &&
         devre4.GetComponent<DragDropActivity5>().icindedevre4 == true && devre8.GetComponent<DragDropActivity5>().icindedevre8 == true )
       
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
}
