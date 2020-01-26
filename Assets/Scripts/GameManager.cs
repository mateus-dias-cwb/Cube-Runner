using UnityEngine;
using UnityEngine.SceneManagement;
// using System.Collections;

public class GameManager : MonoBehaviour
{
  bool gameHasEnded = false;
  public void Endgame()
  {
    if (!gameHasEnded)
    {
      gameHasEnded = true;
      Invoke("Restart", 1f);
      // StartCoroutine("Restart");
    }
  }

  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  // IEnumerator Restart()
  // {
  //   yield return new WaitForSeconds(1);
  //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  // }
}