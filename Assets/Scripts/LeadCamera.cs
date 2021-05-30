using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadCamera : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    public float CameraZ = -10;
    private Vector3 direction;
    private int i=0;

    public void recieveRot(Vector3 rot)
    {
        direction=rot;
    }


    // Start is called before the first frame update
    void Start()
    {
        i = 1 ;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        Vector3 TargetPos = new Vector3(Target.transform.position.x+ direction.x, Target.transform.position.y +  direction.y , CameraZ);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * 1f);
    }
}
