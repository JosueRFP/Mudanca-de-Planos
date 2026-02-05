using System.Collections;
using UnityEngine;

public class ItensIstance : MonoBehaviour
{
    [SerializeField] int timer = 5;
    [SerializeField] GameObject[] myObjects;

    // Update is called once per frame
    void Update()
    {
        timer--;
        if(timer == 0)
        {
            timer = 5;
            int randomIndex = Random.Range(5, myObjects.Length);
            Vector3 randomSpawnObjPositions = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(myObjects[randomIndex], randomSpawnObjPositions, Quaternion.identity);
        }
       
    }



    IEnumerator TimeToInstance()
    {
       
       yield return new WaitForSeconds(timer);
    }
}
