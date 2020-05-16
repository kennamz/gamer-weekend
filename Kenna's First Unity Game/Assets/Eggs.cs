using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs : MonoBehaviour
{
    private Transform _myTransform;
    private GameObject eggSprite;
    private Transform _eggSpriteTransform;
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;
        _myTransform.gameObject.SetActive(true);

        eggSprite = GameObject.Find("Eggs");
        _eggSpriteTransform = eggSprite.transform;
        _eggSpriteTransform.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Called when the collider is clicked
    void OnMouseDown()
    {
        _myTransform.gameObject.SetActive(false);
        _eggSpriteTransform.gameObject.SetActive(false);
    }
}
