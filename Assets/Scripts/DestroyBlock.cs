using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    public GameObject GameManagerGO;
    private GameManager GameManagerComp;
    void Start()
    {
        GameManagerComp = GameManagerGO.GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameManagerComp.BrickRemove();
    }
}
