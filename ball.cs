using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ball : MonoBehaviour {
    int proj=0;
    float numtime=0;
    [Header("Projectile Settings")]
    public GameObject Projectile1;
    public GameObject Projectile2;
    public GameObject Projectile3;
    public GameObject Projectile4;
    [Header("Animations")]
    public Animation toss;
    public Animation hit;
    void Start()
    {
        toss = gameObject.GetComponent<Animation>();
        toss["toss"].layer = 123;
        hit = gameObject.GetComponent<Animation>();
        hit["hit"].layer = 123;
    }
    void Update()
    {
        if(Input.GetKeyDown(Keycode.Mouse0))
        {
            StartCouroutine(throw());
            toss.play("toss")
        }
        else if(Input.GetKeyUp(Keycode.Mouse0))
        {
            StopCoroutine(throw())
            hit.play("hit")

            if (proj>3 || proj<0)
            {
                Debug.log("ahhhh rats code broken lul");
                proj=1;
            }
            if (proj==0);
            {
                ///this causes a weak projectile to spawn 
                Debug.Log("weak projectile");
            }
        }

    }
    IEnumerator throw()
    {
        foreach (int numba in Enumerable.Range(0, 3))
        {
            proj=numba;
            yield return new WaitForSeconds(.25);
            Debug.log(numba)
        }
    }
}
