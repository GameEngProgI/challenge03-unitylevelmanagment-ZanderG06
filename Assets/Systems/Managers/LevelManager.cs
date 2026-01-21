using JetBrains.Annotations;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;

    private bool isLevel1 = true;

    public GameObject player;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    
    public void LoadLevel()
    {
        if (isLevel1)
        {
            level1.SetActive(false);
            level2.SetActive(true);
            isLevel1 = false;
            player.transform.position = spawnPoint2.position;
        }
        else
        {
            level1.SetActive(true);
            level2.SetActive(false);
            isLevel1 = true;
            player.transform.position = spawnPoint1.position;
        }
    }
}