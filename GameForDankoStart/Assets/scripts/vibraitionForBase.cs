using UnityEngine;

public class vibraitionForBase : MonoBehaviour
{
    //������� ��� ������� OnTriggerStay2D
    public Vector2 direction;
    void FixedUpdate()
    {
        transform.Translate(direction);       
        transform.Translate(-direction);       
    }
}
