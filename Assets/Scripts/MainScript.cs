using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainScript : MonoBehaviour
{
    public Dropdown par1dd;
    public Dropdown par2dd;
    public Dropdown ser1dd;
    public Dropdown ser2dd;
    public Dropdown seriAkimDegisim;
    public Dropdown paralelAkımDegisim;

    public GameObject Olumlu8Panel;
    public GameObject Olumsuz8Panel;
    public GameObject Olumlu8Buton;
    public GameObject Olumsuz8Buton;

    public Dropdown Act6volt3;
    public Dropdown Act6volt6;
    public Dropdown Act6volt9;
    public Dropdown Act6volt12;
    public Dropdown Act6volt15;
    public Dropdown Act6volt25;
    public GameObject Olumlu6Panel;
    public GameObject Olumsuz6Panel;
    public GameObject Olumlu6Buton;
    public GameObject Olumsuz6Buton;

    public Text studentName;
    public Text scene3Text;
    public Text scene4Text;
    public Text scene5Text;
    public Text scene7Text;

    public GameObject Ampul1; 
    public GameObject Pil1; 
    public GameObject Amper1; 
    public GameObject Volt1; 
    public GameObject Kablo1; 
    public GameObject Anahtar1; 
    public GameObject Ind1;

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

    public void yazdir()
    {
        string studentname = studentName.text;
        Debug.Log(studentname);
    }

    public void SpeakingBubble()
    {
        string studentname = studentName.text;
        scene3Text.text = "Merhaba " + studentname + ", ben okul müdürü Didem. Sen yeni gelen elektrik danışmanı olmalısın. Tam zamanında geldin, okulumuz 23 Nisan için özel bir ışıklandırma gösterisi yapmayı planlıyor. Ancak elektrik sisteminde sorun çıktı. Hadi seni okulumuzun teknisyeni ile tanıştırayım.";
        scene4Text.text = "Selam Ege, seni aramıza yeni katılan Elektrik Danışmanınımız " + studentname + " ile tanıştıracağım.";
        scene5Text.text = "Merhaba " + studentname + ", aramıza hoşgeldin.";
        scene7Text.text = studentname + " ile birlite sorunu inceleyeceğiz.";
    }

    public void nexttScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void reloadScene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }

    public void Control1()
    {
        if (Ind1.GetComponent<DragDropActivity1>().inTheChartInd == false && Ampul1.GetComponent<DragDropActivity1>().inTheChartAmpul == true && Amper1.GetComponent<DragDropActivity1>().inTheChartAmper == true &&
         Anahtar1.GetComponent<DragDropActivity1>().inTheChartAnahtar == true && Kablo1.GetComponent<DragDropActivity1>().inTheChartKablo == true && 
         Volt1.GetComponent<DragDropActivity1>().inTheChartVolt == true && Pil1.GetComponent<DragDropActivity1>().inTheChartPil == true)
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

    public void Kontrol6()
    {
        if(Act6volt3.value == 0 && Act6volt6.value == 1 && Act6volt9.value == 2 &&
           Act6volt12.value == 3 && Act6volt15.value == 4 && Act6volt25.value == 5)
          {
            Olumlu6Panel.SetActive(true);
            Olumlu6Buton.SetActive(true);
        }
        else
        {
            Olumsuz6Panel.SetActive(true);
            Olumsuz6Buton.SetActive(true);
        }
    }

    public void Kontrol8()
    {
        if(par1dd.value == 2 && par2dd.value == 0 && ser1dd.value == 1 && 
        ser2dd.value == 1 && seriAkimDegisim.value == 1 && paralelAkımDegisim.value == 1)
        {

            Olumlu8Panel.SetActive(true);
            Olumlu8Buton.SetActive(true);
        }
        else
        {
            Olumsuz8Panel.SetActive(true);
            Olumsuz8Buton.SetActive(true);
        }
 

    }
    public void doExitGame()
    {
        Application.Quit();
    }

}
