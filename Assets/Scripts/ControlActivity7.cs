using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ControlActivity7 : MonoBehaviour
{
    public GameObject par;
    public GameObject ser;

    public Dropdown dd7;

    public GameObject Olumlu1Panel;
    public GameObject Olumsuz1Panel;
    public GameObject Olumlu1Buton;
    public GameObject Olumsuz1Buton;
    public GameObject OlumsuzParalelSeriYanlıs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KontrolEt()
    {
        if(dd7.value == 1 && par.GetComponent<DragDropActivity7>().paralelDogru == true && ser.GetComponent<DragDropActivity7>().seriDogru == true)
        {
            Olumlu1Panel.SetActive(true);
            Olumlu1Buton.SetActive(true);
            Debug.Log(dd7.value);

        }

        else if(par.GetComponent<DragDropActivity7>().paralelDogru == false)
        {
            OlumsuzParalelSeriYanlıs.SetActive(true);
            Olumsuz1Buton.SetActive(true);
            Debug.Log(dd7.value);
        }
        
        else if(ser.GetComponent<DragDropActivity7>().seriDogru == false)
        {
            OlumsuzParalelSeriYanlıs.SetActive(true);
            Olumsuz1Buton.SetActive(true);
            Debug.Log(dd7.value);
        }

        else
        {
            Olumsuz1Panel.SetActive(true);
            Olumsuz1Buton.SetActive(true);
            Debug.Log(dd7.value);

        }
    }

}
