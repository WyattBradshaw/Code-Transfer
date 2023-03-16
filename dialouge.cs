using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialouge : MonoBehaviour 
{
    public string dia;
    public int dint=dialouge.Length;
    public AudioClip boop;
    public GameObject Player;
    public GameObject cCam;
    public int dc=0;
    public int character= 0;
    public GameObject DUI;

    public TextMeshProUGUI ttext;
    public AudioSource main;
    public AudioClip cont;
    public AudioClip basho1;
    public AudioClip Basho2;
    public AudioClip Basho3;
    void Awake()
    {
        dc=0;
        ttext.SetText("Awaiting Dialouge...");
        Player.SetActive(false);
        cCam.SetActive(true);

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            main.PlayOneShot(cont);
            if(character=0)
            {
                if(dc<0)
                {
                    dc=0;
                }
                if(dc=0)
                {
                    dia="Child, What A terrible Fate";
                    dint=dia.Length;
                    foreach(int value in Enumerable.Range(0,dint))
                    {
                        c=dia[value];
                        string temp=""+c;
                        ttext.SetText(temp);
                    }
                    main.PlayOneShot(basho1);
                    ttext.SetText("Child, What A terrible Fate");
                }
                if(dc=1)
                {
                    dia="New honors are upon you";
                    dint=dia.Length;
                    foreach(int value in Enumerable.Range(0,dint))
                    {
                        c=dia[value];
                        string temp=""+c;
                        ttext.SetText(temp);
                    }
                    main.PlayOneShot(basho1);
                    ttext.SetText("New honors are upon you");
                }
                if(dc=2)
                {
                    dia="Like Our Strange Garments, Cleave not to the mold!";
                    dint=dia.Length;
                    foreach(int value in Enumerable.Range(0,dint))
                    {
                        c=dia[value];
                        string temp=""+c;
                        ttext.SetText(temp);
                    }
                    main.PlayOneShot(Basho3);
                    ttext.SetText("Like Our Strange Garments, Cleave not to the mold!");
                }                
                if(dc=3)
                {
                    dia="sav is cute";
                    dint=dia.Length;
                    foreach(int value in Enumerable.Range(0,dint))
                    {
                        c=dia[value];
                        string temp=""+c;
                        ttext.SetText(temp);
                    }
                    main.PlayOneShot(Basho2);
                    ttext.SetText("sav is cute");
                }
                
                
                
            } 
        }
    }
}
