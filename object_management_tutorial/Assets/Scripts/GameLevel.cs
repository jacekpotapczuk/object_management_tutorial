using UnityEngine;

public class GameLevel : MonoBehaviour {

    [SerializeField]
    private SpawnZone spawnZone;

    void Start()
    {
        Game.Instance.SpawnZoneOfLevel = spawnZone;
    }
}
