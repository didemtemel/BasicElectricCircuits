using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ControlActivity9 : MonoBehaviour
{
    public Dropdown dd6;
    public Dropdown dd12;
    public Dropdown dd25;
    public Dropdown dd3;
    public Dropdown dd2;
    public Dropdown dd5;


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

    public void kontrolEt()
    {
        Debug.Log( "dd6:"+dd6.value + "dd12:"+ dd12.value + "dd25:"+ dd25.value+ "dd3:"+ 
            dd3.value + "dd2:"+ dd2.value + "dd5:"+ dd5.value );

        if(dd6.value == 0 && dd12.value == 2 && dd25.value == 4 && 
            dd3.value == 1 && dd2.value == 2 && dd5.value == 3)
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
