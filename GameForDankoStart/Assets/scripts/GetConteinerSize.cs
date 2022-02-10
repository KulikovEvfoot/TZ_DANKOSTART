using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetConteinerSize : MonoBehaviour
{
    public GameObject[] square;

    public static float conteinerSizeX = 16;
    public static float conteinerSizeY = 10;
    public static int colorCount = 3;

    public void CreateField()
    {
        if (conteinerSizeY > 35)
        {
            Camera.main.orthographicSize = (conteinerSizeX + conteinerSizeY)/2;
        }
        else
        {
            Camera.main.orthographicSize = (conteinerSizeX + conteinerSizeY)/2*0.8f;
        }

        float tempX = conteinerSizeX;
        float tempY = conteinerSizeY;

        for (int i = 0; i < conteinerSizeY; i++)
        {
            tempX = conteinerSizeX;
            for (int j = 0; j < conteinerSizeX; j++)
            {
                var color = Random.Range(0, colorCount);
                Vector2 spawnConteiner = new Vector2(tempX / 2 - 0.5f, tempY / 2 - 0.5f);
                Instantiate(square[color], spawnConteiner, Quaternion.identity);
                tempX -= 2;
            }
            tempY -= 2;
        }
    }

    public void Start()
    {
        CreateField();
    }
}
