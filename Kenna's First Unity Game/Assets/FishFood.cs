using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishFood : MonoBehaviour
{
    private Transform _myTransform;
    public int max = 200;
    private int count = 0;
    public float Speed = 5f;
    private int state = 0; //0 is inactive, 1 is falling, 2 is unmoving
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0 && gameObject.activeSelf)
        {
            state = 1;
        }

        if (state == 1)
        {
            Vector3 TargetPosition = new Vector3(0, 5, 1);
            var moveAmount = Speed * Time.deltaTime;
            _myTransform.position = Vector3.MoveTowards(_myTransform.position, TargetPosition, moveAmount);
            if (_myTransform.position == TargetPosition)
            {
                state = 2;
            }
        }

        if (state == 2)
        {
            count++;
            if (count >= max)
            {
                state = 0;
                count = 0;
                Vector3 TargetPosition = new Vector3(0, 13, 1);
                _myTransform.position = TargetPosition;
                _myTransform.gameObject.SetActive(false);
            }
        }
    }
}
