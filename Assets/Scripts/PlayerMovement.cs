using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  public float forwardForce = 2000f;
  public float sidewaysForce = 1000f;

  // FixedUpdate é preferível ao invés de Update para tratar física
  void FixedUpdate()
  {
    //AddForce é uma função para objetos do tipo RigidBodys
    rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Adiciona uma força constante para "frente"

    if (Input.GetKey("d"))
    {
      rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    if (Input.GetKey("a"))
    {
      rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
  }
}
