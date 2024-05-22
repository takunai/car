using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TextMeshProを使うために必要

public class GameDirector : MonoBehaviour
{
    [SerializeField]GameObject car;
    [SerializeField]GameObject flag;
    [SerializeField]GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x -
            this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text =
            "Distance:" + length.ToString("F2") + "m";
    }
}
