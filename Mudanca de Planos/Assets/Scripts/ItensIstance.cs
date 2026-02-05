using System.Collections;
using UnityEngine;

public class ItensIstance : MonoBehaviour
{
    float timer = 15f;
    [SerializeField] GameObject[] myObjects;


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 30;
            print("nasceu");
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnObjPositions = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(myObjects[randomIndex], randomSpawnObjPositions, Quaternion.identity);
        }
       
    }
}
