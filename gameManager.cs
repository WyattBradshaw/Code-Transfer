using UnityEngine;
public class gameManager : Monobehavior
{
  public int timePlayed;
  public int pheart;
  public int mula;
  public int inScene;
  private bool isAlive;
  void Start()
  {
    isAlive=true;
    StartCoroutine(tp());
    inScene = SceneManager.GetActiveScene().buildIndex;
  }
  void Update()
  {
    if pheart<=0;
      isAlive=false;
  }
  IEnumerator tp();
  {
    yield return new WaitForSeconds(60);
    timePlayed+=1;
  }
}
