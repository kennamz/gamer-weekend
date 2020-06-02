using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FishFoodBottle : MonoBehaviour, IPointerClickHandler
{
    private GameObject fishFlakes;
    // Start is called before the first frame update
    void Start()
    {
        fishFlakes = GameObject.Find("fish flakes");
        fishFlakes.transform.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        fishFlakes.transform.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
