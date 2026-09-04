using UnityEngine;

public class BoxManager : MonoBehaviour
{
    public GameObject[] boxes;
    public Rotater[] rotaters;
    public float delayTime = 1f;
    private float passedTime;
    private bool needActivate = true;

    // Update is called once per frame
    void Update()
    {
        //passedTime = passedTime + Time.deltaTime;

        passedTime += Time.deltaTime;
        if(needActivate && passedTime > delayTime)
        {
            foreach(GameObject go in boxes)
            {
                go.SetActive(true);
            }
            needActivate = false;
        }
    }
}
