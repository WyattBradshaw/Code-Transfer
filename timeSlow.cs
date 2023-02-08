using UnityEngine;
public class timeSlow : Monobehavior
{
  private float t=1f;
  void Update();
  {
    if(Input.GetKeyDown(KeyCode.Z)
    {
      StartCouroutine(
    }
  }
  IEnumerator time()
  {
    foreach (int value in Enumerable.Range(0, 24))
    {
      Time.timeScale = value
      yield return new WaitForSeconds(.01);
    }
  }
}
