using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearmoneda: MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float yPosition;
    public gamemanager gamemanager;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        Vector2 positioncreate = new Vector2(xposition, yPosition);
        GameObject moneda = Instantiate(prefabEnemy, positioncreate, transform.rotation);
        moneda.GetComponent<moneda>().SetEnemyconteiner(this);
        Invoke("Createenemy", 1.0f);
    }
    public void IncreasePoitns(int pointsToAdd)
    {
        gamemanager.IncreasePoitns(pointsToAdd);
    }
}
