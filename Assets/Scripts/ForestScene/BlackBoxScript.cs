using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoxScript : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject remains;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(remains, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(remains, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       */
    }
}
