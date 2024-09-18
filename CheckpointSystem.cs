using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    private int lastCheckpoint = 0;

    void Start()
    {
        lastCheckpoint = LoadCheckpoint();
    }

    public void SaveCheckpoint(int checkpointNumber)
    {
        lastCheckpoint = checkpointNumber;
        PlayerPrefs.SetInt("SavedCheckpoint", lastCheckpoint);
        PlayerPrefs.Save();
    }

    public int LoadCheckpoint()
    {
        return PlayerPrefs.GetInt("SavedCheckpoint", 1); // Start at level 1 by default
    }
}
