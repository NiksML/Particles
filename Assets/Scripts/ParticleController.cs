using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particle;
    public Transform cube2;

    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        ParticleRotation();
    }

    private void ParticleRotation()
    {
        Vector3 position1 = transform.position;
        Vector3 position2 = cube2.transform.position;
        Vector3 direct = position2 - position1;
        particle.transform.rotation = Quaternion.LookRotation(direct.normalized);
    }
}
