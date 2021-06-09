using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Material gray;
    public Material red;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.5f)
        {
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Collision : " + collision.gameObject.name);
    //    ParticleSystem obj = Instantiate(ps);
    //    obj.transform.position = transform.position;
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger : " + other.gameObject.name);
        other.gameObject.GetComponent<Renderer>().material = red;

    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material = gray;

    }
}
