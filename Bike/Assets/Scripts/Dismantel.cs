using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dismantel : MonoBehaviour
{

    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;
    void Start()
    {
        anim1.enabled = false;
        anim2.enabled = false;
        anim3.enabled = false;
        anim4.enabled = false;
        anim5.enabled = false;
        anim6.enabled = false;
        anim7.enabled = false;
        anim8.enabled = false;
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            StartCoroutine(ani1());
        }
    }
    IEnumerator ani1()
    {
        anim1.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani2());
    }
    IEnumerator ani2()
    {
        anim2.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani3());
    }

    IEnumerator ani3()
    {
        anim3.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani4());
    }
    IEnumerator ani4()
    {
        anim4.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani5());
    }
    IEnumerator ani5()
    {
        anim5.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani6());
    }
    IEnumerator ani6()
    {
        anim6.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani7());
    }
    IEnumerator ani7()
    {
        anim7.enabled = true;
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(ani8());
    }
    IEnumerator ani8()
    {
        anim8.enabled = true;
        yield return new WaitForSeconds(3f);
       
    }
}
