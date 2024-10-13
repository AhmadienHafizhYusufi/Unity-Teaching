using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public Transform goal;

    void Update() {
        if (player == null) {
            // Player lost
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (Vector3.Distance(player.position, goal.position) < 1f) {
            Debug.Log("Player wins!");
        }
    }
}
