using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour
{

    public float moveSpeed = 200;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        print("Crash");
    }


}