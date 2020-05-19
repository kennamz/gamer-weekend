using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIArrows : MonoBehaviour
{
    private Transform _myTransform;

    private int count = 0;
    public int Timer = 160;

    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= Timer)
        {
            _myTransform.gameObject.SetActive(false);
        }
    }
}
