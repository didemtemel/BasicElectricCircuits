using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AnahtarActivity3 : MonoBehaviour
{
    public GameObject devre1;
    public GameObject devre2;
    public GameObject devre3;

    public GameObject lightP1;
    public GameObject lightP2;

    public GameObject lightS;

    private Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void anahtarAc()
    {
        if(devre1.GetComponent<DragDropActivity3>().Col1Devre1 == true)
        {
            lightS.SetActive(true);
            Debug.Log("C1d1");
            if(devre2.GetComponent<DragDropActivity3>().Col2Devre2 == true && devre3.GetComponent<DragDropActivity3>().Col3Devre3)
            {
                lightP1.SetActive(true);
                
            }
            else if(devre2.GetComponent<DragDropActivity3>().Col3Devre2 == true && devre3.GetComponent<DragDropActivity3>().Col2Devre3)
            {
                lightP2.SetActive(true);

            }
        }


        if(devre2.GetComponent<DragDropActivity3>().Col1Devre2 == true)
        {
            Debug.Log("c1d2");

            lightS.SetActive(true);

        }
        if(devre2.GetComponent<DragDropActivity3>().Col2Devre2 == true && devre1.GetComponent<DragDropActivity3>().Col3Devre1)
        {
            Debug.Log("c2d2-c3d1");
            lightP1.SetActive(true);
            lightP2.SetActive(true);


        }
        if(devre2.GetComponent<DragDropActivity3>().Col3Devre2 == true && devre1.GetComponent<DragDropActivity3>().Col2Devre1)
        {
            Debug.Log("c3d2-c2d1");
            lightP1.SetActive(true);
            lightP2.SetActive(true);


        }


        if(devre2.GetComponent<DragDropActivity3>().Col2Devre2 == true && devre3.GetComponent<DragDropActivity3>().Col3Devre3)
        {
            Debug.Log("c2d2-c3d3");
            lightP1.SetActive(true);
            anim.Play("electronAS2");

        }



        if(devre1.GetComponent<DragDropActivity3>().Col2Devre1 == true && devre3.GetComponent<DragDropActivity3>().Col3Devre3)
        {
            Debug.Log("c1d2-c3d3");

            lightP1.SetActive(true);

        }
        if(devre2.GetComponent<DragDropActivity3>().Col3Devre2 == true && devre3.GetComponent<DragDropActivity3>().Col2Devre3)
        {
            Debug.Log("c3d2-c2d3");

            lightP2.SetActive(true);

        }

        if(devre1.GetComponent<DragDropActivity3>().Col3Devre1 == true && devre3.GetComponent<DragDropActivity3>().Col2Devre3)
        {
            Debug.Log("c3d1-c2d3");

            lightP2.SetActive(true);

        }
    }

    public void AnahtarKapa()
    {
            lightP1.SetActive(false);
            lightP2.SetActive(false);
            lightS.SetActive(false);

    }
}
