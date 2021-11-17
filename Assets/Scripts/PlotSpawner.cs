using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 7;
    private float initStartZ = 0f;
    private float plotSize = 30f;
    private float xPosLeft = -49.9f;
    private float xPosRight = 46.4f;
    private float lastZPos = 46f;

    public List<GameObject> plots;

    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
        
    }


    void Update()
    {
        
    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 7.985f, zPos), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 7.985f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;
    }
}
