using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disappear", 3f);
    }

    private void Disappear()
    {
        transform.gameObject.SetActive(false);
    }
}

