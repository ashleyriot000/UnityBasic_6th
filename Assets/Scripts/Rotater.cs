using UnityEngine;

public class Rotater : MonoBehaviour
{
    //처음 시작할 때 한번만 호출.
    void Start()
    {
        Debug.Log($"{gameObject.name}이고, {transform.position}({transform.localPosition})");
    }

    //매프레임마다 한번씩 호출.
    void Update()
    {
        
    }
}
