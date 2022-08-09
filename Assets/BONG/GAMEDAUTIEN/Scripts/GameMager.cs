using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.DefenseBasic
{

    public class GameMager : MonoBehaviour
    {
        public float spawnTime;
        public Enemy[] enemPrefabs;
        private bool m_isGameover;
        private int m_score;

        public int Score { get => m_score; set => m_score = value; }



        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnEnemy());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator SpawnEnemy()
        {
            while (!m_isGameover)
            {
                if (enemPrefabs != null && enemPrefabs.Length > 0)
                {
                    int randIdx = Random.Range(0, enemPrefabs.Length);
                    Enemy enemyPrefab = enemPrefabs[randIdx];

                    if (enemyPrefab)
                    {
                        Instantiate(enemyPrefab, new Vector3(8, 0, 0), Quaternion.identity);
                    }
                }

                yield return new WaitForSeconds(spawnTime);
            }
        }
    }

}