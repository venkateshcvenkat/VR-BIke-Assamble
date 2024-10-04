using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public GameObject frame1;
    public GameObject makkard1;
    public GameObject body1;
    public GameObject seat1;
    public GameObject tyer1;

    public GameObject engine1;
    public GameObject disk1;
    public GameObject enginescrew1;
    public GameObject diskoiltank1;
    public GameObject bed1;
    public GameObject sprocket1;
    public GameObject chain1;
    public GameObject sprocketscrew1;
    public GameObject handle1;
    public GameObject mound1;
    public GameObject handlescrew1;
    public GameObject display1;
    public GameObject switch1;
    public GameObject killswitch1;
    public GameObject dum1;
    public GameObject indicator1;
    public GameObject wind1;
    public GameObject tail1;
    public GameObject reflector1;
    public GameObject exhaust1;
    public GameObject exhaust2;
    public GameObject mono1;
    public GameObject tele1;
    public GameObject tele21;

    private void Start()
    {
        frame1.SetActive(false);
        makkard1.SetActive(false);
        engine1.SetActive(false);
        disk1.SetActive(false);
        enginescrew1.SetActive(false);
        diskoiltank1.SetActive(false);
        bed1.SetActive(false);
        sprocket1.SetActive(false);
        chain1.SetActive(false);
        sprocketscrew1.SetActive(false);
        handle1.SetActive(false);
        mound1.SetActive(false);
        handlescrew1.SetActive(false);
        display1.SetActive(false);
        switch1.SetActive(false);
        killswitch1.SetActive(false);
        body1.SetActive(false);
        dum1.SetActive(false);
        indicator1.SetActive(false);
        wind1.SetActive(false);
        tail1.SetActive(false);
        reflector1.SetActive(false);
        seat1.SetActive(false);
        tyer1.SetActive(false);
        exhaust1.SetActive(false);
        exhaust2.SetActive(false);
        mono1.SetActive(false);
        tele1.SetActive(false);
        tele21.SetActive(false);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("frame"))
        {
            Destroy(collision.gameObject);
            frame1.SetActive(true);
        }
        if (collision.gameObject.CompareTag("makkard"))
        {
            Destroy(collision.gameObject);
            makkard1.SetActive(true);
        }
        if (collision.gameObject.CompareTag("body"))
        {
            Destroy(collision.gameObject);
            body1.SetActive(true);
        }
        if (collision.gameObject.CompareTag("seat"))
        {
            Destroy(collision.gameObject);
            seat1.SetActive(true);
        }
        if (collision.gameObject.CompareTag("tyer"))
        {
            Destroy(collision.gameObject);
            tyer1.SetActive(true);
        }
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("engine"))
        {
            Destroy(other.gameObject);
            engine1.SetActive(true);
        }

        if (other.gameObject.CompareTag("disk"))
        {
            Destroy(other.gameObject);
            disk1.SetActive(true);
        }
        if (other.gameObject.CompareTag("enginescrew"))
        {
            Destroy(other.gameObject);
            enginescrew1.SetActive(true);
        }
        if (other.gameObject.CompareTag("diskoiltank"))
        {
            Destroy(other.gameObject);
            diskoiltank1.SetActive(true);
        }
        if (other.gameObject.CompareTag("bed"))
        {
            Destroy(other.gameObject);
            bed1.SetActive(true);
        }

        if (other.gameObject.CompareTag("sprocket"))
        {
            Destroy(other.gameObject);
            sprocket1.SetActive(true);
        }
        if (other.gameObject.CompareTag("chain"))
        {
            Destroy(other.gameObject);
            chain1.SetActive(true);
}
        if (other.gameObject.CompareTag("sprocketscrew"))
        {
            Destroy(other.gameObject);
            sprocketscrew1.SetActive(true);
        }
        if (other.gameObject.CompareTag("handle"))
        {
            Destroy(other.gameObject);
            handle1.SetActive(true);
        }
        if (other.gameObject.CompareTag("mound"))
        {
            Destroy(other.gameObject);
            mound1.SetActive(true);
        }
        if (other.gameObject.CompareTag("handlescrew"))
        {
            Destroy(other.gameObject);
            handlescrew1.SetActive(true);
        }
        if (other.gameObject.CompareTag("display"))
        {
            Destroy(other.gameObject);
            display1.SetActive(true);
        }
        if (other.gameObject.CompareTag("switch"))
        {
            Destroy(other.gameObject);
            switch1.SetActive(true);
        }
        if (other.gameObject.CompareTag("killswitch"))
        {
            Destroy(other.gameObject);
            killswitch1.SetActive(true);
        }
        if (other.gameObject.CompareTag("hazhar"))
        {
            Destroy(other.gameObject);
     
        }
        if (other.gameObject.CompareTag("dum"))
        {
            Destroy(other.gameObject);
            dum1.SetActive(true);
        }
        if (other.gameObject.CompareTag("indicator"))
        {
            Destroy(other.gameObject);
            indicator1.SetActive(true);
        }
        if (other.gameObject.CompareTag("wind"))
        {
            Destroy(other.gameObject);
            wind1.SetActive(true);
        }
        if (other.gameObject.CompareTag("tail"))
        {
            Destroy(other.gameObject);
            tail1.SetActive(true);
        }
        if (other.gameObject.CompareTag("reflector"))
        {
            Destroy(other.gameObject);
            reflector1.SetActive(true);
        }
        if (other.gameObject.CompareTag("mono"))
        {
            Destroy(other.gameObject);
            mono1.SetActive(true);
        }
        if (other.gameObject.CompareTag("tele"))
        {
            Destroy(other.gameObject);
            tele1.SetActive(true);
        }
        if (other.gameObject.CompareTag("tele2"))
        {
            Destroy(other.gameObject);
            tele21.SetActive(true);
        }
        if (other.gameObject.CompareTag("exhaust1"))
        {
            Destroy(other.gameObject);
            exhaust1.SetActive(true);
        }
        if (other.gameObject.CompareTag("exhaust2"))
        {
            Destroy(other.gameObject);
            exhaust2.SetActive(true);
        }
    }
}
