using UnityEngine;
using UnityEngine.SceneManagement;
// using System.Collections;

public class GameManager : MonoBehaviour
{
  bool gameHasEnded = false;
  public GameObject completeLevelPanel;
  public Animator score;

  public void CompleteLevel()
  {
    completeLevelPanel.SetActive(true);
    score.enabled = true;
    FindObjectOfType<PlayerMovement>().enabled = false;
    FindObjectOfType<Score>().enabled = false;
  }

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