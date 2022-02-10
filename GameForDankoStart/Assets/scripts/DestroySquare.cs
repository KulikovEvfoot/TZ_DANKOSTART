using System.Collections.Generic;
using UnityEngine;

public class DestroySquare : MonoBehaviour
{
    private GameObject temp = null;
    private List<GameObject> tempList;
    private string score;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (temp != null)
        {
            if (temp.tag == collision.gameObject.tag)
            {
                if (!tempList.Contains(temp))
                {
                    tempList.Add(temp);

                    for (int i = 0; i < tempList.Count; i++)
                    {
                        foreach (var item in Physics2D.OverlapCircleAll(tempList[i].transform.position, 0.55f))
                        {
                            if ((item.gameObject.tag == temp.tag) && (!tempList.Contains(item.gameObject)))
                            {
                                tempList.Add(item.gameObject);
                            }
                        }
                    }

                    if (tempList.Count > 2)
                    {
                        for (int i = 0; i < tempList.Count; i++)
                        {
                            Debug.Log(score + tempList.Count); 
                            Destroy(tempList[i]);
                        }
                    }
                }
            }
        }
    }

    private void OnMouseDown()
    {
        tempList = new List<GameObject>();
        if (gameObject.tag == "whiteSquare")
        {
            score += "���������� ��������� ����� = ";
            temp = gameObject;
        }
        if (gameObject.tag == "blackSquare")
        {
            score += "���������� ��������� ������ = ";
            temp = gameObject;
        }
        if (gameObject.tag == "redSquare")
        {
            score += "���������� ��������� ������� = ";
            temp = gameObject;
        }
        if (gameObject.tag == "yellowSquare")
        {
            score += "���������� ��������� ������ = ";
            temp = gameObject;
        }
        if (gameObject.tag == "greenSquare")
        {
            score += "���������� ��������� ������� = ";
            temp = gameObject;
        }
    }
}
