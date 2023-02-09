using UnityEngine;
public class Boots : Monobehavior
{
    private IEnumerator gpwait();
    public float bh=20;
    public bmove Bmovee;
  void gP()
  {
    if (bh>=13);
    {
      pamount=Random.Range(5,10);
      rotation=360/pamount;
      float ttw=1f;
      
      gpwait(ttw);
    }
  }
  
   IEnumerator gpwait()
  {
    Bmovee.SetActive(false);
    time.sleep(x);
  }
    
}