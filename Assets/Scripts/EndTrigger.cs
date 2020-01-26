using UnityEngine;

public class EndTrigger : MonoBehaviour
{
  public GameManager manager;
  // Start is called before the first frame update
  void OnTriggerEnter()
  {
    manager.CompleteLevel();
  }
}
