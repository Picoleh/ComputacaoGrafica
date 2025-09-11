using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotateSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Roda pião");
    }

    // Update is called once per frame
    void Update()
    {
        speed +=  0.05f * System.MathF.Sin(Time.time / 3f) * Time.deltaTime;
        transform.Translate(speed, 0, 0);
        transform.Rotate(rotateSpeed * 0.5f * System.MathF.Sin(Time.time / 3f), rotateSpeed * 0.5f * System.MathF.Sin(Time.time / 2f), rotateSpeed * 0.5f * System.MathF.Sin(Time.time / 5f));
    }
}
