using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    public GameObject nextLevel;
    public GameObject currentLevel;
    public Transform spawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) levelManager.LoadLevel(nextLevel, currentLevel, spawn);
    }
}
