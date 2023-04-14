using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public GameObject GameManagerGO;
    private GameManager GameManagerComp;
    void Start()
    {
        GameManagerComp = GameManagerGO.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        GameManagerComp.BallRemove();
    }
}
