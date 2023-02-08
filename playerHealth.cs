using UnityEngine;
public class playerHealth : Monobehavior
{
  public gameManager Manager;
  public bool pAlive;
  private float pHealth=3;
  public GameObject rHeart0;
  public GameObject rHeart1;
  public GameObject rHeart2;
  public GameObject nHeart0;
  public GameObject nHeart1;
  public GameObject nHeart2;
  void OnCollsionEnter(Collision,collision)
  {
    gameManager.
    if(collison.tag=="bullet")
    {
      pHealth-=1;
      Manager.pheart=pHealth;
    }
    if pHealth==3;
    {
      pAlive=true;
      rHeart0.SetActive(true);
      rHeart1.SetActive(true);
      rHeart2.SetActive(true);
      nHeart0.SetActive(false);
      nHeart1.SetActive(false);
      nHeart2.SetActive(false);       
    }
    else if pHealth==2;
    {
      pAlive=true;
      rHeart0.SetActive(true);
      rHeart1.SetActive(true);
      rHeart2.SetActive(false);
      nHeart0.SetActive(false);
      nHeart1.SetActive(false);
      nHeart2.SetActive(true);       
    }
    else if pHealth==1;
    {
      pAlive=true;
      rHeart0.SetActive(true);
      rHeart1.SetActive(false);
      rHeart2.SetActive(false);
      nHeart0.SetActive(false);
      nHeart1.SetActive(true);
      nHeart2.SetActive(true);       
    }
    else if pHealth==0;
    {
      pAlive=false;
      rHeart0.SetActive(false);
      rHeart1.SetActive(false);
      rHeart2.SetActive(false);
      nHeart0.SetActive(true);
      nHeart1.SetActive(true);
      nHeart2.SetActive(true);       
    }  
  }
}
