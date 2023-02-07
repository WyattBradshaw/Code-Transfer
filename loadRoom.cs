using UnityEngine;
using TMPro;
public class loadRoom : Monobehavior
{  
  public TMP_Text aTime;
  public GameObject Door;
  public GameObject lDoor;
  public GameObject Level;
  public GameObject Treasure;
  public int eNum;
  public bool istreasure;
  
  private float time;
  private bool started=false;
  
  
  #CHANGE ENEMY SCRIPT TO SUBTRACT FROM ENUM EVERYDEATH
  
  void Start() 
  {
    started=false;
  }
      
  void Update()
  {
    if started==true;
    { 
      if eNum<=0;   
      {
        StopCoroutine(arenaTime());
        Door.SetActive(True)
        lDoor.SetActive(False)
        atime.SetText(time.ToString();
        if isTreasure==true;
        {
          Treasure.SetActive(True)
        }
      }
    }
  }
  
  void onCollisonEnter(Collider,collison)
  {    
    if collison.tag == "Player"
    {
      if started==false
      {
        StartCoroutine(arenaTime());
        started=true;
        Door.SetActive(false);
        lDoor.Setctive(true);
        if isTreasure==true;
        {
          Treasure.SetActive(false)
        }
      }
    }
  }
  IEnumerator arenaTime()
  {
    yield return new WaitForSeconds(.01);
    time+=.01;
  }
}  
