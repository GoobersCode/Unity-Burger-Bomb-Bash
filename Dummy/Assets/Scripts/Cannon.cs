using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Transform projectile = Instantiate(projectilePrefab, new Vector3(-1.6f, -1f, 0), Quaternion.identity).transform;
        projectile.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
    }
}
