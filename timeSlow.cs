
using UnityEngine;
public class timeSlow : Monobehavior
{
  private float t=1f;
  void Update()
  {
    if(Input.GetKey(KeyCode.Z))
    {
      StartCouroutine(time());
    }
    if(Input.GetKeyUp(Keycode.Z))
    {
      StartCouroutine((rtime));
    }
  }
  IEnumerator time()
  {
    foreach (int value in Enumerable.Range(0, 24))
    {
      Time.timeScale = value;
      yield return new WaitForSeconds(.01);
    }
  }
  IEnumerator rtime()
  {
    foreach (int value in Enumerable.Range(0, 24))
    {
      Time.timeScale =  value;
      yield return new WaitForSeconds(.01);
    }
  }  
}