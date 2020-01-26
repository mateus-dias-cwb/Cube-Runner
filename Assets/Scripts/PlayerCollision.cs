﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement movement;
  void OnCollisionEnter(Collision collisionInfo)
  {
    if (collisionInfo.collider.tag == "Obstacle")
    {
      movement.enabled = false;
      // GetComponent<PlayerMovement>().enabled = false;
      FindObjectOfType<GameManager>().Endgame();
      // GetComponent<>;
    }
  }
}
