using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;
    [SerializeField]
    private GameObject redbug;
    [SerializeField]
    private GameObject pinkbug;
    [SerializeField]
    private GameObject orangebug;
    [SerializeField]
    private GameObject purplebug;

    [SerializeField]
    private GameObject leftSpawnPoint;
    [SerializeField]
    private GameObject rightSpawnPoint;
    [SerializeField]
    private GameObject powerUpSpawnPoint;
    [SerializeField]
    private Transform[] spawnPoints;

    [SerializeField]
    private int currentLevel = 0;
    private int enemiesLeft = 0;
    private bool spawningWave = false;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }

    void Update()
    {
        if (enemiesLeft == 0 && !spawningWave)
        {
            SpawnWave();
        }
    }

    void SpawnWave()
    {
        spawningWave = true;
        GameObject go;
        switch (currentLevel)
        {
            case 1:
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;

                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                enemiesLeft = 4;
                break;
            case 2:
                Instantiate(GameController.Instance.PowerUp, powerUpSpawnPoint.transform.position, Quaternion.identity);

                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[6].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[36].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;

                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[10].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[48].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                enemiesLeft = 10;
                break;
            case 3:
                Instantiate(GameController.Instance.PowerUp, powerUpSpawnPoint.transform.position, Quaternion.identity);

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[6].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[36].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[10].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[48].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;
                enemiesLeft = 16;
                break;
            case 4:
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[6].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[36].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[10].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[46].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[48].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[44].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[28].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;
                enemiesLeft = 20;
                break;
            case 5:
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[6].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[36].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[10].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[46].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[48].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[44].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[28].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;
                enemiesLeft = 20;
                break;
            case 6:
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(redbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(redbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 24;
                break;
            case 7:
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 24;
                break;
            case 8:
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[17].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[19].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[21].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[25].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[27].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[29].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[31].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[33].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 33;
                break;
            case 9:
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[17].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[19].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[21].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[25].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[27].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[29].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[31].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[33].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[51].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;

                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(pinkbug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(pinkbug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 42;
                break;
            case 10:
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[17].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[19].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[21].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[25].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[27].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[29].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[31].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[33].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[51].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;

                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(orangebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(orangebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 42;
                break;
            case 11:
            case 12:
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[1].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[3].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[5].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[7].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[9].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[11].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[13].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[15].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[17].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[19].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[21].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[23].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[25].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[27].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[29].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[31].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[33].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[35].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[37].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[39].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[41].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[43].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[45].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[47].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[49].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[51].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[53].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[55].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[57].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[59].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[61].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[63].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[65].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[67].position;

                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[69].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[71].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[73].position;
                go = Instantiate(purplebug, leftSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[75].position;

                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[77].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[79].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[81].position;
                go = Instantiate(purplebug, rightSpawnPoint.transform.position, Quaternion.identity);
                go.GetComponent<Bug>().targetPosition = spawnPoints[83].position;

                enemiesLeft = 42;
                break;
            case 13:
                GameController.Instance.CompleteGame();
                break;
            default:
                break;
        }
        currentLevel++;
        spawningWave = false;
    }
    public void OnEnemyKilled()
    {
        enemiesLeft--;
    }
}
