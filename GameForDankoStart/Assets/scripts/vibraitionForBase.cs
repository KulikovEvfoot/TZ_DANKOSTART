using UnityEngine;

public class vibraitionForBase : MonoBehaviour
{
    //костыль что работал OnTriggerStay2D
    public Vector2 direction;
    void FixedUpdate()
    {
        transform.Translate(direction);       
        transform.Translate(-direction);       
    }
}
