using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    float speed = 0;
    Vector2 starPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //スワイプの長さを求める
        if(Input.GetMouseButtonDown(0))
        {
            this.starPos=Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))

        {
            Vector2 endPos = Input.mousePosition;
            float swipeLegch = endPos.x - this.starPos.x;


            this.speed = swipeLegch / 500.0f;
            //効果音再生
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed,0, 0);
    }
}
