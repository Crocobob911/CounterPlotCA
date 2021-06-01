using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactPerish : MonoBehaviour
{
    [SerializeField] GameObject GM;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {



    }
}
