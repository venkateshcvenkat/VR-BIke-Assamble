using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public GameObject destroy;

    private void OnMouseDown()
    {
        Instantiate(destroy, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
