using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    //public Transform playerTrans;
    //public float expRadius, explosionForce;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        //rb.AddExplosionForce(explosionForce, playerTrans.position, expRadius);
    }

    // Update is called once per frame
    // FixedUpdate é preferível ao invés de Update para tratar física
    void FixedUpdate()
    {
        //AddForce é uma função para objetos do tipo RigidBodys
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
